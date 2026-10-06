public class APIComFriendSearch : MsgPackAPICommon<FriendSearchResponse>
{
	public class Request
	{
		public long TID;
	}

	private Request m_sRequest;

	public long ID
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
