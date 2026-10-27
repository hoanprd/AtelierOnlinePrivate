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

    public static Dictionary<int, MultiPlay_BattleData> m_battleList = new Dictionary<int, MultiPlay_BattleData>();

    public static Dictionary<int, MultiPlay_CharaData> m_charaList = new Dictionary<int, MultiPlay_CharaData>();

    public static List<MultiPlay_ChatData> m_chatList = new List<MultiPlay_ChatData>();

    public static Dictionary<int, MultiPlay_DungeonData> m_dungeonList = new Dictionary<int, MultiPlay_DungeonData>();

    public static bool m_dungeonCoroutineNow;

    public static List<PhotonView_MultiPlay.DungeonCoroutine> m_coroutineList = new List<PhotonView_MultiPlay.DungeonCoroutine>();

    public static Dictionary<long, MultiPlay_EnemyData> m_enemyList = new Dictionary<long, MultiPlay_EnemyData>();

    public static Dictionary<long, MultiPlay_EnemyData> m_enemyLocalList = new Dictionary<long, MultiPlay_EnemyData>();

    public static Dictionary<int, MultiPlay_FieldEffectData> m_effectList = new Dictionary<int, MultiPlay_FieldEffectData>();

    public static Dictionary<long, MultiPlay_GimmickData> m_gimmickList = new Dictionary<long, MultiPlay_GimmickData>();

    public static bool m_gimmickReserveNow;

    public static List<KeyValuePair<long, int>> m_gimmickReserveList = new List<KeyValuePair<long, int>>();

    public static MultiPlay_RoomData m_roomData;

    public static int m_roomIndex;

    public static List<int> m_assignIdxQue = new List<int>();

    public static bool m_assignIdxNow;

    public static List<KeyValuePair<int, Dictionary<string, object>>> m_joinCharaQue = new List<KeyValuePair<int, Dictionary<string, object>>>();

    public static bool m_joinCharaNow;

    public static List<int> m_leaveCharaQue = new List<int>();

    public static bool m_leaveCharaNow;

    public static List<KeyValuePair<int, int>> m_suspendQueue = new List<KeyValuePair<int, int>>();

    public static bool m_suspendNow;

    public static int m_questId;

    public static Dictionary<int, int>[] m_saveState;

    public static Dictionary<EAbnormalState, Dictionary<int, int>> m_saveAbnormalState = new Dictionary<EAbnormalState, Dictionary<int, int>>();

    public static float m_blazeArtsGauge;

    public static void Init()
    {
        m_playerID = 0;
        m_roomIndex = 0;
        m_questId = 0;
        m_blazeArtsGauge = 0f;

        if (m_battleList == null) m_battleList = new Dictionary<int, MultiPlay_BattleData>();
        else m_battleList.Clear();

        if (m_charaList == null) m_charaList = new Dictionary<int, MultiPlay_CharaData>();
        else m_charaList.Clear();

        if (m_chatList == null) m_chatList = new List<MultiPlay_ChatData>();
        else m_chatList.Clear();

        if (m_dungeonList == null) m_dungeonList = new Dictionary<int, MultiPlay_DungeonData>();
        else m_dungeonList.Clear();

        if (m_enemyList == null) m_enemyList = new Dictionary<long, MultiPlay_EnemyData>();
        else m_enemyList.Clear();

        if (m_enemyLocalList == null) m_enemyLocalList = new Dictionary<long, MultiPlay_EnemyData>();
        else m_enemyLocalList.Clear();

        if (m_effectList == null) m_effectList = new Dictionary<int, MultiPlay_FieldEffectData>();
        else m_effectList.Clear();

        if (m_gimmickList == null) m_gimmickList = new Dictionary<long, MultiPlay_GimmickData>();
        else m_gimmickList.Clear();

        ClearMemberState();
    }

    public static void Clear()
    {
        Init();
        m_roomData = null;

        if (m_coroutineList != null) m_coroutineList.Clear();
        if (m_gimmickReserveList != null) m_gimmickReserveList.Clear();
        if (m_assignIdxQue != null) m_assignIdxQue.Clear();
        if (m_joinCharaQue != null) m_joinCharaQue.Clear();
        if (m_leaveCharaQue != null) m_leaveCharaQue.Clear();
        if (m_suspendQueue != null) m_suspendQueue.Clear();
        if (m_saveAbnormalState != null) m_saveAbnormalState.Clear();

        m_dungeonCoroutineNow = false;
        m_gimmickReserveNow = false;
        m_assignIdxNow = false;
        m_joinCharaNow = false;
        m_leaveCharaNow = false;
        m_suspendNow = false;
    }

    public static int GetMemberState(eMemberSaveState state, int index)
    {
        if (m_saveState != null && index >= 0 && index < m_saveState.Length && m_saveState[index] != null)
        {
            int key = (int)state;
            if (m_saveState[index].ContainsKey(key))
            {
                return m_saveState[index][key];
            }
        }
        return 0;
    }

    public static void SetMemberState(eMemberSaveState state, int index, int value)
    {
        if (m_saveState == null)
        {
            m_saveState = new Dictionary<int, int>[16];
        }
        if (index >= 0)
        {
            if (index >= m_saveState.Length)
            {
                System.Array.Resize(ref m_saveState, index + 4);
            }
            if (m_saveState[index] == null)
            {
                m_saveState[index] = new Dictionary<int, int>();
            }
            m_saveState[index][(int)state] = value;
        }
    }

    public static int GetMemberState(EAbnormalState state, int index)
    {
        if (m_saveAbnormalState != null && m_saveAbnormalState.ContainsKey(state))
        {
            var dict = m_saveAbnormalState[state];
            if (dict != null && dict.ContainsKey(index))
            {
                return dict[index];
            }
        }
        return 0;
    }

    public static void SetMemberState(EAbnormalState state, int index, int value)
    {
        if (m_saveAbnormalState == null)
        {
            m_saveAbnormalState = new Dictionary<EAbnormalState, Dictionary<int, int>>();
        }
        if (!m_saveAbnormalState.ContainsKey(state))
        {
            m_saveAbnormalState[state] = new Dictionary<int, int>();
        }
        m_saveAbnormalState[state][index] = value;
    }

    public static void ClearMemberState()
    {
        if (m_saveState != null)
        {
            for (int i = 0; i < m_saveState.Length; i++)
            {
                if (m_saveState[i] != null)
                {
                    m_saveState[i].Clear();
                }
            }
        }
        if (m_saveAbnormalState != null)
        {
            m_saveAbnormalState.Clear();
        }
    }

    public static MultiPlay_CharaData GetMpCharaData(long userid)
    {
        if (m_charaList != null)
        {
            foreach (var kvp in m_charaList)
            {
                if (kvp.Value != null && kvp.Value.UserID == userid) // Sửa UserId thành UserID
                {
                    return kvp.Value;
                }
            }
        }
        return null;
    }

    public static string GetUserDispName(long userid)
    {
        MultiPlay_CharaData charaData = GetMpCharaData(userid);
        if (charaData != null)
        {
            return charaData.DispName;
        }
        return string.Empty;
    }
}