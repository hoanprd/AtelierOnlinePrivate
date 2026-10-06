using System.Collections.Generic;
using UnityEngine;

public class ItemSelectPage : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_goKindPrefab;

	[SerializeField]
	protected UIGrid m_sGrid;

	protected List<ItemBar> m_vInventoryList;

	protected List<ItemSelectPageKindItem> m_vKindList;

	public const int ciITEM_MAX = 6;

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	public void UpdateSelect(List<InventoryInfo> selection)
	{
	}

	public void UpdateSelectKind(List<int> selection)
	{
	}

	public void InitInventory(List<InventoryInfo> list, List<InventoryInfo> selection, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}

	public void InitKind(List<long> kindList, List<InventoryInfo> list, List<int> selection)
	{
	}
}
