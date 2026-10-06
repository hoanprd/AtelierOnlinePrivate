using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Menu_Title : Menu_Base
{
	[Serializable]
	public class UserName
	{
		public GameObject goRoot;

		public List<UILabel> vList;

		public void Init(string name)
		{
		}
	}

	private enum eMainStep
	{
		First_Init = 0,
		First_Wait = 1,
		FadeI_Init = 2,
		FadeI_Wait = 3,
		ConfirmTerm_Init = 4,
		ConfirmTerm_Wait = 5,
		ServerInfo_Init = 6,
		ServerInfo_Wait = 7,
		HSPLogin_Send = 8,
		HSPLogin_Wait = 9,
		AuthError = 10,
		ServerStatus_Init = 11,
		ServerStatus_Wait = 12,
		ServerExchange_Init = 13,
		ServerExchange_Wait = 14,
		ServerOauth_Init = 15,
		ServerOauth_Wait = 16,
		ControlWait_Init = 17,
		ControlWait_Wait = 18,
		AuthCheck_Wait = 19,
		AuthCheck_End = 20,
		UserCreate_Wait = 21,
		UserCreate_End = 22,
		UserLogin_Wait = 23,
		UserLogin_End = 24,
		CharaEdit_Init = 25,
		CharaEdit_Wait = 26,
		CharaEdit = 27,
		CharaEdit_End = 28,
		AssetCheck_Init = 29,
		AssetCheck_Wait = 30,
		AssetUpdate_Init = 31,
		AssetUpdate_Confirm = 32,
		AssetUpdate_Start = 33,
		AssetUpdate_Wait = 34,
		AssetLoad_Wait = 35,
		TutorialSummary_Init = 36,
		TutorialSummary_Wait = 37,
		Dissemble_Init = 38,
		Dissemble_Wait = 39,
		FadeO_Init = 40,
		FadeO_Wait = 41,
		Tutorial_Field_Init = 42,
		Tutorial_Field_Wait = 43,
		End = 44,
		Error = 45,
		Refund_Waite = 46
	}

	private enum eRefundStatus
	{
		RefundDefault = 0,
		RefundWindow = 1,
		RefundNotExistWindow = 2
	}

	private static Menu_Title g_scrInst;

	public System_MenuManager.eSystemMenuKind m_eNextMenuKind;

	public bool m_bSelection;

	public UILabel m_sInfoLabel;

	[SerializeField]
	private UIGrid m_sButtonGrid;

	[SerializeField]
	private GameObject m_goDebugServerChange;

	[SerializeField]
	private GameObject m_goDebugNewGame;

	[SerializeField]
	private GameObject m_goLinkID;

	[SerializeField]
	private GameObject m_goTakeoverCode;

	[SerializeField]
	private UILabel m_sLoadInfo;

	[SerializeField]
	private GameObject m_goTitle;

	[SerializeField]
	private UserName m_sUserName;

	[SerializeField]
	private GameObject m_goContinueObj;

	[SerializeField]
	private GameObject m_goFirstObj;

	[SerializeField]
	private UILabel m_sUserID;

	[SerializeField]
	private UILabel m_sClientVersion;

	[SerializeField]
	private UILabel m_sGUID;

	[SerializeField]
	private UILabel m_sDecideName;

	[SerializeField]
	private UILabel m_sServerURL;

	[SerializeField]
	private SpawnPrefabData m_sCharaEdit;

	private CharaSelectManager m_sEdit;

	[SerializeField]
	private TitleMenuWindow m_sMenu;

	[SerializeField]
	private GameObject m_goMenuButton;

	[SerializeField]
	private List<AudioClip> m_vTitleCall;

	private eMainStep m_eMainStep;

	private eRaceKind m_eRaceKind;

	private bool m_bIsError;

	private AssetDownloader m_sAssetDownloader;

	private List<VersionData> m_vNowVersion;

	private List<VersionData> m_vDownloadList;

	private DialogCommon m_sDownloadConfirm;

	private bool m_bMakeChara;

	private TakeoverDialog m_sTakeoverDiag;

	private TakeoverCodeExecWindow m_sTakeoverExecWnd;

	private float m_fWaitTime;

	[SerializeField]
	private UIInput m_sInput;

	private const float cfDISP_OPENING_WAIT_TIME = 300f;

	private int m_iServer;

	[SerializeField]
	private RefundWindow m_refundWindow;

	[SerializeField]
	private UIWindowBase m_refundNotExistWindow;

	private eRefundStatus m_eRefund;

	public static Menu_Title GetInst()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void OnContinue()
	{
	}

	public void OnServerChange()
	{
	}

	public void OnNewGame()
	{
	}

	public void OnChaceClear()
	{
	}

	public void OnTakeOver()
	{
	}

	public void OnTakeOverByCode()
	{
	}

	public void OnLogout()
	{
	}

	private void LogoutCallback(EButtonKind button)
	{
	}

	private void LogoutResponseCallback(ResponseDataCommon res)
	{
	}

	private void QuitDialogCallback(EButtonKind button)
	{
	}

	public void OnMenu()
	{
	}

	protected override void MenuUpdate()
	{
	}

	private void ReceiveAPI<T>(T res) where T : ResponseDataCommon
	{
	}

	private eMainStep InitNextScene()
	{
		return eMainStep.First_Init;
	}

	private void OnHomeEnter(HomeEnterResponse res)
	{
	}

	private void First_Init()
	{
	}

	private bool First_Wait()
	{
		return false;
	}

	private void SetChangeMenuRequest()
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadMovie()
	{
		return null;
	}
}
