using System;
using System.Collections.Generic;

public class DialogScroll : DialogCommon
{
	public InventoryDedicatedEquListView m_GetItemListView;

	public UILabel m_SellingPriceLabel;

	public static DialogScroll CreateForceYesNODialog(string content, List<InventoryInfo> inv, int value, Action<EButtonKind> callback)
	{
		return null;
	}
}
