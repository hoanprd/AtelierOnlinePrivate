public class APIExploreRoomInfo : MsgPackAPICommon<ExploreRoomInfoResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int DF
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
