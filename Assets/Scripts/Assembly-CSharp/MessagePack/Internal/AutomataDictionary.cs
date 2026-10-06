using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;

namespace MessagePack.Internal
{
	public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		private class AutomataNode : IComparable<AutomataNode>
		{
			private static readonly AutomataNode[] emptyNodes;

			private static readonly ulong[] emptyKeys;

			public ulong Key;

			public int Value;

			public string originalKey;

			private AutomataNode[] nexts;

			private ulong[] nextKeys;

			private int count;

			public bool HasChildren
			{
				get
				{
					return false;
				}
			}

			public AutomataNode(ulong key)
			{
			}

			public AutomataNode Add(ulong key)
			{
				return null;
			}

			public AutomataNode Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			public unsafe AutomataNode SearchNext(ref byte* p, ref int rest)
			{
				return null;
			}

			public AutomataNode SearchNextSafe(byte[] p, ref int offset, ref int rest)
			{
				return null;
			}

			internal static int BinarySearch(ulong[] array, int index, int length, ulong value)
			{
				return 0;
			}

			public int CompareTo(AutomataNode other)
			{
				return 0;
			}

			[DebuggerHidden]
			public IEnumerable<AutomataNode> YieldChildren()
			{
				return null;
			}

			public void EmitSearchNext(ILGenerator il, LocalBuilder p, LocalBuilder rest, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound)
			{
			}

			private static void EmitSearchNextCore(ILGenerator il, LocalBuilder p, LocalBuilder rest, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound, AutomataNode[] nexts, int count)
			{
			}
		}

		private readonly AutomataNode root;

		public void Add(string str, int value)
		{
		}

		public bool TryGetValueSafe(ArraySegment<byte> key, out int value)
		{
			value = default(int);
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		private static void ToStringCore(IEnumerable<AutomataNode> nexts, StringBuilder sb, int depth)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<AutomataNode> nexts)
		{
			return null;
		}

		public void EmitMatch(ILGenerator il, LocalBuilder p, LocalBuilder rest, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound)
		{
		}
	}
}
