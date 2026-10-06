public class APIComProfileTakeoverTakeover : APISimple
{
	public class Request
	{
		public string sno;

		public long user_id;

		public string takeover_cd;
	}

	public Request m_sRequest;

	public string TakeoverCode
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

	public string Sno
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
