using System.Collections.Generic;

public class FieldNPCManager
{
	public enum eNPCKind
	{
		Spawner = 0,
		ADV = 1
	}

	private static Dictionary<string, Game_Gimmick_NPCBase> s_scrObjDic;

	private static string GetKey(int iNO, eNPCKind eKind)
	{
		return null;
	}

	public static void Regist(int iNO, eNPCKind eKind, Game_Gimmick_NPCBase scrObj)
	{
	}

	public static void Release(int iNO, eNPCKind eKind)
	{
	}

	public static void Release(string strKey)
	{
	}

	public static Game_Gimmick_NPCBase GetNPC(int iNO, eNPCKind eKind)
	{
		return null;
	}

	public static void KillADVNPC()
	{
	}

	public static void SetActiveAll(bool bActive, eNPCKind eKind)
	{
	}
}
