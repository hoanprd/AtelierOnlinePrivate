public class APITitleServerInfo : MsgPackAPICommon<ServerInfoResponse>
{
	public class Request
	{
		public int PLAT;

		public int CV;
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
