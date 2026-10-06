using System.Collections.Generic;
using UnityEngine;

public class MasterSkill : MasterListBase<ActiveSkill>
{
	[SerializeField]
	public List<SkillLargeCategRecord> LargeCategoryName;

	[SerializeField]
	public List<SkillCategRecord> CategoryList;
}
