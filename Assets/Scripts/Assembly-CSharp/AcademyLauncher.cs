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
		string name = PlayerPrefs.GetString(GameDefine.sKEY_USERNAME, "Wisteria");
		if (m_sPlayerName != null)
		{
			m_sPlayerName.text = name;
		}
		if (m_sPlayerLevel != null)
		{
			m_sPlayerLevel.text = "1";
		}
		if (m_sAnimInOut != null)
		{
			m_sAnimInOut.SetOnEndMethod(gameObject, "DismissEnd");
		}
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}

	protected void ReleaseMenu(SpawnPrefabData current)
	{
		if (m_sCurrentMenu != null)
		{
			m_sCurrentMenu.DestroyObject();
			m_sCurrentMenu = null;
		}
	}

	public void Bringin()
	{
		if (m_sAnimInOut != null)
		{
			m_sAnimInOut.PlayIn();
		}
	}

	public void Dismiss()
	{
		if (m_sAnimInOut != null)
		{
			m_sAnimInOut.PlayOut();
		}
		else
		{
			DismissEnd();
		}
	}

	private void DismissEnd()
	{
		if (m_bGotoShop)
		{
			m_bGotoShop = false;
			OnOpenShop();
		}
	}

	public override void Open()
	{
		Bringin();
	}

	public override void Close()
	{
		Dismiss();
	}

	public void OnFloorChange()
	{
	}

	public override void ForceAllClose()
	{
		Dismiss();
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
		m_bGotoShop = gotoShop;
		Bringin();
	}

	public override void UpdatePresentBadge()
	{
		if (m_sPresentNum != null)
		{
			m_sPresentNum.text = "0";
		}
	}

	public override void UpdateQuestBadge()
	{
	}

	public void UpdateTreasureBadge(HuntStatus stat)
	{
		if (m_goTreasureComplete != null)
		{
			m_goTreasureComplete.SetActive(false);
		}
	}

	public void OnOpenShop()
	{
		if (m_sShop != null)
		{
			m_sCurrentMenu = m_sShop;
			m_sShop.InstantiateObject();
		}
	}

	public void OnOpenGacha()
	{
	}

	public void RestartGachaDirection()
	{
	}

	public void OnOpenPresent()
	{
		if (m_sPresent != null)
		{
			m_sCurrentMenu = m_sPresent;
			m_sPresent.InstantiateObject();
		}
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
		if (Academy_Manager.GetInst() != null)
		{
			Academy_Manager.GetInst().SetChangeMenuRequest(System_MenuManager.eSystemMenuKind.Field);
		}
	}

	[DebuggerHidden]
	private IEnumerator API_GateInfo()
	{
		yield return null;
	}

	public void OnPartyMenu()
	{
	}

	public void OnCloseParty()
	{
		Bringin();
	}

	public void OnOtherMenu()
	{
		if (m_sOtherMenu != null)
		{
			m_sCurrentMenu = m_sOtherMenu;
			m_sOtherMenu.InstantiateObject();
		}
	}

	private void OnCharaEditExit(bool update)
	{
		Bringin();
	}

	public void OnFairyPick(Action<InventoryList> onClose)
	{
		if (m_sFairyPick != null)
		{
			m_sCurrentMenu = m_sFairyPick;
			m_sFairyPick.InstantiateObject();
		}
	}

	public void OnTreasure()
	{
		if (m_sTreasure != null)
		{
			m_sCurrentMenu = m_sTreasure;
			m_sTreasure.InstantiateObject();
		}
	}

	public void OnContainer()
	{
		if (m_sContainer != null)
		{
			m_sCurrentMenu = m_sContainer;
			m_sContainer.InstantiateObject();
		}
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
