using System.Collections.Generic;
using UnityEngine;

public class EquipSkillList : UIListViewBase<EquipSkillItem>
{
	[SerializeField]
	private GameObject m_goNoneText;

	private List<ActiveSkill> m_vSkillList;

	public void InitNone()
	{
	}

	public void Init(List<ActiveSkill> list)
	{
	}

	public void Diff(List<ActiveSkill> list)
	{
	}
}
