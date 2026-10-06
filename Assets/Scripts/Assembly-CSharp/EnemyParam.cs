using System;

[Serializable]
public class EnemyParam
{
	[Serializable]
	public class Elm
	{
		public int DF;

		public int ATK;

		public int DEF;
	}

	[Serializable]
	public class Skill
	{
		public int DF;
	}

	[Serializable]
	public class Spec
	{
		public Formula EXP;

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

	public string MDL;

	public string NAME;

	public string DESC;

	public ElementPower ELM;

	public Skill[] SKILL;

	public Spec SPEC;

	public CharaSpec GetParam(int lv)
	{
		return null;
	}

	private int Calc(int lv, Formula formula)
	{
		return 0;
	}
}
