using System;
using System.Collections.Generic;

[Serializable]
public class BattleFinish
{
	[Serializable]
	public class EnemySpot
	{
		public int NO;

		public string RP;

		public int KILL;
	}

	[Serializable]
	public class UpdateQuest
	{
		[Serializable]
		public class Acheive
		{
			public string NAME;
		}

		public Acheive[] ACH;
	}

	[Serializable]
	public class SkillEffect
	{
		public int CHARADF;

		public int SKILLDF;

		public BattleFinish EFF;
	}

	[Serializable]
	public class MiniRankingScore
	{
		public int total;

		public int add;

		public double chara;

		public double boost;

		public double reversal;
	}

	public int EXP;

	public int AET;

	public DropItemInfo[] DR;

	public BattleResultCharaInfo[] PT;

	public EnemySpot[] ENS_UP;

	public UpdateQuest QST;

	public List<SkillEffect> SKL;

	public MiniRankingScore MRS;
}
