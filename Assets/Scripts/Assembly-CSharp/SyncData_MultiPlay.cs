using System.Collections.Generic;
using UnityEngine;

public class SyncData_MultiPlay : MonoBehaviour
{
	public enum eMemberSaveState
	{
		HP = 0,
		HPMax = 1,
		Skill0 = 2,
		Skill1 = 3,
		EnumMax = 4
	}

	public static int m_playerID;

	public static Dictionary<int, MultiPlay_BattleData> m_battleList;

	public static Dictionary<int, MultiPlay_CharaData> m_charaList;

	public static List<MultiPlay_ChatData> m_chatList;

	public static Dictionary<int, MultiPlay_DungeonData> m_dungeonList;

	public static bool m_dungeonCoroutineNow;

	public static List<PhotonView_MultiPlay.DungeonCoroutine> m_coroutineList;

	public static Dictionary<long, MultiPlay_EnemyData> m_enemyList;

	public static Dictionary<long, MultiPlay_EnemyData> m_enemyLocalList;

	public static Dictionary<int, MultiPlay_FieldEffectData> m_effectList;

	public static Dictionary<long, MultiPlay_GimmickData> m_gimmickList;

	public static bool m_gimmickReserveNow;

	public static List<KeyValuePair<long, int>> m_gimmickReserveList;

	public static MultiPlay_RoomData m_roomData;

	public static int m_roomIndex;

	public static List<int> m_assignIdxQue;

	public static bool m_assignIdxNow;

	public static List<KeyValuePair<int, Dictionary<string, object>>> m_joinCharaQue;

	public static bool m_joinCharaNow;

	public static List<int> m_leaveCharaQue;

	public static bool m_leaveCharaNow;

	public static List<KeyValuePair<int, int>> m_suspendQueue;

	public static bool m_suspendNow;

	public static int m_questId;

	public static Dictionary<int, int>[] m_saveState;

	public static Dictionary<EAbnormalState, Dictionary<int, int>> m_saveAbnormalState;

	public static float m_blazeArtsGauge;

	public static void Init()
	{
	}

	public static void Clear()
	{
	}

	public static int GetMemberState(eMemberSaveState state, int index)
	{
		return 0;
	}

	public static void SetMemberState(eMemberSaveState state, int index, int value)
	{
	}

	public static int GetMemberState(EAbnormalState state, int index)
	{
		return 0;
	}

	public static void SetMemberState(EAbnormalState state, int index, int value)
	{
	}

	public static void ClearMemberState()
	{
	}

	public static MultiPlay_CharaData GetMpCharaData(long userid)
	{
		return null;
	}

	public static string GetUserDispName(long userid)
	{
		return null;
	}
}
