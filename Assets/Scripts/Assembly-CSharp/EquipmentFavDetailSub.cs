using System.Collections.Generic;
using UnityEngine;

public class EquipmentFavDetailSub : MonoBehaviour
{
	public UILabel m_sName;

	public UILabel m_sTotalPower;

	public UIGrid m_sGrid;

	public UIScrollView m_sScrollView;

	public EquipmentSubListItem m_sPrefab;

	private List<EquipmentSubListItem> m_vSubEquipList;

	private EquipFavoSubInfo m_sData;

	public EquipFavoSubInfo Data
	{
		get
		{
			return null;
		}
	}

	public void Init(EquipFavoSubInfo set, List<InventoryInfo> inv, int max)
	{
	}
}
