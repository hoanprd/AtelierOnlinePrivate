using System;
using System.Collections.Generic;
using UnityEngine;

public class ExqRoomListView : MonoBehaviour
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

	private List<ExqRoomBar> m_vItemList;

	private ExqRoomDetailWindow m_sDetail;

	private Action m_saEnterRoomEvent;

	private ExqRoomBar m_sSelectQuest;

	private int m_iSelectID;

	private DegreeMissionInfo[] m_asDegreeList;

	private List<QuestDetail> m_vQuestDetailList;

	private List<RoomInfo> m_vList;

	private List<int> m_vRootIDList;

	private List<MasterQuestInfo> m_vMasterList;

	private int m_iHotChapter;

	public RoomInfo SelectRoomInfo
	{
		get
		{
			return null;
		}
	}

	public int HotChapter
	{
		set
		{
		}
	}

	public void UpdateInfo()
	{
	}

	public void Init(List<QuestDetail> list, DegreeMissionInfo[] degree, Action onEnterRoomEvent)
	{
	}

	private ExqRoomBar GetRoomBar()
	{
		return null;
	}

	private void CreateList()
	{
	}

	public void OnSelectQuest(ExqRoomBar target)
	{
	}

	public void OnSortFilter()
	{
	}

	private void ExecuteSortFilter()
	{
	}

	private bool JudgeFilterByRewardKey(ExqRoomBar bar, List<int> rewardList, ERewardTypeKind reward)
	{
		return false;
	}

	private bool JudgeFilterByQuestTypeKey(ExqRoomBar bar, List<int> typeList, EQuestTypeFilterKind type)
	{
		return false;
	}

	private bool JudgeFilterByConditionKey(ExqRoomBar bar, List<int> conditionList, EQuestConditionKind condition)
	{
		return false;
	}

	private void ProcessQuestBarForSort(ExqRoomBar bar, EFreeQuestSort sort, EOrder order)
	{
	}

	private ExqRoomDetailWindow LoadDetailWindow()
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
