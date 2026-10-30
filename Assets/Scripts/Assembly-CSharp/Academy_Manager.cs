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
		return g_scrInst;
	}

	protected override void Awake()
	{
		base.Awake();
		g_scrInst = this;
		m_mainStep = eMainStep.First_Init;
	}

	protected override void OnDestroy()
	{
		if (g_scrInst == this)
		{
			g_scrInst = null;
		}
		base.OnDestroy();
	}

	private eMusicID GetAcademyBGM()
	{
		return eMusicID.Title;
	}

	protected override void MenuUpdate()
	{
		switch (m_mainStep)
		{
		case eMainStep.First_Init:
			NetworkManager.HomeEnter(delegate(HomeEnterResponse res)
			{
				m_uiInfo = (res != null) ? res.API : null;
				m_mainStep = eMainStep.QuestFill_Init;
			});
			m_mainStep = eMainStep.First_Wait;
			break;

		case eMainStep.First_Wait:
			break;

		case eMainStep.QuestFill_Init:
			NetworkManager.QuestFill(delegate
			{
				m_mainStep = eMainStep.QuestSummary_Init;
			});
			m_mainStep = eMainStep.QuestFill_Wait;
			break;

		case eMainStep.QuestFill_Wait:
			break;

		case eMainStep.QuestSummary_Init:
			NetworkManager.QuestSummary(delegate
			{
				m_mainStep = eMainStep.TreasureStat_Init;
			});
			m_mainStep = eMainStep.QuestSummary_Wait;
			break;

		case eMainStep.QuestSummary_Wait:
			break;

		case eMainStep.TreasureStat_Init:
			NetworkManager.HuntStatus(delegate(HuntStatusResponse res)
			{
				m_huntStat = (res != null) ? res.API : null;
				m_mainStep = eMainStep.FadeI_Init;
			});
			m_mainStep = eMainStep.TreasureStat_Wait;
			break;

		case eMainStep.TreasureStat_Wait:
			break;

		case eMainStep.FadeI_Init:
			if (m_launcher != null)
			{
				m_launcher.Init(m_commonInfo, m_uiInfo, m_huntStat);
				m_launcher.Bringin();
			}
			SetEnableObjGroup(false, false);
			LoadingManager.Disable(0.5f);
			m_mainStep = eMainStep.Tutorial_Init;
			break;

		case eMainStep.Tutorial_Init:
			if (StartTutorial())
			{
				m_mainStep = eMainStep.Tutorial_Wait;
			}
			else
			{
				m_mainStep = eMainStep.FrontSide_First;
			}
			break;

		case eMainStep.Tutorial_Wait:
			if (TutorialManager.Instance == null || TutorialManager.Instance.IsEnd())
			{
				m_mainStep = eMainStep.FrontSide_First;
			}
			break;

		case eMainStep.FrontSide_First:
			SetEnableObjGroup(true, false);
			PlayBGM();
			m_mainStep = eMainStep.FrontSide_Init;
			break;

		case eMainStep.FrontSide_Init:
			m_mainStep = eMainStep.FrontSide_Wait;
			break;

		case eMainStep.FrontSide_Wait:
			if (m_moveReqFlag)
			{
				m_moveReqFlag = false;
				m_mainStep = eMainStep.BackSide_First;
			}
			break;

		case eMainStep.BackSide_First:
			SetMoveAnime(true);
			m_mainStep = eMainStep.BackSide_MoveIn;
			break;

		case eMainStep.BackSide_MoveIn:
			if (IsFinishd_MoveAnime())
			{
				SetEnableObjGroup(false, true);
				m_mainStep = eMainStep.BackSide_Wait;
			}
			break;

		case eMainStep.BackSide_Wait:
			if (m_moveReqFlag)
			{
				m_moveReqFlag = false;
				m_mainStep = eMainStep.BackSide_MoveOut;
			}
			break;

		case eMainStep.BackSide_MoveOut:
			SetMoveAnime(false);
			SetEnableObjGroup(true, false);
			m_mainStep = eMainStep.FrontSide_Wait;
			break;

		case eMainStep.FadeO_Init:
			LoadingManager.Enable(0.5f);
			m_mainStep = eMainStep.FadeO_Wait;
			break;

		case eMainStep.FadeO_Wait:
			if (LoadingManager.IsBlackOut)
			{
				if (System_MenuManager.GetInst() != null)
				{
					System_MenuManager.GetInst().SetMenuRequest(m_nextMenuKind);
				}
				m_mainStep = eMainStep.End;
			}
			break;
		}
	}

	private void PlayBGM()
	{
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlayMusic(GetAcademyBGM(), true, 0.5f, false);
		}
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
		if (m_frontSideRoot != null)
		{
			for (int i = 0; i < m_frontSideRoot.Count; i++)
			{
				if (m_frontSideRoot[i] != null)
				{
					m_frontSideRoot[i].SetActive(enableFrontSide);
				}
			}
		}
		if (m_backSideRoot != null)
		{
			for (int j = 0; j < m_backSideRoot.Count; j++)
			{
				if (m_backSideRoot[j] != null)
				{
					m_backSideRoot[j].SetActive(enableBackSide);
				}
			}
		}
	}

	private void SetMoveAnime(bool front2Back)
	{
		if (m_targetAnim != null)
		{
			string clipName = front2Back ? "academystay01" : "academystay02";
			m_targetAnim.Play(clipName);
		}
	}

	private bool IsFinishd_MoveAnime()
	{
		return m_targetAnim == null || !m_targetAnim.isPlaying;
	}

	public void SetMove()
	{
		m_moveReqFlag = true;
	}

	public void SetChangeMenuRequest(System_MenuManager.eSystemMenuKind eKind)
	{
		m_nextMenuKind = eKind;
		m_mainStep = eMainStep.FadeO_Init;
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
		if (m_launcher != null)
		{
			m_launcher.Close();
		}
	}

	public void OpenLauncher()
	{
		if (m_launcher != null)
		{
			m_launcher.Open();
		}
	}

	public bool IsOpenLauncher()
	{
		return m_launcher != null;
	}

	public bool IsEndLauncherAnimation()
	{
		return true;
	}

	private void EndTutorial(eTutorial now, bool success, bool skip)
	{
		UnityEngine.Debug.Log("[Academy_Manager] EndTutorial: " + now + " success: " + success);
	}

	[DebuggerHidden]
	private IEnumerator PlayTutorial()
	{
		yield return null;
	}

	private bool StartTutorial()
	{
		var tutMgr = TutorialManager.Instance;
		if (tutMgr != null)
		{
			if (!tutMgr.GetFlag((eTutorial)0))
			{
				return tutMgr.ExecTutorial((eTutorial)0, EndTutorial);
			}
		}
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
