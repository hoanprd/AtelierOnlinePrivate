public class APIBattleAnnihilated : APISimple
{
	public class Request
	{
		public class UseItem
		{
			public long ID;
		}

		public int BT;

		public UseItem[] US;

		public int BA_USG_CNT;
	}

	private Request m_sRequest;

	public int BattleID
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

	public int BA_USG_CNT
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
