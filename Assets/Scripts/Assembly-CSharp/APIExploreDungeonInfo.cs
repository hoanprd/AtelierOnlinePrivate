public class APIExploreDungeonInfo : MsgPackAPICommon<DungeonInfoResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int DungeonID
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
