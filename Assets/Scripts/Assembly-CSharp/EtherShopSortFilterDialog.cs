using System;
using System.Collections.Generic;
using UnityEngine;

public class EtherShopSortFilterDialog : UIWindowBase
{
	[SerializeField]
	private List<UIToggle> m_vSortToggle;

	[SerializeField]
	private List<UIToggle> m_vOrderToggle;

	[SerializeField]
	private List<UIToggle> m_vRewardFilterToggle;

	[SerializeField]
	private GameObject m_goSortRoot;

	[SerializeField]
	private GameObject m_goFilterRoot;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UILabel m_sRewardFilterAllButtonLabel;

	private EOrder m_eOrderKind;

	private EEtherShopSort m_eSortKind;

	private ERewardTypeKind m_eRewardFilterKind;

	private Action m_sOnCloseEvent;

	public EOrder OrderKind
	{
		get
		{
			return EOrder.eASC;
		}
	}

	public EEtherShopSort SortKind
	{
		get
		{
			return EEtherShopSort.ePRODUCT_NAME;
		}
	}

	public ERewardTypeKind RewardFilterKind
	{
		get
		{
			return ERewardTypeKind.eNONE;
		}
	}

	private void Awake()
	{
	}

	public void Refresh()
	{
	}

	public void InitSort(Action onCloseEvent)
	{
	}

	public void InitFilter(Action onCloseEvent)
	{
	}

	private void UpdateAllButtonState()
	{
	}

	public override void OnClose()
	{
	}

	public void OnChangeSortKind(UIToggle toggle)
	{
	}

	public void OnChangeOrderKind(UIToggle toggle)
	{
	}

	public void OnChangeRewardFilterKind(UIToggle toggle)
	{
	}

	public void OnClickRewardFilterKindAll()
	{
	}
}
