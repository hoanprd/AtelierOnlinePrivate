using System.Collections.Generic;
using UnityEngine;

public class EquipmentSelectGrid : MonoBehaviour
{
	public UIGrid m_sGrid;

	public GameObject m_goPrefab;

	private List<EquipmentSelectItem> m_vList;

	public const int ciITEM_NUM = 3;

	public void CreateList()
	{
	}

	public void InitSelect(long selectID, long prev)
	{
	}

	public void Init(List<InventoryInfo> inv, long prev, int charaLV)
	{
	}
}
