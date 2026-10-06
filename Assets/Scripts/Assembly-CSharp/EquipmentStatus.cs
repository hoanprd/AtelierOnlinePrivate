using System.Collections.Generic;

public class EquipmentStatus : EquipmentBase
{
	private enum EInfoKind
	{
		eNORMAL = 0,
		eELEMENT = 1,
		eNUM = 2
	}

	public UILabel m_sLevel;

	public EquipWeaponList m_sEnableWeapon;

	public EquipmentParamList m_sParam;

	public EquipmentElementList m_sElementParam;

	public EquipmentSkillList m_sSkillList;

	public UILabel m_sStatusKind;

	private CharaDetail m_sDetail;

	private EInfoKind m_eInfoKind;

	public void Init()
	{
	}

	public void SwitchInfoKind()
	{
	}

	private void InitDisp()
	{
	}

	public void Init(CharaDetail chara)
	{
	}

	public void Change(CharaDetail equip, InventoryInfo select)
	{
	}

	private void InitActiveSkill(List<ActiveSkill> skillList)
	{
	}

	private void InitElementSkill(List<ActiveSkill> skillList)
	{
	}
}
