using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ExqRoomPartyManager : UIWindowBase
{
	private static ExqRoomPartyManager m_inst;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UILabel m_sComment;

	[SerializeField]
	private UILabel m_sPlan;

	[SerializeField]
	private QuestClearInfo m_sQuestClearInfo;

	[SerializeField]
	private UIButton m_sMemberEditButton;

	[SerializeField]
	private AnimationController m_sAnimCtr;

	[SerializeField]
	private AnimationController m_sMainMenuAnim;

	[SerializeField]
	private ExqRoomPartyMemberList m_sMemberList;

	[SerializeField]
	private ExqRoomPartyFormation m_sFormationChange;

	[SerializeField]
	private List<GameObject> m_sBlackWidList;

	private PartyInfo m_sPartyInfo;

	private PartyEditMemberInfo m_sTarget;

	private ExqRoomRequest m_sRequest;

	private EExqRoomMode m_eNext;

	private string m_sRoomName;

	private Coroutine m_sExitMemberCoroutine;

	public static List<CharaDetail> s_vCharaDetailList;

	[SerializeField]
	private Transform m_trQuestTargetDetailRoot;

	[SerializeField]
	private SpawnerPlayerStatus m_spwPlayerStatus;

	[HideInInspector]
	public bool m_updatingRoomInfo;

	[SerializeField]
	private ExqRoomConfirmWindow m_sConfirmWindow;

	[SerializeField]
	private ExqRoomCreateRoomWindow m_roomEditSettingsWindow;

	[SerializeField]
	private SpawnPrefabData m_goRoomMemberWindow;

	[SerializeField]
	private UISprite m_spReadyBtnBlackSheet;

	[SerializeField]
	private UILabel m_lQuestReady;

	[SerializeField]
	private UIButton m_btnRoomSetting;

	[SerializeField]
	private UIButton m_btnRoomDissolution;

	public Game_UI_Status m_uiStatus
	{
		get
		{
			return null;
		}
	}

	public static ExqRoomPartyManager GetInst()
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

	public void Init(PartyInfo info, ExqRoomRequest req)
	{
	}

	public void SetReadyButton()
	{
	}

	public void SetRoomViewInfo(Action callback = null)
	{
	}

	private void SetQuestData(Action callback = null)
	{
	}

	[DebuggerHidden]
	private IEnumerator SetDispCost(MasterQuestInfo quest)
	{
		return null;
	}

	protected override void OnCloseEnd()
	{
	}

	public override void OnClose()
	{
	}

	public void OnBack(bool bForce = false)
	{
	}

	public void OnPartyMenu()
	{
	}

	public void OnEditRoomSettingWindow()
	{
	}

	public void DispTargetDetail()
	{
	}

	public void OnBreakup()
	{
	}

	public void OnMemberListWindow()
	{
	}

	public bool IsOpenMemberListWindow()
	{
		return false;
	}

	public void CloseMemberListWindow()
	{
	}

	public void OnSelectQuestWindow()
	{
	}

	public void OnStartQuest()
	{
	}

	public void Departure()
	{
	}

	[DebuggerHidden]
	private IEnumerator WateRoomInfoUpdating(Action callback)
	{
		return null;
	}

	public void Breakup()
	{
	}
}
