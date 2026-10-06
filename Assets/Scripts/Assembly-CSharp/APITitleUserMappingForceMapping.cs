public class APITitleUserMappingForceMapping : APISimple
{
	public class Request
	{
		public string sno;

		public long user_id;
	}

	public Request m_sRequest;

	public string Sno
	{
		set
		{
		}
	}

	public long UserId
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
