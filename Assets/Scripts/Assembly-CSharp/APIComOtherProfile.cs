public class APIComOtherProfile : MsgPackAPICommon<FriendProfileResponse>
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
