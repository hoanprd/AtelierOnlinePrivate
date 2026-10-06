using System.Collections.Generic;
using UnityEngine;

public class EquipWeaponElementInfo : MonoBehaviour
{
	[SerializeField]
	private UISprite m_sCategory;

	[SerializeField]
	private UISprite m_sElement;

	public void Init(EquipData equip, List<InventoryInfo> invOthers = null)
	{
	}

	public void Init(int weaponDF, int quality = 0)
	{
	}
}
