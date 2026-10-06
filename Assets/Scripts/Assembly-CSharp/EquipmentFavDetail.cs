using System.Collections.Generic;
using UnityEngine;

public class EquipmentFavDetail : MonoBehaviour
{
	public Transform[] m_trRoot;

	public UILabel m_sName;

	public UILabel m_sTotalPower;

	[SerializeField]
	private GameObject m_sTotalPowerRoot;

	private ItemDetailEquipmentMini[] m_asEquipList;

	private EquipFavoInfo m_sData;

	public EquipFavoInfo Data
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Init(EquipFavoInfo set, List<InventoryInfo> inv, EEquipKind kind)
	{
	}
}
