using System.Collections.Generic;

public class APIBattleFinish : MsgPackAPICommon<BattleFinishResponse>
{
	public class Request
	{
		public class UseItem
		{
			public long ID;
		}

		public class KillEnemy
		{
			public long NO;
		}

		public class UseSkill
		{
			public class TargetSkill
			{
				public int[] NO;

				public TargetSkill(int[] no)
				{
				}
			}

			public int CHARADF;

			public int SKILLDF;

			public TargetSkill ENMTGT;
		}

		public class Score
		{
			public int FACTOR;

			public long SCORE;
		}

		public int BT;

		public KillEnemy[] KD;

		public UseItem[] US;

		public int SKL_ACT_CNT;

		public int SKL_L_CNT;

		public List<UseSkill> USSKL;

		public Score SCR;

		public int BA_USG_CNT;

		public int EXTRA_FLAG;
	}

	private Request m_sRequest;

	public int BattleID
	{
		set
		{
		}
	}

	public int[] KillEnemy
	{
		set
		{
		}
	}

	public long[] UseItem
	{
		set
		{
		}
	}

	public int SkillCount
	{
		set
		{
		}
	}

	public int SkillChainCount
	{
		set
		{
		}
	}

	public List<Request.UseSkill> USSKL
	{
		set
		{
		}
	}

	public int[] SCR
	{
		set
		{
		}
	}

	public int BA_USG_CNT
	{
		set
		{
		}
	}

	public int ExtraQuest
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
