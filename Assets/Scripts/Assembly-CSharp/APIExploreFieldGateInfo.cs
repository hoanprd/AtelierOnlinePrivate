public class APIExploreFieldGateInfo : MsgPackAPICommon<GateInfoResponse>
{
	public class Request
	{
		public int GT;
	}

	private Request m_sRequest;

	public int GateID
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
