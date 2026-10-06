using System.Collections.Generic;
using UnityEngine;

public class EquipmentSpecialSkillList : UIListViewBase<EquipSkillItem>
{
	[SerializeField]
	private GameObject m_goNoneLabel;

	public void Init(CharaDetail detail, List<InventoryInfo> inv)
	{
	}
}
