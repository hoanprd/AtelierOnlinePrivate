using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Academy_Manager : Menu_Base
{
	private enum eMainStep
	{
		First_Init = 0,
		First_Wait = 1,
		QuestFill_Init = 2,
		QuestFill_Wait = 3,
		QuestSummary_Init = 4,
		QuestSummary_Wait = 5,
		TreasureStat_Init = 6,
		TreasureStat_Wait = 7,
		FadeI_Init = 8,
		FadeI_Wait = 9,
		Tutorial_Init = 10,
		Tutorial_Wait = 11,
		LoginBonusInit = 12,
		LoginBonusWait = 13,
		DispDailyInfoInit = 14,
		DispDailyInfoWait = 15,
		FrontSide_First = 16,
		FrontSide_Init = 17,
		FrontSide_Wait = 18,
		BackSide_First = 19,
		BackSide_Init = 20,
		BackSide_MoveIn = 21,
		BackSide_Wait = 22,
		BackSide_MoveOut = 23,
		Adventure_First = 24,
		Adventure_Init = 25,
		Adventure_Wait = 26,
		Adventure_End = 27,
		Respawn_Init = 28,
		Respawn_Wait = 29,
		FadeO_Init = 30,
		FadeO_Wait = 31,
		TutorialExit_Init = 32,
		TutorialExit_Wait = 33,
		End = 34
	}

	private static Academy_Manager g_scrInst;

	private static bool ms_is_searched;

	private eMainStep m_mainStep;

	private System_MenuManager.eSystemMenuKind m_nextMenuKind;

	private bool m_moveReqFlag;

	public AcademyLauncher m_launcher;

	public List<GameObject> m_frontSideRoot;

	public List<GameObject> m_backSideRoot;

	public Animation m_targetAnim;

	public Academy_FairyPickButton m_fairyButton;

	public Academy_CharaManager m_charaLoc;

	[SerializeField]
	private Academy_TalkButton m_talkInfo;

	private bool m_talkReqFlag;

	private QuestTalker m_questTalker;

	private eMainStep m_prevStep;

	private HuntStatus m_huntStat;

	private HomeEnter m_uiInfo;

	private ResponseDataCommon m_commonInfo;

	private eTutorial m_prevTutorial;

	private float m_fadeInWait;

	private bool m_bUpdateLocation;

	private WebViewWindow m_sInformationWebView;

	[SerializeField]
	private Camera m_3dCamera;

	private static bool m_visit;

	private const string csDISPDAILYMISSION_KEY = "DISP_MISSION";

	public static Academy_Manager GetInst()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private eMusicID GetAcademyBGM()
	{
		return eMusicID.Title;
	}

	protected override void MenuUpdate()
	{
	}

	private void SetGateData()
	{
	}

	private void OnCharaEditExit(bool update)
	{
	}

	private void FinishTutorial(eTutorial kind, bool finish)
	{
	}

	private void ReceiveAPI<T>(T res) where T : ResponseDataCommon
	{
	}

	private void ReceiveTreasure(HuntStatusResponse res)
	{
	}

	private void SetEnableObjGroup(bool enableFrontSide = false, bool enableBackSide = false)
	{
	}

	private void SetMoveAnime(bool front2Back)
	{
	}

	private bool IsFinishd_MoveAnime()
	{
		return false;
	}

	public void SetMove()
	{
	}

	public void SetChangeMenuRequest(System_MenuManager.eSystemMenuKind eKind)
	{
	}

	public void RespawnParty()
	{
	}

	public void UpdateLocationRequest()
	{
	}

	public bool IsNeedUpdateNPC()
	{
		return false;
	}

	public void UpdateNPC()
	{
	}

	public void SetDispTalkIcon(bool disp)
	{
	}

	public void OnTalkStart(Academy_TalkButton talk)
	{
	}

	public Vector3 GetWorldPos(Vector3 nguiPos, float screenZ = 20f)
	{
		return default(Vector3);
	}

	public void OnSelectFairy()
	{
	}

	public void CloseLauncher()
	{
	}

	public void OpenLauncher()
	{
	}

	public bool IsOpenLauncher()
	{
		return false;
	}

	public bool IsEndLauncherAnimation()
	{
		return false;
	}

	private void EndTutorial(eTutorial now, bool success, bool skip)
	{
	}

	[DebuggerHidden]
	private IEnumerator PlayTutorial()
	{
		return null;
	}

	private bool StartTutorial()
	{
		return false;
	}

	private void PlayCharaEditTutorial()
	{
	}

	private void DispDailyInfo()
	{
	}

	private void DispInformation()
	{
	}

	private void DispRestorePurchaseInfo()
	{
	}

	private bool IsDispDailyInfo()
	{
		return false;
	}

	private void ReserveRestartGacha()
	{
	}
}
