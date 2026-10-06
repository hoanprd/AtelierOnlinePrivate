using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap : SingletonBase<Game_UI_GateMap>
{
	public delegate void GateMapCallback(bool bJump, bool bMulti, int iArea, int iStage, int iSpawnNo, EPrivateRoom ePrivateRoom, bool bStoreMulti);

	public enum eMainStep
	{
		Wait = 0,
		First_Init = 1,
		First_Wait = 2,
		API_QuestSummary_Init = 3,
		API_QuestSummary_Wait = 4,
		API_GateInfo_Init = 5,
		API_GateInfo_Wait = 6,
		Check_OpendHardMode_Init = 7,
		Check_OpendHardMode_Wait = 8,
		API_RoomInfo_Init = 9,
		API_RoomInfo_Wait = 10,
		API_FriendList_Init = 11,
		API_FriendList_Wait = 12,
		API_BannerInfo_Init = 13,
		API_BannerInfo_Wait = 14,
		BringIn_Init = 15,
		BringIn_Wait = 16,
		DeviceCheck = 17,
		DeviceCheck_Wait = 18,
		AssetCheck = 19,
		AssetDL_Init = 20,
		AssetDL_Wait = 21,
		Control_Init = 22,
		Control_Wait = 23,
		Pinch_Init = 24,
		Pinch_Wait = 25,
		ModeChange_Init = 26,
		ModeChange_Wait = 27,
		CreateFriendRoom_Init = 28,
		GateList_Init = 29,
		GateList_Wait = 30,
		QuestList_Init = 31,
		QuestList_Wait = 32,
		ExtraQuestList_Init = 33,
		ExtraQuestList_Wait = 34,
		MakeSure_Init = 35,
		MakeSure_Wait = 36,
		Adventure_Init = 37,
		Adventure_Wait = 38,
		FadeIn_Init = 39,
		FadeIn_Wait = 40,
		Dismiss_Init = 41,
		Dismiss_Wait = 42,
		DifficultyChange_FadeIn_Init = 43,
		DifficultyChange_FadeIn_Wait = 44,
		Finish = 45
	}

	public enum eButton
	{
		Back = 0,
		ModeChange = 1,
		WarpPoint = 2,
		GateList = 3,
		ExtraQuestList = 4,
		FriendList = 5,
		Pinch = 6,
		QuestList = 7,
		FriendRoom = 8,
		DifficultyChange = 9,
		EnumMax = 10
	}

	public enum ePinch
	{
		None = 0,
		In = 1,
		Out = 2
	}

	public enum eMapScale
	{
		OverAll = 0,
		Part = 1,
		EnumMax = 2
	}

	public enum eAnim
	{
		StatusBar = 0,
		WorldMap = 1,
		EnumMax = 2
	}

	public enum eMode
	{
		Single = 0,
		Multi = 1
	}

	public enum eADV
	{
		ContainerMax = 0,
		RuckMax = 1,
		EnumMax = 2
	}

	private static readonly string[] sc_strMagnifyNameAry;

	private static readonly float sc_fIconDispPer;

	private static readonly float sc_fIconHiddenPer;

	private static readonly float sc_fGateNameDispPer;

	private static readonly float sc_fMagnifyTouchTimeMax;

	private static readonly string sc_strExpedOnlineKey;

	private static readonly string sc_strGateListDispKey;

	public Color32 m_cMultiNotifyColor;

	private eMainStep m_eStep;

	private bool m_bMultiMode;

	private eMapScale m_eMapScale;

	private eButton m_eButton;

	private ePinch m_ePinch;

	private bool m_bUpdateOK;

	private bool m_bForceExit;

	private bool m_bIconDisp;

	private bool m_bDialogEnd;

	private EButtonKind m_eDialogResult;

	private bool m_bAPIEnd;

	private float m_fTouchTime;

	private eADV m_eADV;

	private int m_iNowAreaId;

	private EPrivateRoom m_ePrivateRoom;

	private GateMapCallback m_dEndCallback;

	private bool m_bFinishedTween;

	private Game_UI_Status m_scrStatusUI;

	private Vector3[] m_v3MapScaleAry;

	private QuestOrderListWindow m_clsQuestWindow;

	private List<ShopBanner> m_clsBannerList;

	private DialogUnsupportedDevice m_scrUnsupportedDevice;

	private AllAssetDownloadManager m_scrAssetDLer;

	private bool m_bSuccessAssetDL;

	private int m_iReqArea;

	private int m_iReqStage;

	private int m_iReqSpawnNo;

	private string m_strGateName;

	private bool m_bStoreMulti;

	private bool m_ChangeDifficultyEnd;

	private bool m_OpendHardMode;

	private bool m_IsHardMode;

	private bool m_IsBack;

	private bool m_IsOpenExqConfirmPop;

	[SerializeField]
	private AnimationController[] m_scrAnimAry;

	[SerializeField]
	private UITweenReset m_scrTweenResetScl;

	[SerializeField]
	private UITweenReset m_scrTweenResetPos;

	[SerializeField]
	private UIScrollView m_scrScrollView;

	[SerializeField]
	private Game_UI_GateMap_WarpPointManager m_scrWarpPointMng;

	[SerializeField]
	private Game_UI_GateMap_AreaNameManager m_scrAreaNameMng;

	[SerializeField]
	private Game_UI_GateMap_PlayerInfoManager m_scrPlayerInfoMng;

	[SerializeField]
	private Game_UI_GateMap_RouteManager m_scrRouteMng;

	[SerializeField]
	private Game_UI_GateMap_FacilityManager m_scrFacilityMng;

	[SerializeField]
	private Transform m_trStatusUIRoot;

	[SerializeField]
	private GameObject m_goStatusUIPrefab;

	[SerializeField]
	private UILabel m_scrModeLabel;

	[SerializeField]
	private GameObject m_goMultiModeMark;

	[SerializeField]
	private GameObject[] m_goActiveRootList;

	[SerializeField]
	private Game_UI_GateMap_GateList m_scrGateList;

	[SerializeField]
	private UISprite m_scrMagnify;

	[SerializeField]
	private UIButton m_scrModeChangeBtn;

	[SerializeField]
	private UIButton m_scrFriendBtn;

	[SerializeField]
	private SpawnPrefabData m_clsFriendWindow;

	[SerializeField]
	private UILabel m_scrFriendBadgeNum;

	[SerializeField]
	private UIButton m_scrFriendRoomToggleBtn;

	[SerializeField]
	private Game_UI_GateMap_Banner m_scrBanner;

	[SerializeField]
	private UIButton m_scrGateListBtn;

	[SerializeField]
	private Game_UI_DifficultyChange_Btn m_scrDifficultyChangeButton;

	[SerializeField]
	private GameObject m_goExtraQuestButton;

	[SerializeField]
	private WorldMapColorChanger m_scrWorldMapColorChanger;

	[SerializeField]
	private GameObject[] m_goChangeActivateObjForHardMode;

	public bool IsOpenExqConfirmPop
	{
		get
		{
			return false;
		}
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroySub()
	{
	}

	private void SetActive(bool bActive)
	{
	}

	private void Update()
	{
	}

	private void First_Init()
	{
	}

	private bool First_Wait()
	{
		return false;
	}

	private void API_QuestSummary_Init()
	{
	}

	private bool API_QuestSummary_Wait()
	{
		return false;
	}

	private void API_GateInfo_Init()
	{
	}

	private bool API_GateInfo_Wait()
	{
		return false;
	}

	private void API_RoomInfo_Init()
	{
	}

	private bool API_RoomInfo_Wait()
	{
		return false;
	}

	private void API_FriendList_Init()
	{
	}

	private bool API_FriendList_Wait()
	{
		return false;
	}

	private void API_BannerInfo_Init()
	{
	}

	private bool API_BannerInfo_Wait()
	{
		return false;
	}

	private void BringIn_Init()
	{
	}

	private bool BringIn_Wait()
	{
		return false;
	}

	private void DeviceCheck_Init()
	{
	}

	private bool DeviceCheck_Wait()
	{
		return false;
	}

	private void AssetDL_Init()
	{
	}

	private bool AssetDL_Wait()
	{
		return false;
	}

	private void OnEndAssetDL(bool bSuccess)
	{
	}

	private void Control_Init()
	{
	}

	private bool Control_Wait()
	{
		return false;
	}

	private void Pinch_Init()
	{
	}

	private bool Pinch_Wait()
	{
		return false;
	}

	private void OnFinishedTweenScale()
	{
	}

	private void OnFinishedTweenPosition()
	{
	}

	private void ModeChange_Init()
	{
	}

	private bool ModeChange_Wait()
	{
		return false;
	}

	private void ModeChange(bool bMultiMode)
	{
	}

	private void SetActiveFriendRoomBtn(bool bActive)
	{
	}

	private void CreateFriendRoom_Init()
	{
	}

	private void FriendRoomChange(EPrivateRoom ePrivateRoom)
	{
	}

	private void GateList_Init()
	{
	}

	private bool GateList_Wait()
	{
		return false;
	}

	private void OnCloseGateList()
	{
	}

	private void ExtraQuest_Init()
	{
	}

	private bool ExtraQuest_Wait()
	{
		return false;
	}

	public void OnCloseExtraQuest()
	{
	}

	private void QuestList_Init()
	{
	}

	private bool QuestList_Wait()
	{
		return false;
	}

	private void MakeSure_Init()
	{
	}

	private bool MakeSure_Wait()
	{
		return false;
	}

	private void OnInventoryCheckEnd(EButtonKind eResult)
	{
	}

	private void OnMakeSureEnd(EButtonKind eResult)
	{
	}

	private void Adventure_Init()
	{
	}

	private bool Adventure_Wait()
	{
		return false;
	}

	private void Dismiss_Init()
	{
	}

	private bool Dismiss_Wait()
	{
		return false;
	}

	private void ChangeDifficultyInit()
	{
	}

	private void ChangeDifficulty()
	{
	}

	private void ChangeActivateObjForHardMode()
	{
	}

	private bool ChangeDifficultyWait()
	{
		return false;
	}

	private void Finish()
	{
	}

	private void UpdateGateNameActive()
	{
	}

	private void UpdatePlayerInfo(bool bAPI = false)
	{
	}

	private void UpdatePlayerInfoActive()
	{
	}

	private bool IsWarp()
	{
		return false;
	}

	private void OnAPI_GateInfo(GateInfoResponse clsRes)
	{
	}

	private void OnAPI_RoomInfo(ExploreRoomInfoResponse clsRes)
	{
	}

	private void OnAPI_QuestSummary(QuestSummaryResponse clsRes)
	{
	}

	private void OnAPI_FrinedList(FriendInfoResponse clsRes)
	{
	}

	private void OnAPI_BannerInfo(BannerInfoResponse clsRes)
	{
	}

	private void UpdateFriendReceive(List<FriendData> clsList)
	{
	}

	private void MoveScrollView(int iAreaId, bool bTween, bool bCheckConstraint)
	{
	}

	private void MoveScrollView(Vector3 v3Pos, bool bTween, bool bCheckConstraint)
	{
	}

	private bool IsControlOK()
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	private bool IsUnlockMultiTiming()
	{
		return false;
	}

	private void CheckOpendHardMode()
	{
	}

	private bool CheckOpendHardModeWait()
	{
		return false;
	}

	private void CheckDegreeOFHardMode(ProfileInfoResponse res)
	{
	}

	private void ActivateHardMode(bool active)
	{
	}

	private void SettingHardModeUI(bool m_Opend = true)
	{
	}

	public void Init(GateMapCallback dEndCallback)
	{
	}

	public int GetNowAreaID()
	{
		return 0;
	}

	public void ForceExit()
	{
	}

	public void ClickedButton(eButton eKind, int iArea = 0, int iStage = 0, int iSpawnNo = 0, string strGateName = "")
	{
	}

	public void OnQuestClose(List<QuestDetail> scrUpdateLsit)
	{
	}

	public bool IsOpen()
	{
		return false;
	}
}
