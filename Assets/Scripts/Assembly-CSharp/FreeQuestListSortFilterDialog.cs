using System;
using System.Collections.Generic;
using UnityEngine;

public class FreeQuestListSortFilterDialog : UIWindowBase
{
	[SerializeField]
	private List<UIToggle> m_vOrderToggle;

	[SerializeField]
	private List<UIToggle> m_vSortToggle;

	[SerializeField]
	private List<UIToggle> m_vRewardFilterToggle;

	[SerializeField]
	private List<UIToggle> m_vQuestTypeFilterToggle;

	[SerializeField]
	private List<UIToggle> m_vConditionFilterToggle;

	[SerializeField]
	private UILabel m_sRewardFilterAllButton;

	[SerializeField]
	private UILabel m_sQuestTypeFilterAllButton;

	[SerializeField]
	private UILabel m_sConditionFilterAllButton;

	private EOrder m_eOrderKind;

	private EFreeQuestSort m_eSortKind;

	private ERewardTypeKind m_eRewardFilterKind;

	private EQuestTypeFilterKind m_eQuestTypeFilterKind;

	private EQuestConditionKind m_eConditionFilterKind;

	private Action m_sOnCloseEvent;

	public EOrder OrderKind
	{
		get
		{
			return EOrder.eASC;
		}
	}

	public EFreeQuestSort SortKind
	{
		get
		{
			return EFreeQuestSort.eRWD_ETHER;
		}
	}

	public ERewardTypeKind RewardFilterKind
	{
		get
		{
			return ERewardTypeKind.eNONE;
		}
	}

	public EQuestTypeFilterKind QuestTypeFilterKind
	{
		get
		{
			return EQuestTypeFilterKind.eNONE;
		}
	}

	public EQuestConditionKind ConditionFilterKind
	{
		get
		{
			return EQuestConditionKind.eNONE;
		}
	}

	public void ResetInfo()
	{
	}

	public void Init(Action onCloseEvent)
	{
	}

	private void InitAllToggle()
	{
	}

	private void UpdateAllButtunState()
	{
	}

	public override void OnClose()
	{
	}

	public void OnChangeSortOrder(UIToggle toggle)
	{
	}

	public void OnChangeSortKind(UIToggle toggle)
	{
	}

	public void OnChangeRewardFilterKind(UIToggle toggle)
	{
	}

	public void OnChangeQuestTypeFilterKind(UIToggle toggle)
	{
	}

	public void OnChangeConditionFilterKind(UIToggle toggle)
	{
	}

	public void OnClickRewarFilterKindAll()
	{
	}

	public void OnClickQuestTypeFilterKindAll()
	{
	}

	public void OnClickConditionFilterKind()
	{
	}
}
