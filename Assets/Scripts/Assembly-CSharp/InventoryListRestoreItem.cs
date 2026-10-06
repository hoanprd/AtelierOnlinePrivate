using System.Collections.Generic;
using UnityEngine;

public class InventoryListRestoreItem : MonoBehaviour
{
	[SerializeField]
	private Transform m_trRestoreItemRoot;

	[SerializeField]
	private Transform m_trOrgItemRoot;

	private ItemBar m_sOrgItem;

	private ItemBar m_sRestoreItem;

	private void Awake()
	{
	}

	public void Init(InventoryInfo inv, List<InventoryInfo> select)
	{
	}
}
