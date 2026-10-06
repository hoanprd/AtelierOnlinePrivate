public class APIExploreDungeonFloorEnter : MsgPackAPICommon<DungeonFieldDataResponse>
{
	public class Request
	{
		public int DF;

		public int NO;
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

	public override byte[] GetAPI()
	{
		return null;
	}

	public override string Analysis(byte[] msgpack)
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
