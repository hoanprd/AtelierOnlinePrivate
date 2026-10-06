public class APIExploreDungeonFloorCreate : APISimple
{
	public class Request
	{
		public class PosCount
		{
			public int POS;

			public int CNT;
		}

		public class PosInfo
		{
			public PosCount[] SPT;

			public PosCount[] GIM;

			public PosCount[] ENS;
		}

		public int DF;

		public int NO;

		public PosInfo PI;
	}

	private Request m_sRequest;

	public int DungeonID
	{
		set
		{
		}
	}

	public int Floor
	{
		set
		{
		}
	}

	public Request.PosInfo PosInfo
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}
}
