public class GimmickActivate : MsgPackAPICommon<GimmickActivateResponse>
{
	public class Request
	{
		public int GI;

		public long ITEM;
	}

	private Request m_sRequest;

	public int NO
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
