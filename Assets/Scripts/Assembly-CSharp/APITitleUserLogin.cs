public class APITitleUserLogin : APISimple
{
	public class Request
	{
		public long ID;

		public string GUID;

		public int CV;
	}

	public Request m_sRequest;

	public override byte[] GetAPI()
	{
		return null;
	}

	public override string Analysis(byte[] msgpack)
	{
		return null;
	}
}
