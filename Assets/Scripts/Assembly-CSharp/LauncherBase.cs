using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LauncherBase : MonoBehaviour
{
	[SerializeField]
	protected AnimationController m_sAnim;

	[SerializeField]
	protected GameObject m_goBlockCollision;

	[SerializeField]
	protected GameObject m_goGrowBadge;

	[SerializeField]
	protected UILabel m_sMissionBadge;

	[SerializeField]
	protected Transform m_trMissionRoot;

	[SerializeField]
	protected GameObject m_goQuestBadge;

	[SerializeField]
	protected UILabel m_sAlterBadge;

	protected bool m_bOpen;

	protected List<Game_UI_Launcher_SubMenu> m_vsSubMenuList;

	protected MissionManager m_sMissionWindow;

	protected Coroutine m_sCorotine;

	protected GameObject m_goQuestWnd;

	protected QuestListWindow.ETabKind m_eQuestTab;

	private static List<LauncherBase> sLIST;

	public bool IsOpen
	{
		get
		{
			return false;
		}
	}

	public bool IsEndAnimation()
	{
		return false;
	}

	public bool IsDispMission()
	{
		return false;
	}

	public virtual void OnOpenClose()
	{
	}

	protected virtual void OnEnable()
	{
	}

	public virtual void Open()
	{
	}

	public virtual void Close()
	{
	}

	public virtual void ForceAllClose()
	{
	}

	public virtual void OpenSubMenu(Game_UI_Launcher_SubMenu.ELauncherKind kind)
	{
	}

	public virtual bool CloseSubMenu()
	{
		return false;
	}

	protected virtual void InitSubMenu()
	{
	}

	public virtual void UpdateUIActive()
	{
	}

	protected Game_UI_Launcher_SubMenu GetSubMenu(Game_UI_Launcher_SubMenu.ELauncherKind kind)
	{
		return null;
	}

	public void OnOption()
	{
	}

	public void OnMission(Action onClose = null)
	{
	}

	public virtual void OnQuest()
	{
	}

	private void OnQuestFill()
	{
	}

	protected virtual void OnQuestSummary()
	{
	}

	[DebuggerHidden]
	protected virtual IEnumerator LoadQuest(QuestSummary summary, BannerInfo bannerInfo, DegreeMissionInfo[] degree, bool ev)
	{
		return null;
	}

	protected virtual void OnCloseQuest(bool update, int presentNum, bool gotoShop)
	{
	}

	public virtual void UpdateAlterBadge()
	{
	}

	public virtual void UpdateQuestBadge()
	{
	}

	public virtual void UpdateGrowBadge()
	{
	}

	public virtual void UpdateMissionBadge()
	{
	}

	public virtual void UpdatePresentBadge()
	{
	}

	public virtual void OnProduct()
	{
	}

	protected virtual void OnCloseTutorial()
	{
	}

	protected virtual void EndTutorial(eTutorial kind, bool success, bool skip)
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public static void UpdateBadge(bool grow, bool mission, bool present, bool quest, bool alter)
	{
	}
}
