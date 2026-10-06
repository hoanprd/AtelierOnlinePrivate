using System;
using System.Collections.Generic;

[Serializable]
public class ActiveSkillBase : MasterRecordIdBase
{
	[Serializable]
	public class SkillState
	{
		public int id;

		public float rate;
	}

	[Serializable]
	public class DfBean
	{
		public int df;
	}

	public string name;

	public string detail;

	public EBattleAttribute attribute;

	public EBattleType type;

	public EBattleEffectTrigger trigger;

	public EBattleEffectKind effect;

	public float effectValue;

	public float effectValue2;

	public EBattleEffectTarget effectTarget;

	public List<SkillState> state;

	public List<SkillState> stateOwn;

	public int targetTeam;

	public EBattleTargetAreaDefine targetScope;

	public int element;

	public bool shield;

	public float spAdd;

	public int coolTime;

	public string iconPath;

	public int overrideID;

	public int markID;

	public int skillLV;

	public int rarity;

	public int category;

	public int specialVoiceID;

	public List<int> enemyList;

	public List<DfBean> enemyListJ;

	public List<DfBean> combSkillListJ;

	public ActiveSkillBase()
	{
	}

	public ActiveSkillBase(ActiveSkillBase baseSkill)
	{
	}

	public void DeepCopy(ActiveSkillBase baseSkill)
	{
	}

	protected virtual bool IsEquiped(ESubCategory kind, List<InventoryInfo> inv)
	{
		return false;
	}

	protected virtual bool IsEnable(List<InventoryInfo> inv)
	{
		return false;
	}

	public virtual EquipParam GetParam(List<InventoryInfo> inv = null)
	{
		return null;
	}

	public virtual EquipRate GetRate(List<InventoryInfo> inv = null)
	{
		return null;
	}

	public bool IsSameKind(ActiveSkillBase target)
	{
		return false;
	}
}
