using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Game_UI_FieldLauncher : LauncherBase
{
	public enum EMenuKind
	{
		eNONE = 0,
		eALCHEMY = 1,
		eMULTI_ALCHEMY = 2,
		eEQUIP = 3,
		eQUEST = 4,
		ePARTY_EDIT = 5,
		eRUCK = 6,
		eCOMPOSITE = 7
	}

	[SerializeField]
	private SpawnPrefabData m_sFriendWindow;

	[SerializeField]
	public SpawnPrefabData m_sItemSetting;

	[SerializeField]
	public UIButton m_sButtonOpenClose;

	[SerializeField]
	public UIButton m_sButtonMenu;

	[SerializeField]
	public UIButton m_sButtonAlchemy;

	[SerializeField]
	public UIButton m_sButtonChara;

	[SerializeField]
	public UIButton m_sButtonItem;

	[SerializeField]
	public UIButton m_sButtonOther;

	[SerializeField]
	public UIButton m_sButtonFriend;

	[SerializeField]
	public UIButton m_sButtonComposite;

	[SerializeField]
	public LockMark m_sLockComposite;

	[SerializeField]
	public UIButton m_sButtonHeal;

	[SerializeField]
	public UIButton m_sButtonCure;

	[SerializeField]
	public UIButton m_sButtonFairyP;

	[SerializeField]
	private FairyPowder m_sFairyP;

	[SerializeField]
	private AutoPickUI m_sAutoPick;

	[SerializeField]
	private MiniRankingScore m_sMiniRankingS;

	private EMenuKind m_eMenuKind;

	private List<QuestDetail> m_sQuestList;

	protected void Start()
	{
	}

	private void LateUpdate()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void UpdateUIActive()
	{
	}

	public override void Close()
	{
	}

	public override void OnOpenClose()
	{
	}

	public void OnAlchemy()
	{
	}

	public void OnAlchemyCoop()
	{
	}

	public void OnComposite()
	{
	}

	public void OnFriend()
	{
	}

	public void OnPartyMenu()
	{
	}

	private void OnPartyExit()
	{
	}

	public void OnOpenInventory()
	{
	}

	public void UpdateUseItemButton()
	{
	}

	private void UpdateHealButtonColor()
	{
	}

	public void OnSelectHealItem()
	{
	}

	public void OnCancelHealItem()
	{
	}

	public void OnSelectRecoveryItem()
	{
	}

	public void OnCancelRecoveryItem()
	{
	}

	public void OnFairyPowderButton()
	{
	}

	public override void OnQuest()
	{
	}

	[DebuggerHidden]
	protected override IEnumerator LoadQuest(QuestSummary summary, BannerInfo bannerInfo, DegreeMissionInfo[] degree, bool ev)
	{
		return null;
	}

	protected override void OnCloseQuest(bool update, int presentNum, bool gotoShop)
	{
	}

	[DebuggerHidden]
	protected IEnumerator QuestCheck()
	{
		return null;
	}

	public bool IsAutoPick()
	{
		return false;
	}

	public void StopAutoPick()
	{
	}

	public void AutoPickUseBomb(bool bUse)
	{
	}

	private void InitMenu(EMenuKind kind)
	{
	}

	private void Update()
	{
	}

	private bool IsActivateOK()
	{
		return false;
	}

	private bool IsOpenMenu()
	{
		return false;
	}

	public void setMiniRankingScore(int score)
	{
	}
}
