using UnityEngine;

public class EquipmentSelectInfo : MonoBehaviour
{
	[SerializeField]
	private EquipSkillList m_sSkillList;

	[SerializeField]
	private EquipSkillItem m_sSpecialSkill;

	[SerializeField]
	private GameObject m_goSpecialSkillNone;

	[SerializeField]
	private SkillMark m_sSpecialSkillMark;

	public void Init(InventoryInfo inventory)
	{
	}
}
