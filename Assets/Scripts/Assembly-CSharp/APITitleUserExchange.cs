public class APITitleUserExchange : MsgPackAPICommon<TitleUserCreateResponse>
{
	public class Request
	{
		public long USER_ID;
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
