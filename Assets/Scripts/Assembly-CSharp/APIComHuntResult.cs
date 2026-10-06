using System;

public class APIComHuntResult : MsgPackAPICommon<HuntResultResponse>
{
	[Serializable]
	public class Request
	{
		public int FID;

		public eHuntReturnType RTN;

		public int WTHDF;
	}

	private Request m_sRequest;

	public int FormID
	{
		set
		{
		}
	}

	public eHuntReturnType ReturnType
	{
		set
		{
		}
	}

	public int WealthDF
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
