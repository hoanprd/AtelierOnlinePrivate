using System.Collections.Generic;
using UnityEngine;

public class EquipmentFavListItemSub : MonoBehaviour
{
	public UILabel m_sName;

	public UILabel m_sTotalPower;

	public UILabel m_sRegisterCount;

	private EquipFavoSubInfo m_sInfo;

	public EquipFavoSubInfo Info
	{
		get
		{
			return null;
		}
	}

	public void Init(EquipFavoSubInfo set, List<InventoryInfo> inv)
	{
	}
}
