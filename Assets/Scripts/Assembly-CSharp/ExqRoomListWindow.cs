using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ExqRoomListWindow : QuestWindowBase
{
	[SerializeField]
	private GameObject m_goEventTitle;

	[SerializeField]
	private QuestEventList m_sEventSelect;

	[SerializeField]
	private GameObject m_goListRoot;

	[SerializeField]
	private GameObject m_goTabRoot;

	[SerializeField]
	private ExqRoomListView m_sNormalList;

	[SerializeField]
	private SpawnPrefabData m_sOrderListWindow;

	[SerializeField]
	private SpawnPrefabData m_sMissionDetailWindow;

	[SerializeField]
	private Transform m_trMissionRoot;

	[SerializeField]
	private GameObject m_goOtherButton;

	[SerializeField]
	private GameObject m_goEventButton;

	[SerializeField]
	private UIButton m_uiUpdateButton;

	private DegreeMissionInfo[] m_asMissionDegreeList;

	private Action m_sOnExitEvent;

	private bool m_bUpdatePresent;

	private int m_iPresentNum;

	private int m_iEventID;

	private bool m_bGotoShop;

	private ExqRoomDetailWindow m_sDetail;

	private BannerInfo m_sBannerInfo;

	private bool m_bEventOnly;

	public const string csBADGE_KEY = "QUEST_BADGE_KEY";

	private static int siEventID;

	private bool _isQuickTapGuard;

	private EExqRoomMode m_eNext;

	private ExqRoomRequest m_sRequest;

	private string m_sEnterRoomName;

	private Action<string, RoomPlan, RoomMemberNum, bool> m_saSetOption;

	[SerializeField]
	private ExqRoomConfirmWindow m_sConfirmWindow;

	[SerializeField]
	private ExqRoomFilterWindow m_filterWindow;

	[SerializeField]
	private ExqRoomCreateRoomWindow m_roomCreateWindow;

	private List<RoomInfo> m_vOrderList;

	private bool isQuickTapGuard
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int GetLastEventID
	{
		get
		{
			return 0;
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

	protected override void OnCloseEnd()
	{
	}

	public void Init(ExqRoomRequest req, Action<string, RoomPlan, RoomMemberNum, bool> setOption, Action onExit)
	{
	}

	private void Awake()
	{
	}

	private void OnUpdatePresentNum(int num)
	{
	}

	private void InitList()
	{
	}

	private List<QuestDetail> GetQuestList(EQuestGroup group, bool enableOrderOnly = false)
	{
		return null;
	}

	public void OnBack()
	{
	}

	public void OnFilterWindow()
	{
	}

	public void OnAutoJoinWindow()
	{
	}

	public void OnEnterRoomConfirmWindow()
	{
	}

	public void OnCreateRoomWindow()
	{
	}

	private void UpdateSummary()
	{
	}

	public void UpdateList()
	{
	}

	[DebuggerHidden]
	private IEnumerator CheckQuickTapGuard()
	{
		return null;
	}
}
