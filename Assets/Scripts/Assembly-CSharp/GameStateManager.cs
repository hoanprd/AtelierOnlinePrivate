using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
	private class MiniRankingI
	{
		public int m_df;

		public string m_name;

		public int m_type;

		public DateTime m_clsStartTime;

		public DateTime m_clsEndTime;

		public int m_wealth_df;

		public List<int> charaDfs;

		public List<List<DateTime>> m_boostTims;

		public int m_iTotalScore;

		public double m_iReversal;

		public MiniRankingI(MiniRankingInfo mri)
		{
		}
	}

	private static GameStateManager sInstance;

	public int iOverrideSkillID;

	private string sUserName;

	public string sUserCode;

	public long iUserID;

	public int iScreenWidth;

	public int iScreenHeight;

	public EResolutionLevel eResolution;

	public RenderTexture txRenderTexture;

	public Dictionary<int, int> adWealth;

	public Dictionary<int, int> adWealthCompensation;

	public FriendList sFriend;

	public AlchemyUserInfo sAlchemyInfo;

	public PartyInfo sParty;

	public DailyMissionInfo sDailyMission;

	public List<QuestDetail> sQuestStatusList;

	public InventoryList sInventory;

	public int iPresentNum;

	public List<UnlockAreaInfo> sUnlockAreaList;

	public HomeEnter.LevelLimit sLimitbreakLimit;

	public Formula sLimitbreakEXPCoef;

	public int iLEVEL_CAP;

	public Dictionary<int, List<EXPTable>> sCharaEXPTable;

	public List<PopupInfo> vPopupList;

	public List<PopupInfo> vGuideList;

	public List<PopupInfo> vInformationList;

	public List<QuestDetail> sUpdateQuestList;

	public List<int> sMemberDFList;

	private EControler eControl;

	private int iRareAnim;

	private int iAutoPickBomb;

	private int iUseContainerItem;

	private Coroutine sNoticeCoroutine;

	public ShopGachaLot sGachaLotResult;

	public List<NoticeInfo> NoticeInfoList;

	private Dictionary<int, int> cntNoticeInfo;

	private int iServerDay;

	private float fLocalTimeSec;

	private DateTime sReceiveServerTime;

	private DialogCommon dialog;

	private bool isOpendHardMode;

	private bool isHardMode;

	private List<PartyCharaData> partyCharaDataList_Player;

	public int iLeaderID;

	private static readonly string[] sFlagKey;

	private Dictionary<EFlag, List<byte>> sFlagDic;

	private MiniRankingI m_minirankingi;

	private DegreeInfo m_degreeInfo;

	public static GameStateManager Instance
	{
		get
		{
			return null;
		}
	}

	public DateTime sServerTime
	{
		get
		{
			return default(DateTime);
		}
	}

	public bool IsOpendHardMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsHardMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int Mana
	{
		get
		{
			return 0;
		}
	}

	public int Call
	{
		get
		{
			return 0;
		}
	}

	public int Spoon
	{
		get
		{
			return 0;
		}
	}

	public int ReviveTicket
	{
		get
		{
			return 0;
		}
	}

	public InventoryList Inventory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string UserName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsMemberIn { get; private set; }

	public eStrategyKind Strategy
	{
		get
		{
			return eStrategyKind.eFullPower;
		}
		set
		{
		}
	}

	public bool TimeScale
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EControler ControlType
	{
		get
		{
			return (EControler)0;
		}
		set
		{
		}
	}

	public bool RareItemAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool AutoPickBomb
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseContainerItem
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void SetResolution(EResolutionLevel level)
	{
	}

	public int GetWealth(EWealthKind kind)
	{
		return 0;
	}

	public int GetWealth(int kind)
	{
		return 0;
	}

	public int GetWealthCompensation(int kind)
	{
		return 0;
	}

	public bool IsExistEventQuest()
	{
		return false;
	}

	public void SetServerTime(string time)
	{
	}

	public bool IsOverServerTime(DateTime time)
	{
		return false;
	}

	public void UpdateFieldDate()
	{
	}

	public int GetNowFieldDate()
	{
		return 0;
	}

	public bool IsChangedFieldDate()
	{
		return false;
	}

	public void ModifyResponseData(ResponseDataCommon res)
	{
	}

	public string GetLockQuestIdStringList(EQuestGroup group)
	{
		return null;
	}

	public void UpdateQuestGuide()
	{
	}

	public void SetActiveQuestGuide(bool active)
	{
	}

	public void SetQuestGuideText(EQuestGroup group, string text)
	{
	}

	private void RegistPopup(ResponseDataCommon res)
	{
	}

	public bool DispAnyQuestAcheive()
	{
		return false;
	}

	public bool DispAnyMemberIn()
	{
		return false;
	}

	public bool IsExistDispAnyPopup()
	{
		return false;
	}

	public bool DispAnyPopup(Action<EButtonKind> onExit = null)
	{
		return false;
	}

	public bool IsExistDispAnyGuide()
	{
		return false;
	}

	public bool DispAnyGuide()
	{
		return false;
	}

	public bool IsExistDispAnyInformation()
	{
		return false;
	}

	public bool DispAnyInformation()
	{
		return false;
	}

	public void DispAllNotice(bool achieve = false)
	{
	}

	public bool IsDispAllNotice()
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator _DispAllNotice(bool achieve)
	{
		return null;
	}

	public static List<PartyCharaData> GetPartyCharaDataList()
	{
		return null;
	}

	public static MakeCharaData GetPartyCharaMakeData(int df)
	{
		return null;
	}

	public static MakeCharaData GetMemberCharaMakeData(int df)
	{
		return null;
	}

	public static MakeCharaData GetPlayerCharaMakeData()
	{
		return null;
	}

	public void ModifyPartyMember(CharaDetail detail, InventoryList inv)
	{
	}

	public void ModifyPartyInfo(ResponseDataCommon common)
	{
	}

	public PartyCharaData GetLeader()
	{
		return null;
	}

	public void Init()
	{
	}

	public void ApplyEquipID(MakeCharaData chara, InventoryList inventoryList)
	{
	}

	public bool IsUnlockArea(int areaId)
	{
		return false;
	}

	public bool IsUnlockArea(List<int> areaIdList)
	{
		return false;
	}

	private bool IsAllAreaUnlockDebug()
	{
		return false;
	}

	public bool IsQuestStatus(int questDf, EQuestSTT stt)
	{
		return false;
	}

	public bool IsQuestStatus(List<int> questDfList, EQuestSTT stt)
	{
		return false;
	}

	public bool IsQuestChapterStatus(int chapter, EQuestSTT stt)
	{
		return false;
	}

	public bool IsOrderAdventQuest()
	{
		return false;
	}

	public bool IsOrderQuest(int df)
	{
		return false;
	}

	private void AddElement(EFlag kind)
	{
	}

	public void SetFlag(EFlag kind, byte value)
	{
	}

	public void RemoveFlag(EFlag kind, byte value)
	{
	}

	public bool GetFlag(EFlag kind, byte value)
	{
		return false;
	}

	private void SaveFlag(EFlag kind)
	{
	}

	public void PlusCntNoticeInfo(int id)
	{
	}

	public int GetCntNoticeInfo(int id)
	{
		return 0;
	}

	public void setMiniRankingI(MiniRankingInfo mri)
	{
	}

	public bool isMiniRankingTerm()
	{
		return false;
	}

	public int getMinirankingWealth()
	{
		return 0;
	}

	public int getMinirankingScore()
	{
		return 0;
	}

	public void setMinirankingScore(int score)
	{
	}

	public string getMinirankingName()
	{
		return null;
	}

	public bool isBoostChara(int charaDF)
	{
		return false;
	}

	public bool isBoostTime()
	{
		return false;
	}

	public double getReversal()
	{
		return 0.0;
	}

	public void setDegreeInfo(DegreeInfo di)
	{
	}

	public int gsetDegreeDF()
	{
		return 0;
	}

	public int gsetDegreeStep()
	{
		return 0;
	}
}
