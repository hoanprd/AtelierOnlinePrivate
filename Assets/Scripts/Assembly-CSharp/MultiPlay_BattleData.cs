using System.Collections.Generic;
using UnityEngine;

public class MultiPlay_BattleData : PhotonView_SyncData
{
	public class InterruptSkill
	{
		public int skillNO;

		public int member;

		public int turn;

		public bool cancel;

		public InterruptSkill(int _member, int _skillNO, int _turn, bool _cancel = false)
		{
		}
	}

	public class InterruptItem
	{
		public int chara;

		public int itemNO;

		public int df;

		public int turn;

		public bool cancel;

		public InterruptItem(int _chara, int _itemNO, int _df, int _turn, bool _cancel = false)
		{
		}
	}

	public struct MultiPlay_BattleActionTurnData
	{
		public MultiPlay_BattleMemberData BattleMember;

		public float ActionWait;
	}

	public bool IsCreatePopup;

	public Dictionary<int, InterruptSkill> InterruptSkillList;

	public Dictionary<int, InterruptItem> InterruptItemList;

	private List<MultiPlay_BattleActionTurnData> m_ActionTurnList;

	private MultiPlay_BattleActionTurnData m_ActionTurnData;

	public bool IsAdventBattle;

	public bool IsAdventBattleStop;

	public bool IsAdventBattleGiveup;

	public int AdventRankingID;

	public int AdventEnemyDF;

	public List<int> AdventSelectMemberList;

	public List<int> StartSkillList;

	public Dictionary<int, int> AdventBattleScoreList;

	private AssetLoader m_abLoader;

	public bool m_isTargetAbnormalStateFlag;

	public bool m_isRecoverUpFlag;

	public bool m_isAttackItemFlag;

	public bool m_isRecoverItemFlag;

	public bool m_isLevelAttackFlag;

	public bool m_isLevelItemAttackFlag;

	public bool m_isLevelDamagedFlag;

	public bool m_isDesignUpFlag;

	public bool m_isTurnPhysicalAttackUpFlag;

	public bool m_isTurnMagicAttackUpFlag;

	public bool m_isChainSkillFlag;

	public bool m_isSkillFlag;

	public BattleStart m_startResponse;

	public BattleJoin m_joinResponse;

	public ResponseDataCommon m_startCommon;

	public Dictionary<int, MultiPlay_BattleCharaData> CharaList;

	public Dictionary<int, MultiPlay_BattleMemberData> MemberList;

	public Dictionary<int, MultiPlay_EnemyMemberData> EnemyMemberList;

	public GameObject SmokeEffect;

	public Sound_Loop SoundEffect;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int BattleLogTurn
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsLocal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public long EnemyID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public int EnemyNO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SkillChainCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SkillCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int InterruptItemNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsStrike
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string BattleLogData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsFinish
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsBoss
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int ContinueLeft
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsEscapeOrJoin
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int LastAttackID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MasterClientID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int StartClientID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsJoined
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool StartSkillFlag
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int Zone
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AdventBattleTurn
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsTimeScale
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MultiPlay_EnemyData EnemyData
	{
		get
		{
			return null;
		}
	}

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_CharaData OwnerCharaData
	{
		get
		{
			return null;
		}
	}

	public bool IsOwner
	{
		get
		{
			return false;
		}
	}

	public bool IsChara
	{
		get
		{
			return false;
		}
	}

	public bool IsNextTurn
	{
		get
		{
			return false;
		}
	}

	public bool IsResultNow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsResult
	{
		get
		{
			return false;
		}
	}

	public bool IsGameOver
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_BattleData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_BattleData(int index)
	{
	}

	public void AdventBattleInit()
	{
	}

	public int AdventBattleCalculate()
	{
		return 0;
	}

	public string AdventBattleScore(AdventBattleScore masterScore)
	{
		return null;
	}

	public string AdventBattleScoreNumStr(AdventBattleScore score)
	{
		return null;
	}

	public string AdventBattleScoreName(int kind)
	{
		return null;
	}

	public void AdventBattleAddTurn()
	{
	}

	public void AdventBattleAddDamage(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int damage)
	{
	}

	public void AdventBattleOneDamage(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int damage)
	{
	}

	public void AdventBattleCritical(MultiPlay_BattleMemberData actionMember, bool isCritical)
	{
	}

	public void AdventBattleWeak(MultiPlay_BattleMemberData actionMember, int eleDef)
	{
	}

	public void AdventBattleUseItem(MultiPlay_BattleMemberData actionMember)
	{
	}

	public void AdventBattleSkillChain(MultiPlay_BattleMemberData actionMember)
	{
	}

	public void AdventBattleAnnihilation()
	{
	}

	public void AdventBattleDeadChara(MultiPlay_BattleMemberData actionMember)
	{
	}

	public void AdventBattleAllSurvival()
	{
	}

	public void AdventBattleSelectChara()
	{
	}

	public void AdventBattleBreak(EBattleScoreKind Score)
	{
	}

	public void AdventBattleSlip(EBattleScoreKind Score, MultiPlay_BattleMemberData targetMember, int damage)
	{
	}

	public void SetEscapeLog(int index, string escapeLog)
	{
	}

	public string GetEscapeLog(int index)
	{
		return null;
	}

	public bool IsLoaded()
	{
		return false;
	}

	public void SetLoaded(int index, bool isLoad)
	{
	}

	public bool GetLoaded(int index)
	{
		return false;
	}

	public void UpdateLoad()
	{
	}

	public bool IsCinemaLoaded()
	{
		return false;
	}

	public void SetManualItemDF(int index, ManualItemInfo[] dfList)
	{
	}

	public List<int> GetManualItemDF(int index)
	{
		return null;
	}

	public void SetItemDF(int index, AIItemInfo[] dfList)
	{
	}

	public List<int> GetItemDF(int index)
	{
		return null;
	}

	public override int GetUpdateCount()
	{
		return 0;
	}

	public override void ClearUpdateSyncData()
	{
	}

	public override bool IsUpdateSyncData()
	{
		return false;
	}

	public override Dictionary<string, object> ToDictionary(bool isUpdate = false)
	{
		return null;
	}

	public override void UpdateFromDictionary(Dictionary<string, object> obj)
	{
	}

	public bool IsUpdateSyncDataCharaList()
	{
		return false;
	}

	public byte GetUpdateCountCharaList()
	{
		return 0;
	}

	public void ClearUpdateSyncDataCharaList()
	{
	}

	public Dictionary<int, string> ToDictionaryCharaList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryCharaList(Dictionary<int, string> obj)
	{
	}

	public bool IsUpdateSyncDataMemberList()
	{
		return false;
	}

	public byte GetUpdateCountMemberList()
	{
		return 0;
	}

	public void ClearUpdateSyncDataMemberList()
	{
	}

	public Dictionary<int, string> ToDictionaryMemberList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryMemberList(Dictionary<int, string> obj)
	{
	}

	public bool IsUpdateSyncDataEnemyMemberList()
	{
		return false;
	}

	public byte GetUpdateCountEnemyMemberList()
	{
		return 0;
	}

	public void ClearUpdateSyncDataEnemyMemberList()
	{
	}

	public Dictionary<int, string> ToDictionaryEnemyMemberList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryEnemyMemberList(Dictionary<int, string> obj)
	{
	}

	public void CountQuestSubjugation()
	{
	}

	public Vector3 GetBattlePosition()
	{
		return default(Vector3);
	}

	public MultiPlay_BattleMemberData GetNextActionMemberData()
	{
		return null;
	}

	public MultiPlay_BattleCharaData GetBattleCharaDataFromID(int id)
	{
		return null;
	}

	public MultiPlay_BattleMemberData GetMemberData(int team, int id, int index)
	{
		return null;
	}

	public MultiPlay_BattleMemberData GetMemberDataFromUniqueID(int id)
	{
		return null;
	}

	public MultiPlay_BattleMemberData GetMemberDataFromBurst()
	{
		return null;
	}

	public MultiPlay_BattleMemberData GetMemberDataFromBoss()
	{
		return null;
	}

	public MultiPlay_BattleMemberData[] GetMemberListFromTeam(MultiPlay_BattleMemberData actionMember)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetMemberHate(List<MultiPlay_BattleMemberData> list)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListSkill(MultiPlay_BattleMemberData actionMember, ActiveSkill skillData, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListItem(MultiPlay_BattleMemberData actionMember, List<ActiveSkill> effectList, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListAttack(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListRecoverHP(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListRecoverSP(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListRecoverState(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area, List<ActiveSkill> effectList, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListBuff(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area, List<ActiveSkill> effectList, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListDebuff(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area, List<ActiveSkill> effectList, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListRevive(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListBuffDelete(MultiPlay_BattleMemberData actionMember, EBattleTargetAreaDefine area, bool decide = false)
	{
		return null;
	}

	public List<MultiPlay_BattleMemberData> GetTargetListGrantPassive(MultiPlay_BattleMemberData actionMember, float effectValue, EBattleTargetAreaDefine area, bool decide = false)
	{
		return null;
	}

	public int GetBattleLogTurn(int playerID)
	{
		return 0;
	}

	public List<MultiPlay_BattleActionTurnData> GetBattleActionTurnMemberList(bool iconUpdate = false)
	{
		return null;
	}
}
