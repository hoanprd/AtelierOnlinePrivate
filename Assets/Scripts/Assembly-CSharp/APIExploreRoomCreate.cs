public class APIExploreRoomCreate : MsgPackAPICommon<ExploreRoomCreateResponse>
{
	public class Request
	{
		public string PHO;

		public int DF;
	}

	private Request m_sRequest;

	public string RoomName
	{
		set
		{
		}
	}

	public int FieldID
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
