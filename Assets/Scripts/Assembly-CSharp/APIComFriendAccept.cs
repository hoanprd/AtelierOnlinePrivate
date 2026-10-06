public class APIComFriendAccept : APISimple
{
	public class Request
	{
		public class Target
		{
			public long ID;
		}

		public Target[] TRG;
	}

	private Request m_sRequest;

	public long[] Target
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
