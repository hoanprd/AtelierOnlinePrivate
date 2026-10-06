using System.Collections.Generic;
using UnityEngine;

public class CompositeFeedListItem : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_goInventoryPrefab;

	[SerializeField]
	protected UIGrid m_sGrid;

	protected List<CompositeInventoryItem> m_vInventoryList;

	public const int ciITEM_MAX = 3;

	public void Reset()
	{
	}

	public void UpdateSelect(int target, bool enableLevelUp, bool enableLimitbreak, List<long> selection)
	{
	}

	public void UpdateEnableSelect(int target, bool enableLevelUp, bool enableLimitbreak)
	{
	}

	public void InitInventory(int target, bool enableLevelUp, bool enableLimitbreak, List<InventoryInfo> list, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}

	public void InitInventory(int target, bool enableLevelUp, bool enableLimitbreak, List<CompositeMaterial> list, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}

	private void SetBlackFilter(int target, CompositeInventoryItem feed, bool enableLevelUp, bool enableLimitbreak)
	{
	}
}
