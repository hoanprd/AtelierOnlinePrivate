using System.Collections.Generic;
using UnityEngine;

public class InventoryListItemBar : MonoBehaviour
{
	[SerializeField]
	private UIGrid m_sGrid;

	private List<ItemBar> m_vList;

	public const int ciITEM_MAX = 6;

	private void Awake()
	{
	}

	public void SetEvent(ItemBarEvent select, ItemBarEvent detail)
	{
	}

	public void Init()
	{
	}

	public void Init(List<InventoryInfo> list, List<InventoryInfo> select, InventoryListManager.EInventoryEditKind mode, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}
}
