using System;
using System.Collections.Generic;

[Serializable]
public class MasterChara : MasterRecordDFBase
{
	[Serializable]
	public class Skill
	{
		public int DF;

		public int LV;
	}

	[Serializable]
	public class Spec
	{
		public Formula HP;

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
	}

	[Serializable]
	public class Fdm
	{
		[Serializable]
		public class RequestInfo
		{
			public int DF;

			public int QTY;
		}

		public int NO;

		public int GRD;

		public List<RequestInfo> FD;

		public int HP;

		public int SATK;

		public int SDEF;

		public int MATK;

		public int MDEF;

		public int SPD;

		public int SDA;

		public int LDA;

		public int QTH;

		public int DDG;

		public int SADD;
	}

	[Serializable]
	public class Qst
	{
		public int NO;

		public int QUEST_DF;

		public int FLAG_DF;

		public int LV;
	}

	[Serializable]
	public class Wpn
	{
		public int GEN;
	}

	[Serializable]
	public class BlazeArts
	{
		public int LV;

		public int DF;
	}

	[Serializable]
	public class GrowInfo
	{
		public int STAR;

		public int STONE;
	}

	public int CATEG;

	public string NAME;

	public string DESC;

	public int GEN;

	public string ICON;

	public int BTST;

	public int EXC;

	public Skill[] SKILL;

	public Spec SPEC;

	public List<Fdm> FDM;

	public List<Qst> QST;

	public List<Wpn> WEAPON;

	public List<GrowInfo> GROW;

	public CharaModelInfo MDL;

	public List<BlazeArts> BA;

	public int GROUP_DF;

	public List<EXPTable> GetEXPTable(int charaDF)
	{
		return null;
	}

	public bool HasBlazeArts()
	{
		return false;
	}

	public List<int> GetSkillList(int lv)
	{
		return null;
	}

	public CharaSpec GetParam(int lv, int fdm)
	{
		return null;
	}

	public CharaSpec GetParam(int lv)
	{
		return null;
	}

	private int Calc(int lv, Formula formula)
	{
		return 0;
	}
}
