using System.Collections.Generic;
using UnityEngine;

public class GachaMaterialList : UIWindowBase
{
	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private Transform m_trDetailRoot;

	private List<ItemBar> m_vListItem;

	public void Init(ShopGachaLot.LotResult target)
	{
	}

	public void OnDetail(ItemBar target)
	{
	}
}
