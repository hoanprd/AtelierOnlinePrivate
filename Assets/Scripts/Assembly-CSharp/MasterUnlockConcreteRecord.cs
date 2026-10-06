using System;

[Serializable]
public class MasterUnlockConcreteRecord : MasterRecordDFBase
{
	[Serializable]
	public class Quest
	{
		public int DF;

		public int STS;
	}

	[Serializable]
	public class Recipe
	{
		public int DF;
	}

	[Serializable]
	public class Region
	{
		public int DF;
	}

	[Serializable]
	public class LimitOpen
	{
		public int TYPE;

		public int EXT_VAL;

		public int CH_DF;
	}

	[Serializable]
	public class Dungeon
	{
		public int DF;

		public int DTY;
	}

	[Serializable]
	public class Chara
	{
		public int DF;
	}

	[Serializable]
	public class Title
	{
		public int DF;
	}

	private int CATEG;

	public Quest QUEST;

	public Recipe RECIPE;

	public Region REGION;

	public LimitOpen LIMIT_OPEN;

	public Dungeon DUNGEON;

	public Chara CHARA;

	public Title TITLE;
}
