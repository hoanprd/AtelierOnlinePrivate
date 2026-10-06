public class APIExploreDungeonFloorInfo : MsgPackAPICommon<DungeonFloorInfoResponse>
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
}
