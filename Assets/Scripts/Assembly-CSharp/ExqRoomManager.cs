using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ExqRoomManager : MonoBehaviour
{
	private static ExqRoomManager m_inst;

	[HideInInspector]
	public bool isExtraQuestMode;

	public const string EXQ_ROOM_GROUP = "EXQ";

	public const float LIMIT_ENTRY_RESTRICTION = 20f;

	private static readonly int s_reEnterMax;

	[SerializeField]
	private eExqPunStep m_eExqPunStep;

	private ERelationPunRoomMode m_eRelationStep;

	private bool m_isNetworkEnd;

	private bool m_isStepWaitEnd;

	private bool m_isAPIError;

	private bool m_isLeaveRoomEnd;

	private float m_secWaitLeaveRoomDelayTime;

	private bool m_isEndErrorDialog;

	private int m_reCreateRoomCount;

	private bool m_isCheckRoomEnter;

	private Dictionary<string, object> m_dicRoomCreateOption;

	private Dictionary<string, object> m_dicTakeOverFixRoomOption;

	private int m_numDepartureMember;

	private float m_entryRestrictionTime;

	public Dictionary<int, ExqClearTarget_MP_CharaData> ClearMPCharaData;

	[SerializeField]
	private Transform m_trsExQuest;

	private QuestListWindow.ETabKind m_eQuestTab;

	private Coroutine m_sCorotine;

	private GameObject m_goQuestWnd;

	private ExqRoomListWindow m_exqRoomListWindow;

	private ExqRoomPartyManager m_exqRoomPartyWindow;

	[SerializeField]
	private SpawnPrefabData m_sExqRoomList;

	[SerializeField]
	private SpawnPrefabData m_sExqRoomParty;

	private List<EExqRoomMode> m_vModeTree;

	private Action m_sOnClose;

	private string m_sEnterRoomName;

	private bool m_bReceivePartyInfo;

	public string EXQ_CREATE_ROOM_NAME
	{
		get
		{
			return null;
		}
	}

	public string enterRoomName
	{
		get
		{
			return null;
		}
	}

	public static long SettingServerRID
	{
		get
		{
			return 0L;
		}
	}

	public Dictionary<string, object> TakeOverFixRoomOption
	{
		get
		{
			return null;
		}
	}

	public int DepartureMemberNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float EntryRestrictionTime
	{
		get
		{
			return 0f;
		}
	}

	public static ExqRoomManager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void Init(Action onClose, EExqRoomMode defaultMode = EExqRoomMode.eROOM_LIST, string targetRoomName = "", bool isCheckRoomEnter = false)
	{
	}

	public void OnBack()
	{
	}

	public void OnRequest(EExqRoomMode next, string enterRoomName)
	{
	}

	public bool IsOpenQuestBoard()
	{
		return false;
	}

	public void CloseQuestBoard()
	{
	}

	private void PunStepUpdate()
	{
	}

	private eExqPunStep DisconnectPhoton_Init()
	{
		return eExqPunStep.None;
	}

	private void OnDisconnectPhoton(bool success, string message)
	{
	}

	private void ConnectPhoton_Init()
	{
	}

	private void OnConnectPhoton(bool success, string message)
	{
	}

	private void OnPhotonFailedDialog(EButtonKind result)
	{
	}

	private bool ConnectPhoton_Wait()
	{
		return false;
	}

	private void First_Init()
	{
	}

	private void OnJoinLobby(bool success, string message)
	{
	}

	private void OnRoomEnter(bool success, string message)
	{
	}

	private void FailedRoomDialog()
	{
	}

	private bool First_Wait()
	{
		return false;
	}

	private bool RoomList_Wait()
	{
		return false;
	}

	private void CreateRoom_Init()
	{
	}

	private void OnAPI_CreateRoom()
	{
	}

	private bool SetRoomIndex_Wait()
	{
		return false;
	}

	private void LeaveRoom_Init()
	{
	}

	private void SetMode(EExqRoomMode mode)
	{
	}

	[DebuggerHidden]
	private IEnumerator SafetyNoResponse(Action callExec)
	{
		return null;
	}

	private bool IsNowMode(EExqRoomMode mode)
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator WaitPunTargetStateComp(eExqPunStep eTargetStep, Action callback, Action error = null, float limit = 10f)
	{
		return null;
	}

	private void RegistMode(EExqRoomMode mode)
	{
	}

	public void JoinProgressRoom()
	{
	}

	public void RequestJump()
	{
	}

	private void SetTakeOverFixRoomOption()
	{
	}

	public void SetCreateRoomOption(string comment, RoomPlan plan, RoomMemberNum member, bool isFriendOnly)
	{
	}

	public PartyMember GetMemberConvert(FriendDetail info, PlayerDetailManager.OthersProfile_Photon othersProf = null)
	{
		return null;
	}

	public void OnExQuest(Action callback = null)
	{
	}

	private void OnQuestSummary(Action callback = null)
	{
	}

	public void GetQuestShow(int df, Action<QuestShow, InventoryList> callBack, Action<int> error = null)
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadQuest(QuestSummary summary, BannerInfo bannerInfo, DegreeMissionInfo[] degree, bool ev, Action callback = null)
	{
		return null;
	}

	private void OnCloseQuest(bool update, int presentNum, bool gotoShop)
	{
	}

	public void SetRoomEntryRestriction(float setTime)
	{
	}

	[DebuggerHidden]
	public IEnumerator SetCloneMultiPlayCharaData(Action callBack)
	{
		return null;
	}

	public void ActivateReadyButton()
	{
	}
}
