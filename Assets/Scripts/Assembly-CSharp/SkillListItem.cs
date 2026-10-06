using UnityEngine;

public class SkillListItem : MonoBehaviour
{
	public UISprite m_sCategoryIcon;

	public UILabel m_sName;

	public GameObject m_goNone;

	public GameObject m_goNoneSpecial;

	public EquipSkillList m_sList;

	public EquipSkillItem m_sSpecialSkill;

	public SkillMark m_sSpecialSkillMark;

	protected InventoryInfo m_sInventory;

	public void Init(InventoryInfo inv)
	{
	}
}
