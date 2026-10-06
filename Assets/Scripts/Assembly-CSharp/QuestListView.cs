using System.Collections.Generic;
using UnityEngine;

public class QuestListView : MonoBehaviour
{
	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private UIScrollView m_sScrollView;

	[SerializeField]
	private GameObject m_goTitleListItemPrefab;

	[SerializeField]
	private GameObject m_goListItemPrefab;

	[SerializeField]
	private GameObject m_goNoneText;

	[SerializeField]
	private GameObject m_goEnableQuestNoneText;

	[SerializeField]
	private FreeQuestListSortFilterDialog m_sSortFilterDialog;

	[SerializeField]
	private UISprite m_sFreeQuestSortButtonOrderSprite;

	[SerializeField]
	private GameObject m_sFreeQuestSortButton;

	[SerializeField]
	private GameObject m_sFreeQuestFilterButton;

	[SerializeField]
	private Vector4 m_vFreeQuestScrollViewSize;

	[SerializeField]
	private Vector4 m_vNomalScrollViewSize;

	[SerializeField]
	private UISprite m_sFilterButtonSprite;

	private const string cs_DEFAULT_SORT_BUTTON_TEXT = "\u3000\ufffd";

	private const string cs_DEFAULT_FILTER_BUTTON_TEXT = "絞\ufffd";

	private List<QuestBarRoot> m_vRootList;

	private List<QuestBar> m_vItemList;

	private QuestDetailWindow m_sDetail;

	private QuestBarRoot m_sSelectQuestRoot;

	private QuestBar m_sSelectQuest;

	private int m_iSelectID;

	private DegreeMissionInfo[] m_asDegreeList;

	private List<QuestDetail> m_vList;

	private List<int> m_vRootIDList;

	private List<MasterQuestInfo> m_vMasterList;

	private QuestListWindow.ETabKind m_eKind;

	private int m_iHotChapter;

	public int HotChapter
	{
		set
		{
		}
	}

	public void UpdateInfo()
	{
	}

	public void UpdateBadge()
	{
	}

	public void Init(QuestListWindow.ETabKind kind, List<QuestDetail> list, DegreeMissionInfo[] degree)
	{
	}

	private QuestBar GetQuestBar()
	{
		return null;
	}

	private QuestDetail GetActiveQuest(QuestListWindow.ETabKind kind)
	{
		return null;
	}

	private void CreateList(QuestListWindow.ETabKind kind)
	{
	}

	private void OnSelectRoot(QuestBarRoot target, bool force)
	{
	}

	public void OnSelectQuest(QuestBar target)
	{
	}

	public void OnSortFilter()
	{
	}

	private void ExecuteSortFilter()
	{
	}

	private bool JudgeFilterByRewardKey(QuestBar bar, List<int> rewardList, ERewardTypeKind reward)
	{
		return false;
	}

	private bool JudgeFilterByQuestTypeKey(QuestBar bar, List<int> typeList, EQuestTypeFilterKind type)
	{
		return false;
	}

	private bool JudgeFilterByConditionKey(QuestBar bar, List<int> conditionList, EQuestConditionKind condition)
	{
		return false;
	}

	private void ProcessQuestBarForSort(QuestBar bar, EFreeQuestSort sort, EOrder order)
	{
	}

	private QuestDetailWindow LoadDetailWindow()
	{
		return null;
	}

	private void SetActiveSortFilterButton(bool isFreeQuest)
	{
	}

	private void ChangeButtonLabel()
	{
	}

	private void SetFilterButtonColor(bool highlight)
	{
	}

	private void ChangeButtonLabel(string sort, string filter)
	{
	}

	private void OnDisable()
	{
	}
}
