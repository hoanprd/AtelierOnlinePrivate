public class APITitleUserCancel : APISimple
{
	public class Request
	{
		public long USER_ID;

		public string GUID;

		public string TKN;

		public int TYPE;
	}

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
