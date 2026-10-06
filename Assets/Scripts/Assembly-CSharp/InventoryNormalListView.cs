using System.Collections.Generic;
using UnityEngine;

public class InventoryNormalListView : UIWrapListBase
{
	private List<InventoryInfo> m_vInventories;

	private List<InventoryInfo> m_vSelectInventories;

	private InventoryListManager.EInventoryEditKind m_eEditMode;

	private ItemBarEvent m_sSelectEvent;

	private ItemBarEvent m_sDetailEvent;

	public void SetEvent(InventoryListManager.EInventoryEditKind mode, ItemBarEvent select, ItemBarEvent detail)
	{
	}

	public void Init(List<InventoryInfo> inv, List<InventoryInfo> select)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}
}
