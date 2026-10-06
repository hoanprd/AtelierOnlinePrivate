using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class AcademyLauncher : LauncherBase
{
	[SerializeField]
	private GameObject[] m_agoTutorialDisableObject;

	[SerializeField]
	private SpawnPrefabData m_sShop;

	[SerializeField]
	private SpawnPrefabData m_sPresent;

	[SerializeField]
	private SpawnPrefabData m_sCharaEdit;

	[SerializeField]
	private SpawnPrefabData m_sOtherMenu;

	[SerializeField]
	private SpawnPrefabData m_sFairyPick;

	[SerializeField]
	private SpawnPrefabData m_sRanking;

	[SerializeField]
	private SpawnPrefabData m_sTreasure;

	[SerializeField]
	private SpawnPrefabData m_sContainer;

	[SerializeField]
	private UILabel m_sPlayerName;

	[SerializeField]
	private UILabel m_sPlayerLevel;

	[SerializeField]
	private AnimationController m_sAnimInOut;

	[SerializeField]
	private UIButton m_sButtonOpenClose;

	[SerializeField]
	private GameObject m_goMoveUIRoot;

	[SerializeField]
	private HomeBannerManager m_sBanner;

	[SerializeField]
	private UILabel m_sPresentNum;

	[SerializeField]
	private GameObject m_goEventQuest;

	[SerializeField]
	private GameObject m_goGachaBadge;

	[SerializeField]
	private UILabel m_sTreasureCompleteNum;

	[SerializeField]
	private GameObject m_goTreasureComplete;

	[SerializeField]
	private MiniRankingScore m_sMiniRankingS;

	private Coroutine m_cAPI;

	private float m_fPrevBGMTime;

	private eMusicID m_ePrevBGMKind;

	private bool m_bGotoShop;

	private SpawnPrefabData m_sCurrentMenu;

	public void Init(ResponseDataCommon common, HomeEnter res, HuntStatus hunt)
	{
	}

	protected override void OnDestroy()
	{
	}

	protected void ReleaseMenu(SpawnPrefabData current)
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	private void DismissEnd()
	{
	}

	public override void Open()
	{
	}

	public override void Close()
	{
	}

	public void OnFloorChange()
	{
	}

	public override void ForceAllClose()
	{
	}

	public void OnInventory()
	{
	}

	public void OnComposite()
	{
	}

	public void OnAlchemy()
	{
	}

	public void OnEventQuest()
	{
	}

	protected override void OnCloseQuest(bool update, int presentNum, bool gotoShop)
	{
	}

	public override void UpdatePresentBadge()
	{
	}

	public override void UpdateQuestBadge()
	{
	}

	public void UpdateTreasureBadge(HuntStatus stat)
	{
	}

	public void OnOpenShop()
	{
	}

	public void OnOpenGacha()
	{
	}

	public void RestartGachaDirection()
	{
	}

	public void OnOpenPresent()
	{
	}

	public void OnOpenNews()
	{
	}

	public void OnRanking()
	{
	}

	public override void OnProduct()
	{
	}

	public void OnGotoField()
	{
	}

	[DebuggerHidden]
	private IEnumerator API_GateInfo()
	{
		return null;
	}

	public void OnPartyMenu()
	{
	}

	public void OnCloseParty()
	{
	}

	public void OnOtherMenu()
	{
	}

	private void OnCharaEditExit(bool update)
	{
	}

	public void OnFairyPick(Action<InventoryList> onClose)
	{
	}

	public void OnTreasure()
	{
	}

	public void OnContainer()
	{
	}

	public void OnMissionWindow()
	{
	}

	private void UpdateMiniRanking(MiniRankingInfo mri = null)
	{
	}

	public void SetMiniRanking(int sorce)
	{
	}

	private void UpdateDegree(DegreeInfo di)
	{
	}
}
