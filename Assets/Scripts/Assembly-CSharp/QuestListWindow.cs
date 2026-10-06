using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestListWindow : QuestWindowBase
{
	public enum ETabKind
	{
		eMAIN = 0,
		eSIDE = 1,
		eCHARA = 2,
		eFREE = 3,
		eEVENT = 4,
		eTICKET = 5,
		eEVENT_SELECT = 6,
		eEXTRA = 7,
		eAUTO = 8
	}

	[SerializeField]
	private GameObject m_goEventTitle;

	[SerializeField]
	private QuestEventList m_sEventSelect;

	[SerializeField]
	private GameObject m_goListRoot;

	[SerializeField]
	private GameObject m_goTabRoot;

	[SerializeField]
	private QuestListTab[] m_asTab;

	[SerializeField]
	private QuestMainListView m_sMainList;

	[SerializeField]
	private QuestListView m_sNormalList;

	[SerializeField]
	private QuestCharaList m_sCharaList;

	[SerializeField]
	private SpawnPrefabData m_sOrderListWindow;

	[SerializeField]
	private SpawnPrefabData m_sMissionDetailWindow;

	[SerializeField]
	private Transform m_trMissionRoot;

	[SerializeField]
	private UILabel m_sMissionBadge;

	[SerializeField]
	private GameObject m_goOrderInfoRoot;

	[SerializeField]
	private UILabel m_sOrderNum;

	[SerializeField]
	private UILabel m_sOrderLimit;

	[SerializeField]
	private GameObject m_goOrderListButton;

	[SerializeField]
	private GameObject m_goOtherButton;

	[SerializeField]
	private GameObject m_goEventButton;

	private ETabKind m_eNowTabKind;

	private DegreeMissionInfo[] m_asMissionDegreeList;

	private Action<bool, int, bool> m_sOnExitEvent;

	private bool m_bUpdatePresent;

	private int m_iPresentNum;

	private int m_iEventID;

	private bool m_bGotoShop;

	private List<QuestDetail> m_vOrderList;

	private QuestDetailWindow m_sDetail;

	private BannerInfo m_sBannerInfo;

	private ETabKind m_ePrevTabKind;

	private bool m_bEventOnly;

	public const string csBADGE_KEY = "QUEST_BADGE_KEY";

	private static int siEventID;

	private static ETabKind seTabKind;

	public static int GetLastEventID
	{
		get
		{
			return 0;
		}
	}

	public static ETabKind GetLastTabKind
	{
		get
		{
			return ETabKind.eMAIN;
		}
	}

	private bool isActiveEventBtn
	{
		get
		{
			return false;
		}
	}

	private bool isActiveOrderInfo
	{
		get
		{
			return false;
		}
	}

	private bool isActiveOrderListBtn
	{
		get
		{
			return false;
		}
	}

	public static bool IsNeedKeyBadge()
	{
		return false;
	}

	public static void SetUpdateQuestBadge(List<QuestDetail> questList)
	{
	}

	private void OnDisable()
	{
	}

	public override void OnClose()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public void Init(QuestSummary summary, BannerInfo bannerInfo, DegreeMissionInfo[] degree, Action<bool, int, bool> onExit, ETabKind kind = ETabKind.eAUTO)
	{
	}

	private void Awake()
	{
	}

	private void OnUpdatePresentNum(int num)
	{
	}

	private void InitTab()
	{
	}

	private void InitList()
	{
	}

	private List<QuestDetail> GetQuestList(EQuestGroup group, bool enableOrderOnly = false)
	{
		return null;
	}

	private void OnChangeTab(ETabKind select)
	{
	}

	public void OnMissionWindowSelect(DegreeMissionInfo info)
	{
	}

	public void OnGotoShop()
	{
	}

	public void OnMissionWindow()
	{
	}

	public void OnOrderListWindow()
	{
	}

	public void OnDispEvent()
	{
	}

	public void OnSelectEvent(int eventID)
	{
	}

	private void OnOpenSideQuest(int chapter)
	{
	}

	private void OnCloseOrderList(List<QuestDetail> update)
	{
	}

	private void OnUpdateDetail(QuestDetail update)
	{
	}

	private void UpdateSummary()
	{
	}

	private EQuestGroup GetNowGroup()
	{
		return EQuestGroup.None;
	}

	private void UpdateOrderNum()
	{
	}

	private void UpdateList()
	{
	}

	private void UpdateBadge()
	{
	}

	private void OnUpdateMission(DegreeMissionInfo[] list)
	{
	}
}
