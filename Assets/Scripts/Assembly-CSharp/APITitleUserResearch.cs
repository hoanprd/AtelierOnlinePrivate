public class APITitleUserResearch : MsgPackAPICommon<TitleUserCreateResponse>
{
	public class Request
	{
		public long USER_ID;

		public string GUID;

		public string TKN;

		public int TYPE;
	}

	public Request m_sRequest;

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
