using System.Collections.Generic;
using UnityEngine;

public class ContainerInventorySorceList : ContainerInventoryList
{
	[SerializeField]
	private UILabel m_sSelectNum;

	private List<long> m_vSelectList;

	private int m_iDispSelectNum;

	[SerializeField]
	private UILabel m_sAllButton;

	public List<long> SelectList
	{
		get
		{
			return null;
		}
	}

	public override void Init(int kind)
	{
	}

	private void UpdateSelectNum()
	{
	}

	protected override void InitItemBar(ItemBar target, InventoryInfo inv)
	{
	}

	public void OnSelect(ItemBar target)
	{
	}

	protected override void OnSortDecide(bool update)
	{
	}

	public void OnSelectAll()
	{
	}
}
