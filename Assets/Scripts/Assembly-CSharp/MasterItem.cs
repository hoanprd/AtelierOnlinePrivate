using System;
using System.Collections.Generic;

[Serializable]
public class MasterItem : MasterRecordDFBase
{
	[Serializable]
	public class SkillParam
	{
		public int DF;

		public int VAL;
	}

	[Serializable]
	public class ItemSkillSet
	{
		public int THR;

		public List<SkillParam> SKILL;
	}

	[Serializable]
	public class ResoItem
	{
		public int DF;

		public int CNT;
	}

	[Serializable]
	public class ResoInfo
	{
		public int MN;

		public ResoItem[] ITEM;
	}

	[Serializable]
	public class RecipeInfo
	{
		public int NO;

		public int DF;

		public int NC;
	}

	[Serializable]
	public class AlterInfo
	{
		public int CST;

		public int LV;

		public int EXP;
	}

	[Serializable]
	public class Equ_gnd
	{
		public int GEN;

		public int ENB;
	}

	[Serializable]
	public class CalcParam
	{
		public Formula EB;

		public Formula SATK;

		public Formula SDEF;

		public Formula MATK;

		public Formula MDEF;

		public Formula SPD;

		public Formula SDA;

		public Formula LDA;

		public Formula QTH;

		public Formula DDG;

		public Formula SADD;

		public Formula RST_SLP;

		public Formula RST_PSN;

		public Formula RST_BRN;

		public Formula RST_FRZ;

		public Formula RST_PRZ;

		public Formula RST_DRK;

		public Formula RST_SLN;

		public Formula RST_CUS;

		public Formula RST_SLW;

		public Formula RST_STN;
	}

	[Serializable]
	public class Ceil_Item
	{
		public int DF;

		public int CNT;

		public int QTY;
	}

	[Serializable]
	public class LegendRecipe_Chara
	{
		public int DF;
	}

	public int CATEG;

	public int GEN;

	public int PRIO;

	public string KANA;

	public int ICON;

	public string NAME;

	public string DESC;

	public int MDL;

	public List<ItemSkillSet> SPC;

	public ResoInfo RST;

	public int RAR;

	public int EQU_BRD;

	public List<RecipeInfo> RSP;

	public AlterInfo ALT;

	public CalcParam EQU;

	public List<Equ_gnd> EQU_GND;

	public ElementPower ELM;

	public List<EJobKind> JOB;

	public EWeaponKind WPN_KIND;

	public int GROUP_DF;

	public List<Ceil_Item> CEIL_RWD_ITEM;

	public eRecipeType RCP_TYPE;

	public List<LegendRecipe_Chara> LRCP_CHARA;

	public bool IsEnableOK(eRaceKind kind)
	{
		return false;
	}

	public bool IsCharaUsable(int df)
	{
		return false;
	}

	public bool IsDedicatedEqu()
	{
		return false;
	}

	public EquipParam GetParam(int lv)
	{
		return null;
	}

	public bool ExistsCeilItem()
	{
		return false;
	}

	public EquipParam GetSubParam(int lv)
	{
		return null;
	}

	private int Calc(int lv, Formula formula)
	{
		return 0;
	}

	public int GetNeedEXP(int lv)
	{
		return 0;
	}

	public int GetNeedLV(int exp)
	{
		return 0;
	}

	public ItemSkillSet GetSkill(int quality)
	{
		return null;
	}

	public List<ActiveSkill> GetSkillList(int quality)
	{
		return null;
	}

	public List<ActiveSkill> GetSkillList(ItemSkillSet skillset)
	{
		return null;
	}

	public bool Is2HandWeapon()
	{
		return false;
	}

	public int GetEXP(int alterLV)
	{
		return 0;
	}
}
