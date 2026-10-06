public class APITitleUserOauth : APISimple
{
	public class Request
	{
		public long USER_ID;

		public string TKN;

		public int TYPE;

		public int PLATFORM;
	}

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
