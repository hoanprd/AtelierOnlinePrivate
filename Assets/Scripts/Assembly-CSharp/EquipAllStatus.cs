using UnityEngine;

public class EquipAllStatus : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sStatusInfo;

	[SerializeField]
	private UITable m_sTable;

	[SerializeField]
	private EquipSkillList m_sSkill;

	[SerializeField]
	private EquipJobList m_sJob;

	[SerializeField]
	private EquipWeaponList m_sWeapon;

	[SerializeField]
	private EquipParamList m_sParam;

	[SerializeField]
	private EquipParamList m_sElement;

	[SerializeField]
	private GameObject m_sCharaSkill;

	public void Init(int df, int lv, int quality, int trt)
	{
	}

	public void Init(int df, int lv)
	{
	}

	private void Update()
	{
	}
}
