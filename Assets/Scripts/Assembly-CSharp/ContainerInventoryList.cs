using System;
using System.Collections.Generic;
using UnityEngine;

public class ContainerInventoryList : UIWrapListBase
{
	[Serializable]
	public class BoxInfo
	{
		public UISprite sIcon;

		public UILabel sName;
	}

	[SerializeField]
	protected int m_iLineNum;

	[SerializeField]
	protected GameObject m_goRuckMark;

	[SerializeField]
	protected GameObject m_goContainerMark;

	[SerializeField]
	protected UILabel m_sBoxName;

	[SerializeField]
	protected UILabel m_sItemNum;

	[SerializeField]
	protected BoxInfo m_sInfo;

	protected int m_iBoxKind;

	protected List<InventoryInfo> m_vDispList;

	[SerializeField]
	protected Transform m_trSortWindowRoot;

	[SerializeField]
	protected UILabel m_sFilterName;

	[SerializeField]
	protected SortStateInfo m_sSortState;

	private SortFilterWindow m_sSortWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	public int BoxKind
	{
		get
		{
			return 0;
		}
	}

	public int BoxSelectLimit
	{
		get
		{
			return 0;
		}
	}

	public string BoxName
	{
		get
		{
			return null;
		}
	}

	public virtual void Init(int kind)
	{
	}

	public void SetKind(int kind)
	{
	}

	public void OnExpansion()
	{
	}

	private void OnExpansionFinish(InventoryEnlargeResponse res)
	{
	}

	private void UpdateItemNum()
	{
	}

	private List<InventoryInfo> GetItemList()
	{
		return null;
	}

	protected virtual void InitItemBar(ItemBar target, InventoryInfo inv)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	private void OnDetail(ItemBar target)
	{
	}

	private void LoadSort()
	{
	}

	protected virtual void OnSortDecide(bool update)
	{
	}

	private void MakeDispList()
	{
	}

	public void OnFilter()
	{
	}

	public void OnSort()
	{
	}
}
