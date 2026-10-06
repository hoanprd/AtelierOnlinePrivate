using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Photon;
using UnityEngine;

public class PhotonView_MultiPlay : Photon.MonoBehaviour
{
	public enum ESyncKind
	{
		Chara = 0,
		Enemy = 1,
		Battle = 2,
		Gimmick = 3,
		Dungeon = 4,
		Effect = 5,
		EnumMax = 6
	}

	public enum eActionKind
	{
		NoAction = 0,
		JoinMember = 1,
		Victory = 2,
		GameOver = 3,
		Escape = 4,
		EscapeGuest = 5,
		NormalAttack = 6,
		SkillAttack = 7,
		Item = 8,
		InterruptItem = 9,
		Incapacitated = 10,
		Adventure = 11
	}

	public class AddEffectState
	{
		public int state;

		public List<MultiPlay_BattleMemberData> memberList;

		public AddEffectState(int _state)
		{
		}

		public void Add(MultiPlay_BattleMemberData _member)
		{
		}
	}

	private enum eDungeonEnterProgress
	{
		FloorRemove = 0,
		ClearField = 1,
		DungeonReady = 2,
		FloorEnter = 3,
		LoadBGM = 4,
		EnumMax = 5
	}

	private enum eDungeonExitProgress
	{
		FloorRemove = 0,
		ClearField = 1,
		DungeonRemove = 2,
		DungeonReady = 3,
		FieldReload = 4,
		LoadBGM = 5,
		CreateField = 6,
		SpawnerList = 7,
		EnumMax = 8
	}

	public class DungeonCoroutine
	{
		public enum eKind
		{
			Init = 0,
			End = 1
		}

		public eKind kind;

		public int charaId;

		public int dungeonId;

		public int floorId;

		public bool fieldDungeon;

		public int areaId;

		public int stageId;

		public int spawnId;

		public DungeonCoroutine(eKind kind, int charaId, int dungeonId, int floorId, int stageId)
		{
		}

		public DungeonCoroutine(eKind kind, int charaId, int dungeonId, int floorId, bool fieldDungeon, int areaId, int stageId, int spawnId)
		{
		}

		public bool IsMatch(eKind kind, int charaId, int dungeonId, int floorId)
		{
			return false;
		}
	}

	public static PhotonView_MultiPlay SharedInstance;

	private bool _isUpdateExqRoom;

	private PhotonView m_photonView;

	private float m_livingCheckWait;

	private Dictionary<int, float> m_livingTimeDic;

	private Dictionary<int, float> m_notCharaTimeDic;

	private const float c_livingCheckTime = 1f;

	public const float c_livingRestTimeMax = 10f;

	private const float c_notCharaWaitMax = 15f;

	private bool m_afterSuspend;

	private string m_counterPrint;

	private byte[] m_syncCounterAry;

	public const byte m_syncCountMax = 10;

	private eTimeKind m_timeKind_Log;

	public bool m_battleEnterSuccess;

	public bool m_battleEnterEnd;

	public bool m_battleJoinSuccess;

	public bool m_battleJoinEnd;

	private bool? CriticalFlag;

	public List<int> m_joinMemberList;

	public List<int> m_passiveSkillMemberList;

	public Dictionary<int, List<ActiveSkill>> m_passiveSkillDic;

	public MultiPlay_BattleMemberData m_actionMemberBefore;

	public bool m_isCoverFlag;

	public bool m_isCritical;

	public bool m_isAbsorbFlag;

	public bool m_isHPRegeneFlag;

	public bool m_isSPRegeneFlag;

	public bool m_isBuffDeleteFlag;

	public List<int> m_isQuickFlagList;

	public List<int> m_isAddStateList;

	private bool m_wakeFlag;

	private int m_reflectDamage;

	private List<bool> m_wakeList;

	private StringBuilder m_battleLog;

	private StringBuilder m_strategyBattleLog;

	private StringBuilder m_effectBattleLog;

	private MultiPlay_BattleData m_battleData;

	private List<AddEffectState> m_stateAddMemberList;

	private List<MultiPlay_BattleMemberData> m_stateVoiceList;

	private int m_charaUpdate;

	private float m_checkPlayerTime;

	private static readonly float sr_checkPlayerTimeMax;

	public static Dictionary<int, PlayerDetailManager.OthersProfile_Photon> s_othersInfo;

	private static readonly float[] m_dEnterProgressPer;

	private static readonly float[] m_dExitProgressPer;

	private float m_dungeonRemoveCheckTime;

	private static readonly float m_dungeonRemoveChackTimeMax;

	private int m_enemyUpdate;

	private static readonly int m_spawnEnmMax;

	private int m_spawnEnmNow;

	private static readonly float m_effectRemoveCheckTimeMax;

	private float m_effectRemoveCheckTime;

	private int m_gimmickUpdate;

	private static readonly int m_spawnGimMax;

	private int m_spawnGimNow;

	private float m_gimmickRemoveCheckTime;

	private static readonly float m_gimmickRemoveChackTimeMax;

	private bool m_isSendJoinLeftSystemMessage;

	private long m_roomID;

	public static PhotonView PhotonView
	{
		get
		{
			return null;
		}
	}

	public static int PlayerID
	{
		get
		{
			return 0;
		}
	}

	public static bool IsEnabled
	{
		get
		{
			return false;
		}
	}

	public static bool IsMultiPlay
	{
		get
		{
			return false;
		}
	}

	public static bool IsMultiMode
	{
		get
		{
			return false;
		}
	}

	public bool isUpdateExqRoom
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Dictionary<int, MultiPlay_AlchemyData> AlchemyList
	{
		get
		{
			return null;
		}
	}

	public static MultiPlay_CharaData CurrentCharaData
	{
		get
		{
			return null;
		}
	}

	public static Dictionary<int, MultiPlay_CharaData> CharaList
	{
		get
		{
			return null;
		}
	}

	public bool IsCharaUpdate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static List<MultiPlay_ChatData> ChatList
	{
		get
		{
			return null;
		}
	}

	public static Dictionary<int, MultiPlay_DungeonData> DungeonList
	{
		get
		{
			return null;
		}
	}

	public static MultiPlay_DungeonData CurrentDungeon
	{
		get
		{
			return null;
		}
	}

	public static bool IsDungeon
	{
		get
		{
			return false;
		}
	}

	public static Dictionary<long, MultiPlay_EnemyData> EnemyList
	{
		get
		{
			return null;
		}
	}

	public static Dictionary<long, MultiPlay_EnemyData> EnemyLocalList
	{
		get
		{
			return null;
		}
	}

	public bool IsEnemyUpdate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Dictionary<int, MultiPlay_FieldEffectData> EffectList
	{
		get
		{
			return null;
		}
	}

	public bool IsGimmickUpdate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Dictionary<int, MultiPlay_QuestData> QuestList
	{
		get
		{
			return null;
		}
	}

	public static MultiPlay_RoomData RoomData
	{
		get
		{
			return null;
		}
	}

	public static bool IsFixedRoomIndex
	{
		get
		{
			return false;
		}
	}

	public static bool IsFixedRoomId
	{
		get
		{
			return false;
		}
	}

	public static int CurrentRoomIndex
	{
		get
		{
			return 0;
		}
	}

	public static long RoomID
	{
		get
		{
			return 0L;
		}
	}

	public static int QuestID
	{
		get
		{
			return 0;
		}
	}

	public bool IsSendJoinLeftSystemMessage
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnPhotonPlayerDisconnected(PhotonPlayer player)
	{
	}

	public static void Send_InformationMessage(string msg)
	{
	}

	[PunRPC]
	public void Receive_InformationMessage(byte[] msgpack)
	{
	}

	public void Send_DayTime(float daytime)
	{
	}

	[PunRPC]
	public void Func_DayTime(byte[] msgpack)
	{
	}

	public void Send_RainTime(float raintime)
	{
	}

	[PunRPC]
	public void Func_RainTime(byte[] msgpack)
	{
	}

	public void Send_SnowTime(float snowtime)
	{
	}

	[PunRPC]
	public void Func_SnowTime(byte[] msgpack)
	{
	}

	public void Send_Living()
	{
	}

	[PunRPC]
	public void Receive_Living(byte[] msgpack)
	{
	}

	public void Send_NotCharaExist()
	{
	}

	[PunRPC]
	public void Receive_NotCharaExist(byte[] msgpack)
	{
	}

	public void Send_ExqRoomInfo(ExqRoom_SendArgParam arg)
	{
	}

	[PunRPC]
	public void Receive_ExqRoomInfo(byte[] msgpack)
	{
	}

	public void Send_ExqBreakup()
	{
	}

	[PunRPC]
	public void Receive_ExqBreakup(byte[] msgpack)
	{
	}

	public void Send_ExqDeparture()
	{
	}

	[PunRPC]
	public void Receive_ExqDeparture(byte[] msgpack)
	{
	}

	public void Send_ExqCancelOrder(int questID)
	{
	}

	[PunRPC]
	public void Receive_ExqCancelOrder(byte[] msgpack)
	{
	}

	public void Send_ExqQuestClear(int inkeyCharaMatchCount)
	{
	}

	[PunRPC]
	public void Receive_ExqQuestClear(byte[] msgpack)
	{
	}

	public void Send_ExqOwnerQuestFailed()
	{
	}

	[PunRPC]
	public void Receive_ExqOwnerQuestFailed(byte[] msgpack)
	{
	}

	public void Send_ExqReturnRoom(string sendRoomName)
	{
	}

	[PunRPC]
	public void Receive_ExqReturnRoom(byte[] msgpack)
	{
	}

	public void Send_ExqOwnerRoomCreate()
	{
	}

	[PunRPC]
	public void Receive_ExqOwnerRoomCreate(byte[] msgpack)
	{
	}

	[DebuggerHidden]
	private IEnumerator StandbyOwnerAction(Action callback)
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Init(FieldData fieldData, bool changeStage, bool isExq = false)
	{
	}

	private void Update()
	{
	}

	private void ArraivalCheck(bool existCharaMA)
	{
	}

	public int GetMostArrivalCharaID()
	{
		return 0;
	}

	private void SyncData()
	{
	}

	private void SyncData(ESyncKind kind)
	{
	}

	private void CountTime()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public bool IsCheckFriendInfo()
	{
		return false;
	}

	public static MultiPlay_AlchemyData GetAlchemyDataFromCharaID(int charaID)
	{
		return null;
	}

	public static void StartAlchemy(int charaID, int keyword1, int keyword2, int keyword3)
	{
	}

	public static void StartAlchemyMaterialSelect(int ownerID, int index, int charaID)
	{
	}

	public static void Send_AlchemyData(int key, Dictionary<string, object> obj, bool bNew = false)
	{
	}

	[PunRPC]
	public void Receive_AlchemyData(byte[] msgpack)
	{
	}

	[PunRPC]
	public void Receive_AlchemyData_Update(byte[] msgpack)
	{
	}

	public static void Send_AlchemyMaterialSelectStart(int key, int index, int charaID)
	{
	}

	[PunRPC]
	public void Receive_AlchemyMaterialSelectStart(byte[] msgpack)
	{
	}

	private void UpdateAlchemy()
	{
	}

	private void SyncAlchemyData()
	{
	}

	public MultiPlay_BattleData GetBattleData(int battleID)
	{
		return null;
	}

	public static void Send_BattleData(int key, Dictionary<string, object> obj, bool bNew = false, int targetId = -1)
	{
	}

	[PunRPC]
	public void Receive_BattleData(byte[] msgpack)
	{
	}

	[PunRPC]
	public void Receive_BattleData_Update(byte[] msgpack)
	{
	}

	public static void Send_BattleEncount(MultiPlay_CharaData chara, MultiPlay_EnemyData enemy)
	{
	}

	[PunRPC]
	public void Receive_BattleEncount(byte[] msgpack)
	{
	}

	public void BattleEncountLocal(MultiPlay_CharaData chara, MultiPlay_EnemyData enemy, bool localFlag = true)
	{
	}

	[DebuggerHidden]
	public IEnumerator BattleEncountLocal(int enemyId, int enemyNo, bool isStrike, bool isBoss, bool localFlag = true)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Send_BattleEncountLocal(MultiPlay_CharaData chara, long enemyId, int enemyNo, bool isStrike, bool localFlag = true)
	{
		return null;
	}

	public static void Send_BattleTurn(MultiPlay_BattleData data, MultiPlay_CharaData chara, int turn)
	{
	}

	[PunRPC]
	public void Func_BattleTurn(byte[] msgpack)
	{
	}

	public static void Send_BattleStrategy(MultiPlay_CharaData data, int strategy, bool isReset)
	{
	}

	[PunRPC]
	public void Func_BattleStrategy(byte[] msgpack)
	{
	}

	public static void Send_BattleInterruptSkill(MultiPlay_BattleMemberData data, int skillListID)
	{
	}

	[PunRPC]
	public void Func_BattleInterruptSkill(byte[] msgpack)
	{
	}

	public static void Send_BattleInterruptSkillCancel(MultiPlay_BattleMemberData data)
	{
	}

	[PunRPC]
	public void Func_BattleInterruptSkillCancel(byte[] msgpack)
	{
	}

	public static void Send_BattleInterruptItem(MultiPlay_BattleCharaData data, int itemListID, int df)
	{
	}

	[PunRPC]
	public void Func_BattleInterruptItem(byte[] msgpack)
	{
	}

	public static void Send_BattleInterruptItemCancel(MultiPlay_BattleCharaData data)
	{
	}

	[PunRPC]
	public void Func_BattleInterruptItemCancel(byte[] msgpack)
	{
	}

	public static void Send_BattleUseItem(int charaID, long itemID)
	{
	}

	[PunRPC]
	public void Func_BattleUseItem(byte[] msgpack)
	{
	}

	public static void Send_BattleStartSkill(int index, int skillID)
	{
	}

	[PunRPC]
	public void Func_BattleStartSkill(byte[] msgpack)
	{
	}

	public static void Send_ZoneChange(int index, int zoneID)
	{
	}

	[PunRPC]
	public void Func_ZoneChange(byte[] msgpack)
	{
	}

	public static void Send_BattleTurnCountUpdate(int id, int count)
	{
	}

	[PunRPC]
	public void Func_BattleTurnCountUpdate(byte[] msgpack)
	{
	}

	public static void Send_BattleEscapeRemove(int charaID, int uniqueID)
	{
	}

	[PunRPC]
	public void Func_BattleEscapeRemove(byte[] msgpack)
	{
	}

	public static void Send_ExtraQuestRetire(int charaID, bool isHost, int df = 0)
	{
	}

	[PunRPC]
	public void Func_ExtraQuestContinue(byte[] msgpack)
	{
	}

	public static void Send_BattleContinue(int charaID, bool cont, int df = 0)
	{
	}

	[PunRPC]
	public void Func_BattleContinue(byte[] msgpack)
	{
	}

	public static void Send_ExtraWithdrawalJoin(int charaID, bool isHost)
	{
	}

	[PunRPC]
	public void Func_ExtraWithdrawalJoin(byte[] msgpack)
	{
	}

	public static void Send_BattleContinueJoin(int charaID)
	{
	}

	[PunRPC]
	public void Func_BattleContinueJoin(byte[] msgpack)
	{
	}

	public MultiPlay_BattleData GetBattleDataFromCharaIDContinue(int charaID)
	{
		return null;
	}

	public MultiPlay_BattleData GetBattleDataFromCharaIDContinueDecide(int charaID)
	{
		return null;
	}

	public MultiPlay_BattleData GetBattleDataFromCharaID(int charaID, bool checkResult = false)
	{
		return null;
	}

	public MultiPlay_BattleData GetBattleDataFromChara(MultiPlay_CharaData chara)
	{
		return null;
	}

	public MultiPlay_BattleData GetBattleDataFromEnemyID(long enemyID, bool isLocal = false, bool checkResult = false)
	{
		return null;
	}

	public static void Send_BattleJoin(MultiPlay_CharaData chara1, MultiPlay_CharaData chara2)
	{
	}

	[PunRPC]
	public void Receive_BattleJoin(byte[] msgpack)
	{
	}

	public static void SetPokaPokaVolume(bool enable)
	{
	}

	private void UpdateBattle()
	{
	}

	private List<int> DebugSkillList()
	{
		return null;
	}

	public int DamageCalculateNormalAttack(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, bool isCritical, bool isCover = false)
	{
		return 0;
	}

	public int DamageCalculateSkill(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, ActiveSkill skill)
	{
		return 0;
	}

	public int DamageCalculateItem(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, List<ActiveSkill> item, int category, bool wdraw = false)
	{
		return 0;
	}

	public int GetElementAdj(MultiPlay_BattleMemberData actionMember, int elementID)
	{
		return 0;
	}

	public int EndureJudge(MultiPlay_BattleMemberData targetMember, int damage)
	{
		return 0;
	}

	public bool InvalidJudge(MultiPlay_BattleMemberData targetMember, bool isPhysics)
	{
		return false;
	}

	public float GetStateRate(EAbnormalStateTarget target, MultiPlay_BattleMemberData member)
	{
		return 0f;
	}

	public int GetStateAdd(EAbnormalStateTarget target, List<AbnormalState> list)
	{
		return 0;
	}

	public int AttackElement(MultiPlay_BattleMemberData actionMember, List<ActiveSkill> item = null)
	{
		return 0;
	}

	public void AttackPassiveSkillStatus(MultiPlay_BattleMemberData actionMember)
	{
	}

	public float AttackPassiveSkill(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int elementID, bool isCritical, bool isSkill, bool recovery)
	{
		return 0f;
	}

	public bool AttackPassiveSkillCheck(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int elementID, bool isCritical, bool isSkill, ActiveSkillBase skill)
	{
		return false;
	}

	public float RecoverPassiveSkill(MultiPlay_BattleMemberData actionMember)
	{
		return 0f;
	}

	public bool AttackPassiveSkillRecoverCheck(MultiPlay_BattleMemberData actionMember, ActiveSkillBase skill)
	{
		return false;
	}

	public float AttackPassiveSkillBase(MultiPlay_BattleMemberData actionMember, List<ActiveSkill> item)
	{
		return 0f;
	}

	public float AttackPassiveSkill(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int elementID, List<ActiveSkill> item, int category, bool wdraw)
	{
		return 0f;
	}

	public bool AttackPassiveSkillItemCheck(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int category, ActiveSkillBase skill)
	{
		return false;
	}

	public bool AttackPassiveSkillCheck(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int category, ActiveSkillBase skill, bool isWdraw)
	{
		return false;
	}

	public float AttackPassiveSkillShare(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int elementID, List<ActiveSkill> item, float rate, bool isSkill, bool recovery)
	{
		return 0f;
	}

	public bool AttackPassiveSkillShareCheck(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, bool isSkill, ActiveSkillBase skill)
	{
		return false;
	}

	public float DefensePassiveSkill(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int elementID, EBattleAttribute attribute, bool isCover, bool isItem = false)
	{
		return 0f;
	}

	public float DefensePassiveSkillCheck(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int elementID, EBattleAttribute attribute, float rate, bool isCover, bool isItem, ActiveSkillBase skill)
	{
		return 0f;
	}

	private int GetBattleUpdateCount()
	{
		return 0;
	}

	private void SyncBattleData()
	{
	}

	public StringBuilder GetBattleLog(MultiPlay_BattleData battleData)
	{
		return null;
	}

	public StringBuilder GetBattleLogInterruptSkill(MultiPlay_BattleData battleData)
	{
		return null;
	}

	public StringBuilder GetBattleLogInterruptItem(MultiPlay_BattleData battleData)
	{
		return null;
	}

	private void StrategyUpdate()
	{
	}

	private void EffectCinemaFirstHalf(MultiPlay_BattleMemberData actionMember)
	{
	}

	private void EffectCinemaSecondHalf(MultiPlay_BattleMemberData actionMember)
	{
	}

	private ActiveSkill ParentCharaSkill(MultiPlay_BattleMemberData member, ActiveSkill skill)
	{
		return null;
	}

	private void NormalAttackLog(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember = null)
	{
	}

	private void NormalAttackResultLog(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int index, bool isPursuit = false)
	{
	}

	private void ReactLog(MultiPlay_BattleMemberData member, ActiveSkill skill)
	{
	}

	private bool CheckSkillActivateWhenDamaged(ActiveSkill skill, MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int elementID, EBattleAttribute attribute, bool isCover = false)
	{
		return false;
	}

	private void ReflectLog(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int damage, int elementID, EBattleAttribute attribute, bool isCover = false)
	{
	}

	private void CounterLog(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, MultiPlay_BattleMemberData[] targetList)
	{
	}

	private void RegeneLog(MultiPlay_BattleMemberData actionMember)
	{
	}

	private void AutoActiveSkill(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, int damage, int elementID, EBattleAttribute attribute, bool isCover = false)
	{
	}

	private bool CriticalCheack(MultiPlay_BattleMemberData member)
	{
		return false;
	}

	private void setSP(MultiPlay_BattleMemberData member, bool isAttack)
	{
	}

	public float ParamChange(MultiPlay_BattleMemberData member, EBattleEffectKind kind, EBattleEffectTarget target)
	{
		return 0f;
	}

	public bool ParamChangeCheck(MultiPlay_BattleMemberData member, ActiveSkill skill, EBattleEffectKind kind, EBattleEffectTarget target = EBattleEffectTarget.eNONE)
	{
		return false;
	}

	private bool BattleLog_JoinMember()
	{
		return false;
	}

	private bool BattleLog_ADV_1()
	{
		return false;
	}

	private bool BattleLog_ADV(MultiPlay_BattleMemberData actionMember)
	{
		return false;
	}

	private bool BattleLog_Result(bool end = false)
	{
		return false;
	}

	public void BattleLog_AdventResult(bool isVictory = true)
	{
	}

	private bool BattleLog_GameOver()
	{
		return false;
	}

	private bool BattleLog_Escape()
	{
		return false;
	}

	private bool BattleLog_StartSkill()
	{
		return false;
	}

	private bool NormalAttack(MultiPlay_BattleMemberData actionMember)
	{
		return false;
	}

	private int ElementRecoveryCheack(MultiPlay_BattleMemberData actionMember, ActiveSkill skill, int damage, ActiveSkill activeSkill = null)
	{
		return 0;
	}

	private void AbnormalStateLog(MultiPlay_BattleMemberData actionMember, MultiPlay_BattleMemberData targetMember, ActiveSkill skill, bool isPursmit)
	{
	}

	private bool InterruptSkillAttack(MultiPlay_BattleMemberData actionMember)
	{
		return false;
	}

	private bool SkillAttack(MultiPlay_BattleMemberData actionMember)
	{
		return false;
	}

	private void SkillAttackLog(MultiPlay_BattleMemberData actionMember, ActiveSkill skillData, int num, bool isReserve = false)
	{
	}

	private bool InterruptItemUse(MultiPlay_BattleMemberData actionMember)
	{
		return false;
	}

	private bool ItemUse(MultiPlay_BattleMemberData actionMember)
	{
		return false;
	}

	private void ItemUseLog(MultiPlay_BattleMemberData actionMember, MultiPlay_InventoryInfo useItem, bool interrupt, bool wdraw, bool shinshiki)
	{
	}

	private void CheckPassiveSkillWhenHpRecover(List<MultiPlay_BattleMemberData> memberList)
	{
	}

	private void AddActionMember(int idx, MultiPlay_BattleMemberData member)
	{
	}

	private void AddTargetMember(int idx, MultiPlay_BattleMemberData member, int damage = 0, bool isCritical = false)
	{
	}

	private void AddCoverMember(int idx, MultiPlay_BattleMemberData member, int damage = 0, bool isCritical = false)
	{
	}

	private void AddResultDamage(int idx, int damage, int result = 0, int hpabsorb = 0)
	{
	}

	private void AddResultRevive(int idx, bool revive)
	{
	}

	private void StartTurn(MultiPlay_BattleMemberData actionMember)
	{
	}

	private void EndTurn(MultiPlay_BattleMemberData actionMember)
	{
	}

	private void SleepUpdate(MultiPlay_BattleMemberData member)
	{
	}

	private void StateUpdateAdd()
	{
	}

	private void StateUpdate(MultiPlay_BattleMemberData member)
	{
	}

	public void StateAddMemberRegister(int state, MultiPlay_BattleMemberData member)
	{
	}

	private void plusState(int state, MultiPlay_BattleMemberData member)
	{
	}

	public StringBuilder GetBattleLogEnemySkillDebug(MultiPlay_BattleData battleData, int index)
	{
		return null;
	}

	private void ReduceHP(MultiPlay_BattleMemberData target, int damage)
	{
	}

	public static MultiPlay_CharaData GetCharaDataFromID(int id)
	{
		return null;
	}

	public static MultiPlay_CharaData GetCharaDataFromUserID(long id)
	{
		return null;
	}

	public static PhotonPlayer GetCharaDataFromRoomIndex(int roomIndex)
	{
		return null;
	}

	private static void CheckExistDungeonFloor(int dungeonId, int floor, out List<MultiPlay_CharaData> dungeonMateList, out bool existFloor)
	{
		dungeonMateList = null;
		existFloor = default(bool);
	}

	public int GetRoomPlayerNum()
	{
		return 0;
	}

	private MultiPlay_CharaData GetNearCharaData(Vector3 pos)
	{
		return null;
	}

	public static void UpdateFieldName()
	{
	}

	public static void Send_CharaData(int key, Dictionary<string, object> obj, int targetId = -1)
	{
	}

	[PunRPC]
	public void Receive_CharaData(byte[] msgpack)
	{
	}

	public static void ChangeLeader(int charaID, int leaderDF, bool isUpdateMemberData = false)
	{
	}

	public static void Send_CharaWarpFlag(int charaID, bool flag)
	{
	}

	[PunRPC]
	public void Receive_CharaWarpFlag(byte[] msgpack)
	{
	}

	public static void Send_CharaWarpSwitch(int charaID, bool sw)
	{
	}

	[PunRPC]
	public void Receive_CharaWarpSwitch(byte[] msgpack)
	{
	}

	public static void Send_CharaDungeonReady(int charaID, bool ready)
	{
	}

	[PunRPC]
	public void Receive_CharaDungeonReady(byte[] msgpack)
	{
	}

	public static void Send_CharaItemUse(int charaID, float[] healHpRate, int[] healState, int useType, int range, bool others)
	{
	}

	[PunRPC]
	public void Receive_CharaItemUse(byte[] msgpack)
	{
	}

	public void MemberHeal(MultiPlay_CharaData chara, float[] HPRateList, int[] stateList, int useType, int range)
	{
	}

	public static void Send_UpdateAbnormalState(int charaID)
	{
	}

	[PunRPC]
	public void Receive_UpdateAbnormalState(byte[] msgpack)
	{
	}

	public static void Send_CharaAnimation()
	{
	}

	[PunRPC]
	private void Receive_CharaAnimation(byte[] msgpack)
	{
	}

	public static void Send_RequestProfile(int charaID, int requesterCharaID)
	{
	}

	[PunRPC]
	public void Receive_RequestProfile(byte[] msgpack)
	{
	}

	public static void Send_MyProfile(int charaID, int targetCharaID, PartyMember leader)
	{
	}

	[PunRPC]
	public void Receive_MyProfile(byte[] msgpack)
	{
	}

	public static bool IsSameAreaChara(MultiPlay_CharaData charaData)
	{
		return false;
	}

	public static bool IsSameArea(int dungeonID, int dungeonFloor)
	{
		return false;
	}

	public static bool IsSameDate(int date)
	{
		return false;
	}

	private void UpdateChara()
	{
	}

	private void CharaRemoveCheck()
	{
	}

	private void CheckPlayer()
	{
	}

	private int GetCharaUpdateCount()
	{
		return 0;
	}

	private void SyncCharaData()
	{
	}

	[DebuggerHidden]
	public IEnumerator Event_BattleEncount(MultiPlay_BattleData battleData)
	{
		return null;
	}

	private void UpdateRckList(MultiPlay_BattleData battleData, MultiPlay_CharaData chara, InventoryList INV, AIItemInfo[] PT_AI, ManualItemInfo[] PT_ITEM)
	{
	}

	public static void Send_ChatData(int type, string text, int situation = 0)
	{
	}

	[PunRPC]
	public void Func_ChatData(byte[] msgpack)
	{
	}

	public static void DungeonEnter(int dungeonID, int floor = 1)
	{
	}

	public static void DungeonEnter(int areaId, int stageId, int spawnId, int dungeonID, int floor)
	{
	}

	public static void DungeonAddFloor(int add = 1)
	{
	}

	public static void GoDungeonFloor(int floor)
	{
	}

	public static void ExitDungeon(int areaId, int stageId, int spawnId, bool multi, bool storeMulti = true)
	{
	}

	public static void ExitExDungeon(int areaId, int stageId, Vector3 spawnPos, float spawnRotY, bool multi, bool storeMulti = true)
	{
	}

	public static void Send_DungeonData(int key, Dictionary<string, object> obj, int targetId = -1)
	{
	}

	[PunRPC]
	public void Receive_DungeonData(byte[] msgpack)
	{
	}

	public void Send_RequestDungeonData(int key, int playerId)
	{
	}

	[PunRPC]
	public void Receive_RequestDungeonData(byte[] msgpack)
	{
	}

	public void Send_PerfectDungeonData(int key, int playerId, Dictionary<string, object> obj)
	{
	}

	[PunRPC]
	public void Receive_PerfectDungeonData(byte[] msgpack)
	{
	}

	private float GetLoadProgress(eDungeonEnterProgress kind, float insideProgress)
	{
		return 0f;
	}

	private float GetLoadProgress(eDungeonExitProgress kind, float insideProgress)
	{
		return 0f;
	}

	private float GetLoadProgress(float prevProgressMax, float nowProgressMax, float insideProgress)
	{
		return 0f;
	}

	[DebuggerHidden]
	private IEnumerator Event_DungeonExit(MultiPlay_CharaData charaData, int areaID, int stageID, int spawnID, bool multi, bool storeMulti)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Event_ExDungeonExit(MultiPlay_CharaData charaData, int areaID, int stageID, Vector3 spawnPos, float spawnRotY, bool multi, bool storeMulti)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Event_DungeonEnter(MultiPlay_CharaData charaData, int dungeonID = 1, int dungeonFloor = 1)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Event_FieldDungeonEnter(MultiPlay_CharaData charaData, int areaID, int stageID, int spawnId, int dungeonID, int dungeonFloor)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator DungeonEnterReady(MultiPlay_CharaData charaData, int dungeonID, int dungeonFloor, bool fieldDungeon, int areaId, int stageId, int spawnId, bool isParts)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator DungeonEnterReady2(MultiPlay_CharaData charaData, GameObject spawnerRoot, bool fieldDungeon, int areaId, int stageId, int dungeonId, int dungeonFloor, int date, bool isParts)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator DungeonFloorRemoveAPI(int oldDungeonID, int oldDungeonFloor, int charaId)
	{
		return null;
	}

	public void UpdateDungeonSyncData_OnRemoveFloor(int charaId, int oldDungeonID, int oldDungeonFloor)
	{
	}

	[DebuggerHidden]
	private IEnumerator DungeonFloorEnterAPI(int dungeonID, int dungeonFloor, int date, int charaId)
	{
		return null;
	}

	private void InitSunlightFilter2PartsDungeon(int df)
	{
	}

	private void InitSunlightFilter2Dungeon(int df, int floor)
	{
	}

	private void SetFieldMusic(bool enable, int id = 0, bool dungeon = true, bool parts = false)
	{
	}

	private static void Send_Dungeon(int charaID, int dungeonID, int dungeonFloor, bool fieldDungeon, int areaId, int stageId, int spawnId)
	{
	}

	[PunRPC]
	public void Receive_Dungeon(byte[] msgpack)
	{
	}

	[DebuggerHidden]
	private IEnumerator DungeonInit(int charaID, int dungeonID, int dungeonFloor, bool fieldDungeon, int areaId = 0, int stageId = 0, int spawnId = 0)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator APIDungeonCreate(MultiPlay_CharaData charaData, int dungeonID)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator CreateFieldDungeon(MultiPlay_CharaData charaData, int areaId, int stageId, int spawnId)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator CreateDungeon(MultiPlay_CharaData charaData, MultiPlay_DungeonData dungeonData, int dungeonID, int dungeonFloor, int dungeonSeed, bool existFloor)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator APIDungeonFloorCreate(MultiPlay_CharaData charaData, int dungeonID, int dungeonFloor)
	{
		return null;
	}

	private static void Send_DungeonExit(int charaID, int dungeonID, int dungeonFloor, int stageID)
	{
	}

	[PunRPC]
	public void Receive_DungeonExit(byte[] msgpack)
	{
	}

	[DebuggerHidden]
	private IEnumerator DungeonEnd(int charaID, int dungeonID, int dungeonFloor, int stageID)
	{
		return null;
	}

	private void Send_CoroutineStart(int kind, int charaId, int dungeonId, int floorId)
	{
	}

	[PunRPC]
	private void Receive_CoroutineStart(byte[] msgpack)
	{
	}

	private void Send_CoroutineEnd(int kind, int charaId, int dungeonId, int floorId)
	{
	}

	[PunRPC]
	private void Receive_CoroutineEnd(byte[] msgpack)
	{
	}

	private void UpdateDungeon()
	{
	}

	private void DungeonRemoveCheck()
	{
	}

	private void DungeonCoroutineProc()
	{
	}

	private int GetDungeonUpdateCount()
	{
		return 0;
	}

	private void SyncDungeonData()
	{
	}

	public static MultiPlay_EnemyData GetEnemy(int no, int dungeonId, int floorId, int date, bool local)
	{
		return null;
	}

	public static MultiPlay_EnemyData GetEnemyDataFromID(long id)
	{
		return null;
	}

	public static void CrearEnemyList()
	{
	}

	public static void EnemyInfoUpdate()
	{
	}

	public static void Send_EnemyData(long key, Dictionary<string, object> obj, int targetId = -1)
	{
	}

	[PunRPC]
	public void Receive_EnemyData(byte[] msgpack)
	{
	}

	public static void Send_EnemyCheck(long enemyId)
	{
	}

	[PunRPC]
	public void Receive_EnemyCheck(byte[] msgpack)
	{
	}

	private MultiPlay_EnemyData GetNearEnemyData(Vector3 pos)
	{
		return null;
	}

	public void SetEnemySpot(EnemySpot[] list, bool onlyMaster, int dungeonID, int floorId, int date)
	{
	}

	public void RemoveLocalEnemy(EnemySpot[] enemySpot)
	{
	}

	public static void KillOnlyOnlineEnemy()
	{
	}

	private void UpdateEnemy()
	{
	}

	private void UpdateEnemyLocal()
	{
	}

	private int GetEnemyUpdateCount()
	{
		return 0;
	}

	private void SyncEnemyData()
	{
	}

	public static void Send_EffectData(int key, Dictionary<string, object> obj, int targetId = -1)
	{
	}

	[PunRPC]
	public void Receive_EffectData(byte[] msgpack)
	{
	}

	public void Send_RequestEffectData(int key, int playerId)
	{
	}

	[PunRPC]
	public void Receive_RequestEffectData(byte[] msgpack)
	{
	}

	public void Send_PerfectEffectData(int key, int playerId, Dictionary<string, object> obj)
	{
	}

	[PunRPC]
	public void Receive_PerfectEffectData(byte[] msgpack)
	{
	}

	public static void Send_CreateCharaEffect(int charaID, int effectId, Vector3 localOffset, int soundId = -1)
	{
	}

	[PunRPC]
	public void Receive_CreateCharaEffect(byte[] msgpack)
	{
	}

	public static void Send_RemoveCharaEffect(int charaID, int effectId, eSoundID sound = eSoundID.None)
	{
	}

	[PunRPC]
	public void Receive_RemoveCharaEffect(byte[] msgpack)
	{
	}

	private void UpdateEffect()
	{
	}

	private void CheckRemoveEffect()
	{
	}

	private int GetEffectUpdateCount()
	{
		return 0;
	}

	private void SyncEffectData()
	{
	}

	public void Send_GimmickData(long key, Dictionary<string, object> obj, int targetId = -1)
	{
	}

	[PunRPC]
	public void Func_GimmickData(byte[] msgpack)
	{
	}

	public void Send_RequestGimmickData(long key, int playerId)
	{
	}

	[PunRPC]
	public void Receive_RequestGimmickData(byte[] msgpack)
	{
	}

	public void Send_PerfectGimmickData(long key, int playerId, Dictionary<string, object> obj)
	{
	}

	[PunRPC]
	public void Receive_PerfectGimmickData(byte[] msgpack)
	{
	}

	public static void Send_GimmickExec(int charaID, MultiPlay_GimmickData data)
	{
	}

	[PunRPC]
	public void Func_GimmickExec(byte[] msgpack)
	{
	}

	public void SetGimmickSpot(GimmickSpot[] list, bool onlyMaster, int dungeonID, int floorId, int date, bool remake)
	{
	}

	private bool IsSameAreaGimmick(MultiPlay_GimmickData gimmickData)
	{
		return false;
	}

	public static void Send_GimmickReserveListAdd(MultiPlay_GimmickData data, int charaID)
	{
	}

	[PunRPC]
	public void Func_GimmickReserveListAdd(byte[] msgpack)
	{
	}

	public static void Send_GimmickReserveListRemove(long gimmickID, int charaID)
	{
	}

	[PunRPC]
	public void Func_GimmickReserveListRemove(byte[] msgpack)
	{
	}

	private void UpdateGimmick()
	{
	}

	private void GimmickReserveProc()
	{
	}

	private void GimmickRemoveCheck()
	{
	}

	private int GetGimmickUpdateCount()
	{
		return 0;
	}

	private void SyncGimmickData()
	{
	}

	[PunRPC]
	public void Receive_EnemyIDTable(long key, Dictionary<string, object> obj)
	{
	}

	[PunRPC]
	public void Receive_GimmickIDTable(long key, Dictionary<string, object> obj)
	{
	}

	public static MultiPlay_QuestData GetQuestDataFromDF(int df)
	{
		return null;
	}

	public static MultiPlay_QuestData AddQuest(int df)
	{
		return null;
	}

	public static void QuestOrder(int df, int charaID)
	{
	}

	public static void QuestDelivery(int df, int charaID, int count)
	{
	}

	public static void QuestSubjugation(int df, List<int> charaIDList, int count)
	{
	}

	public static void Send_QuestData(int key, Dictionary<string, object> obj, bool bNew = false)
	{
	}

	[PunRPC]
	public void Receive_QuestData(byte[] msgpack)
	{
	}

	[PunRPC]
	public void Receive_QuestData_Update(byte[] msgpack)
	{
	}

	public static void Send_QuestOrder(int df, int charaID)
	{
	}

	[PunRPC]
	public void Receive_QuestOrder(byte[] msgpack)
	{
	}

	private void UpdateQuest()
	{
	}

	private void SyncQuestData()
	{
	}

	public static bool IsFixedPlayerRoomIndex(int playerId)
	{
		return false;
	}

	public int SearchFreeRoomIndex()
	{
		return 0;
	}

	public void SetRoomInfoLocal()
	{
	}

	public static void Send_SetRoomIndex()
	{
	}

	[PunRPC]
	public void Receive_SetRoomIndex(byte[] msgpack)
	{
	}

	private void Send_FinishRoomIndex(int playerId)
	{
	}

	[PunRPC]
	public void Receive_FinishRoomIndex(byte[] msgpack)
	{
	}

	public void Send_JoinRoom(int key, Dictionary<string, object> obj)
	{
	}

	[PunRPC]
	public void Receive_JoinRoom(byte[] msgpack)
	{
	}

	private void UpdateUserIdList()
	{
	}

	private void SetRoomIndexHash(int playerId, int roomIndex)
	{
	}

	private void RemoveRoomIndexHash(int playerId)
	{
	}

	private void Send_FinishJoinRoom(int key)
	{
	}

	[PunRPC]
	public void Receive_FinishJoinRoom(byte[] msgpack)
	{
	}

	private void Send_LeaveRoom(int playerId)
	{
	}

	[PunRPC]
	public void Receive_LeaveRoom(byte[] msgpack)
	{
	}

	private void Send_FinishLeaveRoom(int playerId)
	{
	}

	[PunRPC]
	public void Receive_FinishLeaveRoom(byte[] msgpack)
	{
	}

	public void Send_SuspendRequest(int sendCharaId, int suspendCharaId)
	{
	}

	public void Receive_SuspendRequest(int sendCharaId, int suspendCharaId)
	{
	}

	private void Send_FinishSuspend(int sendCharaId, int suspendCharaId)
	{
	}

	public void Receive_FinishSuspend(int sendCharaId, int suspendCharaId)
	{
	}

	public static void Send_RoomData(Dictionary<string, object> obj)
	{
	}

	[PunRPC]
	public void Receive_RoomData(byte[] msgpack)
	{
	}

	public void Send_All(int targetId)
	{
	}

	private void Send_Time()
	{
	}

	public void Send_ExistKey(int targetCharaId)
	{
	}

	private void UpdateRoom()
	{
	}

	private void UpdateRoomQueue()
	{
	}

	private void RoomIndexProc()
	{
	}

	private void JoinRoomCharaProc()
	{
	}

	private void LeaveRoomCharaProc()
	{
	}

	private void SuspendCharaProc()
	{
	}

	private int GetRoomUpdateCount()
	{
		return 0;
	}

	private void SyncRoomData()
	{
	}
}
