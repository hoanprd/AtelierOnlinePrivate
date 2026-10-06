using System;
using System.Collections.Generic;

[Serializable]
public class ActiveSkill : ActiveSkillBase
{
	public List<ActiveSkillBase> combSkillList;

	public ActiveSkill()
	{
	}

	public ActiveSkill(ActiveSkillBase baseSkill)
	{
	}

	public bool IsSameKind(ActiveSkill target)
	{
		return false;
	}

	public override EquipParam GetParam(List<InventoryInfo> inv = null)
	{
		return null;
	}

	public override EquipRate GetRate(List<InventoryInfo> inv = null)
	{
		return null;
	}

	public bool IsIncludeEffectKind(EBattleEffectKind kind)
	{
		return false;
	}

	public List<ActiveSkillBase> GetEffectKind(EBattleEffectKind kind)
	{
		return null;
	}
}
