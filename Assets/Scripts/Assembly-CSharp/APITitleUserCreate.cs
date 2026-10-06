public class APITitleUserCreate : MsgPackAPICommon<TitleUserCreateResponse>
{
	public class Request
	{
		public string GUID;

		public int PLAT;

		public int CV;

		public string NA;

		public int GEN;

		public int OAUTH;
	}

	public Request m_sRequest;

	public string UserName
	{
		set
		{
		}
	}

	public int Genger
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}

	public override void PostProcess()
	{
	}
}
