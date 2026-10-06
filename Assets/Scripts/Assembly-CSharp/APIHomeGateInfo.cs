public class APIHomeGateInfo : MsgPackAPICommon<GateInfoResponse>
{
	public class Request
	{
		public int GT;
	}

	private Request m_sRequest;

	public override byte[] GetAPI()
	{
		return null;
	}
}
