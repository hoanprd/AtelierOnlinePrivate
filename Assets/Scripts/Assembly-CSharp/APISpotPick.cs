public class APISpotPick : MsgPackAPICommon<APISpotPickResponse>
{
	public class Request
	{
		public int PP;

		public long US;
	}

	public Request m_sRequest;

	public int SpotID
	{
		set
		{
		}
	}

	public long ItemID
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
