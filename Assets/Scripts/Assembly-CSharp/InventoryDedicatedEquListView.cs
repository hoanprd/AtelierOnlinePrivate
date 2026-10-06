using System.Collections.Generic;
using UnityEngine;

public class InventoryDedicatedEquListView : UIWrapListBase
{
	private List<InventoryInfo> m_vInventories;

	private List<InventoryInfo> m_vSelectInventories;

	private InventoryListManager.EInventoryEditKind m_eEditMode;

	private ItemBarEvent m_sSelectEvent;

	private ItemBarEvent m_sDetailEvent;

	private ItemDetailWindow m_sItemDetailWindow;

	[SerializeField]
	private Transform m_trItemDetailRoot;

	private ItemBar m_sDetailTarget;

	public void SetEvent(InventoryListManager.EInventoryEditKind mode, ItemBarEvent select, ItemBarEvent detail)
	{
	}

	public void Init(List<InventoryInfo> inv)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	public void OnSelect(ItemBar item)
	{
	}

	public void OnDetail(ItemBar inventory)
	{
	}

	private void OnCloseDetail(InventoryList addInventory, int updateFav, int gotoAlter)
	{
	}
}
