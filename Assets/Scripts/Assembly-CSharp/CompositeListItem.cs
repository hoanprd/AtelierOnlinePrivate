using System.Collections.Generic;
using UnityEngine;

public class CompositeListItem : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_goInventoryPrefab;

	[SerializeField]
	protected GameObject m_goKindPrefab;

	[SerializeField]
	protected UIGrid m_sGrid;

	protected List<CompositeInventoryItem> m_vInventoryList;

	protected List<CompositeKindItem> m_vKindList;

	public const int ciITEM_MAX = 6;

	public void Reset()
	{
	}

	public void UpdateSelect(List<InventoryInfo> selection)
	{
	}

	public void SetEnableSelect(bool enable)
	{
	}

	public void SetEnableTouch(bool enable)
	{
	}

	public void InitInventory(List<InventoryInfo> list, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}

	public void InitInventory(List<CompositeMaterial> list, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}

	public void InitKind(List<int> kindList, List<InventoryInfo> list)
	{
	}
}
