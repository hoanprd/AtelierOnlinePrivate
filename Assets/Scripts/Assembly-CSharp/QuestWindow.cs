using System;
using UnityEngine;

public class QuestWindow : MonoBehaviour
{
	private static bool isExtraQuest;

	[SerializeField]
	private QuestListWindow m_sList;

	[SerializeField]
	private QuestSingleWindow m_sSingle;

	public const string csPREFAB_PATH = "UI/UI_Quest/UI_QuestBoard_Root";

	public static bool IsExtraQuest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public void Init(QuestSummary summary, BannerInfo bannerInfo, DegreeMissionInfo[] degree, Action<bool, int, bool> onExit = null, QuestListWindow.ETabKind tab = QuestListWindow.ETabKind.eAUTO)
	{
	}

	public void Init(QuestDetail quest)
	{
	}

	public static QuestWindow Create(Transform root)
	{
		return null;
	}
}
