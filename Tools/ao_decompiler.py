#!/usr/bin/env python3
"""
AO Ghidra + Il2CppDumper Fast Indexer & Decompiler Assistant
============================================================
Indexes:
  1. Ghidra C export (`exportAOJP.c`, ~149 MB)
  2. Il2CppDumper `script.json` (strings, TypeInfo, generic MethodInfo, method addresses)
  3. Il2CppDumper `dump.txt` (class layouts, field offsets, nested iterators/closures)

Database is stored at `Temp/ao_ghidra_index.db` (ignored by Git & Unity).

Usage:
  python Tools/ao_decompiler.py build
  python Tools/ao_decompiler.py inspect <ClassName> [--no-nested]
  python Tools/ao_decompiler.py method <ClassName> <MethodFilter>
  python Tools/ao_decompiler.py raw <CFunctionName>
  python Tools/ao_decompiler.py search <Keyword>
  python Tools/ao_decompiler.py stubs [SubfolderOrFilter]
"""

import argparse
import glob
import json
import os
import re
import sqlite3
import sys
import time

WORKSPACE_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DB_PATH = os.path.join(WORKSPACE_ROOT, "Temp", "ao_ghidra_index.db")

GHIDRA_C_PATH = r"E:\ProjectAO\GhỉraExport\exportAOJP.c"
DUMP_TXT_PATH = r"E:\ProjectAO\GhỉraExport\dump.txt"
SCRIPT_JSON_GLOB = r"E:\ProjectAO\ProjectAOJP\APK\*\armeabi-v7a\script.json"
LIBIL2CPP_GLOB = r"E:\ProjectAO\ProjectAOJP\APK\*\armeabi-v7a\libil2cpp.so"

KNOWN_RUNTIME_HELPERS = {
    0x00E0FA50: "il2cpp_codegen_raise_null_reference",
    0x00DF7E68: "il2cpp_runtime_class_init",
    0x00DE2490: "il2cpp_codegen_initialize_method",
    0x00DD5E38: "il2cpp_object_new",
    0x00DD772C: "il2cpp_Steps_interface_lookup",
    0x00E0F910: "il2cpp_raise_exception",
}


def find_script_json() -> str:
    matches = glob.glob(SCRIPT_JSON_GLOB)
    if not matches:
        raise FileNotFoundError(f"Could not find script.json matching {SCRIPT_JSON_GLOB}")
    return matches[0]


def connect_db() -> sqlite3.Connection:
    os.makedirs(os.path.dirname(DB_PATH), exist_ok=True)
    conn = sqlite3.connect(DB_PATH)
    conn.row_factory = sqlite3.Row
    return conn


def extract_c_name_from_signature(sig: str) -> str:
    # Example: "void System_Object___ctor (Il2CppObject* __this, const MethodInfo* method);"
    idx = sig.find("(")
    if idx == -1:
        return ""
    left = sig[:idx].strip()
    parts = left.split()
    return parts[-1].lstrip("*") if parts else ""


def build_index() -> None:
    t0 = time.time()
    script_json_path = find_script_json()
    print(f"[1/4] Creating SQLite index at: {DB_PATH}")
    if os.path.exists(DB_PATH):
        os.remove(DB_PATH)

    conn = connect_db()
    cur = conn.cursor()
    cur.executescript(
        """
        PRAGMA synchronous = OFF;
        PRAGMA journal_mode = MEMORY;

        CREATE TABLE meta_info (
            key TEXT PRIMARY KEY,
            value TEXT
        );

        CREATE TABLE c_functions (
            c_name TEXT PRIMARY KEY,
            signature TEXT,
            byte_offset INTEGER,
            byte_length INTEGER
        );

        CREATE TABLE metadata_addrs (
            addr INTEGER PRIMARY KEY,
            kind TEXT,
            label TEXT
        );

        CREATE TABLE il2cpp_methods (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            addr INTEGER,
            cs_class TEXT,
            cs_method TEXT,
            c_name TEXT,
            signature TEXT
        );

        CREATE TABLE dump_types (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            namespace TEXT,
            type_name TEXT,
            full_name TEXT,
            byte_offset INTEGER,
            byte_length INTEGER,
            fields_json TEXT
        );
        """
    )

    # 1. Load script.json
    print(f"[2/4] Indexing {script_json_path} ...")
    with open(script_json_path, "r", encoding="utf-8") as f:
        sdata = json.load(f)

    addr_rows = []
    for item in sdata.get("ScriptString", []):
        val = item["Value"].replace("\r", "\\r").replace("\n", "\\n")
        if len(val) > 120:
            val = val[:117] + "..."
        addr_rows.append((item["Address"], "String", f'"{val}"'))

    for item in sdata.get("ScriptMetadata", []):
        addr_rows.append((item["Address"], "TypeInfo", item["Name"]))

    for item in sdata.get("ScriptMetadataMethod", []):
        addr_rows.append((item["Address"], "MethodInfo", item["Name"]))

    method_rows = []
    for item in sdata.get("ScriptMethod", []):
        addr = item["Address"]
        full = item["Name"]
        sig = item.get("Signature", "")
        c_name = extract_c_name_from_signature(sig)
        if "$$" in full:
            cs_class, cs_method = full.split("$$", 1)
        else:
            cs_class, cs_method = "", full
        method_rows.append((addr, cs_class, cs_method, c_name, sig))
        addr_rows.append((addr, "Code", full))

    cur.executemany(
        "INSERT OR REPLACE INTO metadata_addrs (addr, kind, label) VALUES (?, ?, ?)",
        addr_rows,
    )
    cur.executemany(
        "INSERT INTO il2cpp_methods (addr, cs_class, cs_method, c_name, signature) VALUES (?, ?, ?, ?, ?)",
        method_rows,
    )
    conn.commit()
    print(f"      -> {len(addr_rows):,} metadata addresses, {len(method_rows):,} IL2CPP methods")

    # 2. Parse dump.txt
    print(f"[3/4] Indexing {DUMP_TXT_PATH} ...")
    ns_re = re.compile(rb"^// Namespace:\s*(.*)$")
    type_re = re.compile(
        rb"^(?:public|private|protected|internal|abstract|sealed|static|\s)*"
        rb"(?:class|struct|interface|enum)\s+([^\s:<]+).*?// TypeDefIndex:\s*\d+"
    )
    field_re = re.compile(rb"^\t(?:public|private|protected|internal|readonly|\s)+(.+?)\s+([^\s;]+);\s*//\s*(0x[0-9A-Fa-f]+)")

    dump_rows = []
    with open(DUMP_TXT_PATH, "rb") as f:
        cur_ns = ""
        cur_type = None
        cur_full = None
        type_start = 0
        brace_depth = 0
        in_type = False
        fields_map = {}

        while True:
            line_offset = f.tell()
            line = f.readline()
            if not line:
                break
            stripped = line.strip()

            if not in_type:
                m_ns = ns_re.match(stripped)
                if m_ns:
                    cur_ns = m_ns.group(1).decode("utf-8", errors="replace").strip()
                    type_start = line_offset
                    continue

                m_type = type_re.match(stripped)
                if m_type:
                    cur_type = m_type.group(1).decode("utf-8", errors="replace").strip()
                    cur_full = f"{cur_ns}.{cur_type}" if cur_ns else cur_type
                    in_type = True
                    fields_map = {}
                    brace_depth = line.count(b"{") - line.count(b"}")
                    if brace_depth <= 0 and b"{" in line and b"}" in line:
                        dump_rows.append(
                            (
                                cur_ns,
                                cur_type,
                                cur_full,
                                type_start,
                                f.tell() - type_start,
                                json.dumps(fields_map),
                            )
                        )
                        in_type = False
            else:
                m_field = field_re.match(line.rstrip(b"\r\n"))
                if m_field:
                    ftype = m_field.group(1).decode("utf-8", errors="replace").strip()
                    fname = m_field.group(2).decode("utf-8", errors="replace").strip()
                    foff = m_field.group(3).decode("utf-8", errors="replace").lower()
                    fields_map[foff] = f"{fname} ({ftype})"

                brace_depth += line.count(b"{") - line.count(b"}")
                if brace_depth <= 0:
                    dump_rows.append(
                        (
                            cur_ns,
                            cur_type,
                            cur_full,
                            type_start,
                            f.tell() - type_start,
                            json.dumps(fields_map),
                        )
                    )
                    in_type = False

    cur.executemany(
        "INSERT INTO dump_types (namespace, type_name, full_name, byte_offset, byte_length, fields_json) VALUES (?, ?, ?, ?, ?, ?)",
        dump_rows,
    )
    conn.commit()
    print(f"      -> {len(dump_rows):,} C# TypeDefs indexed from dump.txt")

    # 3. Parse exportAOJP.c
    print(f"[4/4] Indexing {GHIDRA_C_PATH} (~149 MB) ...")
    c_func_rows = []
    ident_re = re.compile(r"([A-Za-z_][A-Za-z0-9_]*)\s*\(")

    with open(GHIDRA_C_PATH, "rb") as f:
        in_func = False
        func_start = 0
        sig_lines = []
        recent_lines = []  # (offset, bytes)

        while True:
            off = f.tell()
            line = f.readline()
            if not line:
                break

            if not in_func:
                if line == b"{\r\n" or line == b"{\n":
                    # Collect header lines above blank line(s)
                    hdr = []
                    start_off = off
                    idx = len(recent_lines) - 1
                    while idx >= 0 and recent_lines[idx][1].strip() == b"":
                        idx -= 1
                    while idx >= 0:
                        roff, rline = recent_lines[idx]
                        rstrip = rline.strip()
                        if rstrip == b"" or rstrip.startswith(b"//") or rstrip.startswith(b"/*") or rstrip.endswith(b";") or rstrip == b"}":
                            break
                        hdr.append(rstrip.decode("utf-8", errors="replace"))
                        start_off = roff
                        idx -= 1
                    hdr.reverse()
                    sig_text = " ".join(hdr)
                    m_id = ident_re.search(sig_text)
                    if m_id:
                        c_name = m_id.group(1)
                        func_start = start_off
                        sig_lines = [sig_text]
                        in_func = True
                    recent_lines.clear()
                else:
                    recent_lines.append((off, line))
                    if len(recent_lines) > 12:
                        recent_lines.pop(0)
            else:
                if line == b"}\r\n" or line == b"}\n" or line == b"}":
                    func_len = f.tell() - func_start
                    c_func_rows.append((c_name, sig_lines[0], func_start, func_len))
                    in_func = False
                    recent_lines.clear()

    cur.executemany(
        "INSERT OR REPLACE INTO c_functions (c_name, signature, byte_offset, byte_length) VALUES (?, ?, ?, ?)",
        c_func_rows,
    )

    print("      -> Building SQLite lookup indexes...")
    cur.executescript(
        """
        CREATE INDEX idx_il2cpp_cs_class ON il2cpp_methods(cs_class);
        CREATE INDEX idx_il2cpp_c_name ON il2cpp_methods(c_name);
        CREATE INDEX idx_dump_type_name ON dump_types(type_name);
        CREATE INDEX idx_dump_full_name ON dump_types(full_name);
        """
    )
    cur.execute("INSERT INTO meta_info VALUES ('built_at', ?)", (str(time.time()),))
    conn.commit()
    conn.close()
    print(f"Done in {time.time() - t0:.1f}s! Indexed {len(c_func_rows):,} Ghidra C functions.")


def annotate_c_code(conn: sqlite3.Connection, code: str, fields_map: dict) -> str:
    cur = conn.cursor()

    # Collect all DAT_xxxxxxxx and FUN_xxxxxxxx addresses in this snippet
    dat_hexes = set(re.findall(r"\bDAT_([0-9a-fA-F]{8})\b", code))
    fun_hexes = set(re.findall(r"\bFUN_([0-9a-fA-F]{8})\b", code))
    all_addrs = {int(h, 16) for h in (dat_hexes | fun_hexes)}

    addr_lookup = {}
    if all_addrs:
        placeholders = ",".join("?" for _ in all_addrs)
        for row in cur.execute(
            f"SELECT addr, kind, label FROM metadata_addrs WHERE addr IN ({placeholders})",
            tuple(all_addrs),
        ):
            addr_lookup[row["addr"]] = f"{row['kind']}: {row['label']}"

    for addr, helper_name in KNOWN_RUNTIME_HELPERS.items():
        addr_lookup.setdefault(addr, helper_name)

    def repl_dat(m: re.Match) -> str:
        addr = int(m.group(1), 16)
        if addr in addr_lookup:
            return f"{m.group(0)} /* {addr_lookup[addr]} */"
        return m.group(0)

    def repl_fun(m: re.Match) -> str:
        addr = int(m.group(1), 16)
        if addr in addr_lookup:
            return f"{m.group(0)} /* {addr_lookup[addr]} */"
        return m.group(0)

    code = re.sub(r"\bDAT_([0-9a-fA-F]{8})\b", repl_dat, code)
    code = re.sub(r"\bFUN_([0-9a-fA-F]{8})\b", repl_fun, code)

    if fields_map:
        def repl_field(m: re.Match) -> str:
            off_key = m.group(1).lower()
            # Normalize e.g. 0x0c -> 0xc
            off_norm = hex(int(off_key, 16))
            if off_norm in fields_map:
                return f"{m.group(0)} /* .{fields_map[off_norm]} */"
            return m.group(0)

        code = re.sub(r"\bparam_1\s*\+\s*(0x[0-9a-fA-F]+)\b", repl_field, code)

    return code


def read_slice(path: str, offset: int, length: int) -> str:
    with open(path, "rb") as f:
        f.seek(offset)
        return f.read(length).decode("utf-8", errors="replace")


def fallback_arm32_summary(conn: sqlite3.Connection, start_va: int, next_va: int) -> str:
    """When Ghidra skipped decompiling a function, extract all ARM32 BL calls and PIC literal loads from libil2cpp.so."""
    import struct

    matches = glob.glob(LIBIL2CPP_GLOB)
    so_path = matches[0] if matches else r"E:\ProjectAO\libil2cpp.so"
    if not os.path.exists(so_path):
        return "// [libil2cpp.so not found for ARM32 fallback]"

    size = max(4, min(next_va - start_va, 0x4000)) if next_va > start_va else 0x800
    with open(so_path, "rb") as f:
        f.seek(start_va)
        data = f.read(size)

    cur = conn.cursor()
    lines = [f"// [ARM32 Binary Fallback from libil2cpp.so: 0x{start_va:08X} .. 0x{start_va + len(data):08X}]"]
    reg_lit = {}  # Rd -> literal value loaded via LDR Rd, [PC, #off]

    n_words = len(data) // 4
    for i in range(n_words):
        pc = start_va + i * 4
        word = struct.unpack_from("<I", data, i * 4)[0]
        cond = (word >> 28) & 0xF
        if cond == 0xF:
            continue

        # Branch / BL: xxxx 101L imm24
        if (word & 0x0E000000) == 0x0A000000:
            is_bl = bool(word & 0x01000000)
            imm24 = word & 0x00FFFFFF
            if imm24 & 0x00800000:
                imm24 -= 0x01000000
            target = (pc + 8 + (imm24 << 2)) & 0xFFFFFFFF
            if is_bl or target < start_va or target >= start_va + len(data):
                row = cur.execute("SELECT kind, label FROM metadata_addrs WHERE addr = ?", (target,)).fetchone()
                label = f"{row['kind']}: {row['label']}" if row else KNOWN_RUNTIME_HELPERS.get(target)
                if label and label not in ("il2cpp_codegen_raise_null_reference", "il2cpp_runtime_class_init", "il2cpp_codegen_initialize_method"):
                    op = "CALL" if is_bl else "TAILCALL"
                    lines.append(f"  0x{pc:08X}: {op} 0x{target:08X} -> {label}")

        # LDR Rd, [PC, #+-imm12]: xxxx 0101 U001 1111 Rd imm12
        elif (word & 0x0F7F0000) == 0x051F0000:
            up = bool(word & 0x00800000)
            rd = (word >> 12) & 0xF
            imm12 = word & 0xFFF
            lit_addr = (pc + 8 + (imm12 if up else -imm12)) - start_va
            if 0 <= lit_addr <= len(data) - 4:
                reg_lit[rd] = struct.unpack_from("<I", data, lit_addr)[0]

        # ADD Rd, PC, Rm  OR  LDR Rd, [PC, Rm]
        elif (word & 0x0FEF0FF0) == 0x008F0000 or (word & 0x0F7F0000) == 0x079F0000:
            rd = (word >> 12) & 0xF
            rm = word & 0xF
            if rm in reg_lit:
                eff_addr = (pc + 8 + reg_lit[rm]) & 0xFFFFFFFF
                row = cur.execute("SELECT kind, label FROM metadata_addrs WHERE addr = ?", (eff_addr,)).fetchone()
                if row and row["kind"] in ("String", "MethodInfo", "TypeInfo"):
                    lines.append(f"  0x{pc:08X}: REF  0x{eff_addr:08X} -> {row['kind']}: {row['label']}")

    return "\n".join(lines)


def cmd_inspect(class_query: str, method_filter: str = None, include_nested: bool = True) -> None:
    if not os.path.exists(DB_PATH):
        print("Index not found. Run `python Tools/ao_decompiler.py build` first.", file=sys.stderr)
        sys.exit(1)

    conn = connect_db()
    cur = conn.cursor()

    if include_nested:
        types = cur.execute(
            """
            SELECT * FROM dump_types
            WHERE full_name = ? OR type_name = ?
               OR full_name LIKE ? OR type_name LIKE ?
            ORDER BY byte_offset
            """,
            (class_query, class_query, f"{class_query}.%", f"{class_query}.%"),
        ).fetchall()
    else:
        types = cur.execute(
            "SELECT * FROM dump_types WHERE full_name = ? OR type_name = ? ORDER BY byte_offset",
            (class_query, class_query),
        ).fetchall()

    if not types:
        print(f"No dump.txt TypeDef exact match for '{class_query}'. Trying partial search:")
        like_types = cur.execute(
            "SELECT full_name FROM dump_types WHERE full_name LIKE ? LIMIT 25",
            (f"%{class_query}%",),
        ).fetchall()
        for r in like_types:
            print("  -", r["full_name"])
        return

    target_full_names = []
    fields_by_class = {}

    if not method_filter:
        print("=" * 80)
        print(f"DUMP.CS DEFINITIONS FOR: {class_query} ({len(types)} type(s))")
        print("=" * 80)

    for t in types:
        fn = t["full_name"]
        target_full_names.append(fn)
        # Also match slash/dot variations in ScriptMethod cs_class
        fields_by_class[fn] = json.loads(t["fields_json"] or "{}")
        fields_by_class[t["type_name"]] = fields_by_class[fn]
        if not method_filter:
            print(read_slice(DUMP_TXT_PATH, t["byte_offset"], t["byte_length"]))

    # Find methods in il2cpp_methods
    method_clauses = []
    params = []
    for t in types:
        for candidate in {t["full_name"], t["type_name"], t["full_name"].replace(".", "/")}:
            method_clauses.append("cs_class = ?")
            params.append(candidate)
            if include_nested:
                method_clauses.append("cs_class LIKE ?")
                params.append(f"{candidate}/%")
                method_clauses.append("cs_class LIKE ?")
                params.append(f"{candidate}.%")

    sql = f"SELECT DISTINCT addr, cs_class, cs_method, c_name, signature FROM il2cpp_methods WHERE ({' OR '.join(method_clauses)})"
    if method_filter:
        sql += " AND (cs_method LIKE ? OR c_name LIKE ?)"
        params.extend([f"%{method_filter}%", f"%{method_filter}%"])
    sql += " ORDER BY id"

    methods = cur.execute(sql, params).fetchall()
    print("=" * 80)
    print(f"GHIDRA DECOMPILED FUNCTIONS ({len(methods)} matched)")
    print("=" * 80)

    for m in methods:
        c_name = m["c_name"]
        fun_fallback = f"FUN_{m['addr']:08x}"
        crow = cur.execute(
            "SELECT * FROM c_functions WHERE c_name = ? OR c_name = ?",
            (c_name, fun_fallback),
        ).fetchone()

        print(f"\n// --- {m['cs_class']} :: {m['cs_method']} (VA: 0x{m['addr']:08X}) ---")
        print(f"// IL2CPP Sig: {m['signature']}")
        if not crow:
            next_row = cur.execute(
                "SELECT MIN(addr) AS next_addr FROM il2cpp_methods WHERE addr > ?",
                (m["addr"],),
            ).fetchone()
            next_va = next_row["next_addr"] if next_row and next_row["next_addr"] else m["addr"] + 0x400
            print(fallback_arm32_summary(conn, m["addr"], next_va))
            continue

        raw_c = read_slice(GHIDRA_C_PATH, crow["byte_offset"], crow["byte_length"])
        fmap = fields_by_class.get(m["cs_class"], {})
        if not fmap and "/" in m["cs_class"]:
            fmap = fields_by_class.get(m["cs_class"].replace("/", "."), {})
        annotated = annotate_c_code(conn, raw_c, fmap)
        print(annotated)

    conn.close()


def cmd_raw(c_func_name: str) -> None:
    conn = connect_db()
    cur = conn.cursor()
    crow = cur.execute("SELECT * FROM c_functions WHERE c_name = ?", (c_func_name,)).fetchone()
    if not crow:
        rows = cur.execute("SELECT c_name FROM c_functions WHERE c_name LIKE ? LIMIT 25", (f"%{c_func_name}%",)).fetchall()
        print(f"Function '{c_func_name}' not found. Similar:")
        for r in rows:
            print("  -", r["c_name"])
        return
    raw_c = read_slice(GHIDRA_C_PATH, crow["byte_offset"], crow["byte_length"])
    print(annotate_c_code(conn, raw_c, {}))
    conn.close()


def cmd_around(c_func_name: str, before: int = 5000, after: int = 2000) -> None:
    conn = connect_db()
    cur = conn.cursor()
    crow = cur.execute("SELECT * FROM c_functions WHERE c_name = ?", (c_func_name,)).fetchone()
    if not crow:
        print(f"Not found: {c_func_name}")
        return
    start = max(0, crow["byte_offset"] - before)
    raw_c = read_slice(GHIDRA_C_PATH, start, before + after)
    print(annotate_c_code(conn, raw_c, {}))
    conn.close()


def cmd_search(keyword: str) -> None:
    conn = connect_db()
    cur = conn.cursor()
    print("=== Matching Types in dump.txt ===")
    for r in cur.execute("SELECT full_name FROM dump_types WHERE full_name LIKE ? LIMIT 40", (f"%{keyword}%",)):
        print(" ", r["full_name"])
    print("\n=== Matching Methods in script.json ===")
    for r in cur.execute(
        "SELECT cs_class, cs_method, c_name FROM il2cpp_methods WHERE cs_class LIKE ? OR cs_method LIKE ? LIMIT 40",
        (f"%{keyword}%", f"%{keyword}%"),
    ):
        print(f"  {r['cs_class']}::{r['cs_method']}  [{r['c_name']}]")
    conn.close()


def cmd_stubs(path_filter: str = "") -> None:
    root = os.path.join(WORKSPACE_ROOT, "Assets", "Scripts", "Assembly-CSharp")
    stub_body_re = re.compile(
        r"\{\s*(?:return\s+(?:null|false|true|0|0f|default\([^)]*\)|[A-Za-z0-9_.]+\.[A-Za-z0-9_]+);\s*)?\}",
        re.MULTILINE,
    )
    total_files = 0
    pure_stub_files = 0
    mixed_files = 0
    filled_files = 0

    matches = []
    for dirpath, _, filenames in os.walk(root):
        for fn in filenames:
            if not fn.endswith(".cs"):
                continue
            full = os.path.join(dirpath, fn)
            rel = os.path.relpath(full, root).replace("\\", "/")
            if path_filter and path_filter.lower() not in rel.lower():
                continue
            total_files += 1
            with open(full, "r", encoding="utf-8", errors="ignore") as f:
                text = f.read()

            # Heuristic: check if file has real statements (assignments, method calls, if/for/switch)
            has_logic = bool(re.search(r"\b(if|switch|for|foreach|while|new\s+[A-Za-z0-9_]+)\s*\(|[A-Za-z0-9_]+\s*\([^)]*\)\s*;", text))
            stubs_count = len(stub_body_re.findall(text))
            if not has_logic and stubs_count > 0:
                pure_stub_files += 1
                matches.append(("STUB", rel, stubs_count))
            elif has_logic and stubs_count > 3:
                mixed_files += 1
                matches.append(("PARTIAL", rel, stubs_count))
            else:
                filled_files += 1

    print(f"Scanned {total_files} C# files (filter='{path_filter}'):")
    print(f"  - Filled / Data / Enum : {filled_files}")
    print(f"  - Partial (mixed)      : {mixed_files}")
    print(f"  - Pure Stubs           : {pure_stub_files}")
    if path_filter:
        for kind, rel, cnt in matches[:60]:
            print(f"  [{kind:7s}] {rel} ({cnt} empty/default blocks)")


def main() -> None:
    sys.stdout.reconfigure(encoding="utf-8", errors="replace")
    parser = argparse.ArgumentParser(description="AO Ghidra + Il2CppDumper Fast Indexer")
    sub = parser.add_subparsers(dest="cmd", required=True)

    sub.add_parser("build", help="Build SQLite index from exportAOJP.c, script.json, and dump.txt")

    p_ins = sub.add_parser("inspect", help="Inspect dump.cs + annotated Ghidra C for a class")
    p_ins.add_argument("class_name")
    p_ins.add_argument("--no-nested", action="store_true")

    p_met = sub.add_parser("method", help="Inspect specific method(s) of a class")
    p_met.add_argument("class_name")
    p_met.add_argument("method_filter")
    p_met.add_argument("--no-nested", action="store_true")

    p_raw = sub.add_parser("raw", help="Print annotated Ghidra C function by exact C name")
    p_raw.add_argument("c_func_name")

    p_aro = sub.add_parser("around", help="Print bytes around a C function")
    p_aro.add_argument("c_func_name")
    p_aro.add_argument("--before", type=int, default=5000)
    p_aro.add_argument("--after", type=int, default=2000)

    p_sea = sub.add_parser("search", help="Search classes and methods")
    p_sea.add_argument("keyword")

    p_stu = sub.add_parser("stubs", help="Scan Assembly-CSharp for remaining stub files")
    p_stu.add_argument("filter", nargs="?", default="")

    args = parser.parse_args()
    if args.cmd == "build":
        build_index()
    elif args.cmd == "inspect":
        cmd_inspect(args.class_name, include_nested=not args.no_nested)
    elif args.cmd == "method":
        cmd_inspect(args.class_name, method_filter=args.method_filter, include_nested=not args.no_nested)
    elif args.cmd == "raw":
        cmd_raw(args.c_func_name)
    elif args.cmd == "around":
        cmd_around(args.c_func_name, args.before, args.after)
    elif args.cmd == "search":
        cmd_search(args.keyword)
    elif args.cmd == "stubs":
        cmd_stubs(args.filter)


if __name__ == "__main__":
    main()
