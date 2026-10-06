using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ShopComListView : ShopComListBase
{
	[SerializeField]
	protected ShopComDetailWindow m_sDetail;

	[SerializeField]
	private EtherShopSortFilterDialog m_sEtherShopSortFilterDialog;

	[SerializeField]
	private Vector4 m_vNormalScrollViewSize;

	[SerializeField]
	private Vector4 m_vEtherShopScrollViewSize;

	[SerializeField]
	private GameObject m_goEtherShopSortButton;

	[SerializeField]
	private GameObject m_goEtherShopFilterButton;

	[SerializeField]
	private GameObject m_goEtherShopSortButtonOrderSprite;

	[SerializeField]
	private UISprite m_sFilterButtonSprite;

	[SerializeField]
	private GameObject m_goNoneText;

	[SerializeField]
	private Vector3 m_vEtherShopAddArrowPosition;

	private Vector3 m_vNomalAddArrowPosition;

	private const string cs_DEFAULT_SORT_BUTTON_TEXT = "並\ufffd";

	private const string cs_DEFAULT_FILTER_BUTTON_TEXT = "絞\ufffd";

	private bool m_bIsSortSelect;

	private void Awake()
	{
	}

	public void Init(EShopComKind kind, ShopComInfo.Data[] list)
	{
	}

	public override void Dismiss()
	{
	}

	protected override void UpdateDetail()
	{
	}

	public override void UpdateInfo()
	{
	}

	protected override void ReceiveDetailInfo(ShopComItem detail)
	{
	}

	[DebuggerHidden]
	private IEnumerator DispDetail()
	{
		return null;
	}

	private bool IsDispSortFilterBtn(EShopComKind kind)
	{
		return false;
	}

	public void OnEtherShopSort()
	{
	}

	public void OnEtherShopFilter()
	{
	}

	private void UpdateDetailList()
	{
	}

	private void ExecuteEtherShopSortFilter()
	{
	}

	private bool JudgeFilterByRewardKey(ShopComListItem item, List<int> rewardItemCategoryList, ERewardTypeKind reward)
	{
		return false;
	}

	public void Reposition(UIGrid.Sorting sort = UIGrid.Sorting.None, Comparison<Transform> comparison = null)
	{
	}

	private void SetActiveSortFilterButton(bool isEtherShop)
	{
	}

	private void ChangeSortButton()
	{
	}

	private void ChangeFilterButton()
	{
	}

	private void ChangeButtonLabel(string sort, string filter)
	{
	}

	private void AdjustFilterButtonColor(bool isFiltering)
	{
	}
}
