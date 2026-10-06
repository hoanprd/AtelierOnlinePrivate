using System;
using System.Collections.Generic;
using UnityEngine;

public class DialogSelectPaymentKind : UIWindowBase
{
	[SerializeField]
	private UIScrollView m_sScrollView;

	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private DialogSelectPaymentKindItem m_sPrefab;

	private List<DialogSelectPaymentKindItem> m_vListItem;

	private ShopComInfo.ShopSellInfo m_sSelect;

	private Action<ShopComInfo.ShopSellInfo> m_sOnSelect;

	public void Init(ShopComInfo.ShopSellInfo[] list, Action<ShopComInfo.ShopSellInfo> onSelect)
	{
	}

	public void OnDecide(DialogSelectPaymentKindItem target)
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public static DialogSelectPaymentKind Create()
	{
		return null;
	}
}
