using System;

public class APIComHuntRecommend : MsgPackAPICommon<HuntRecommendResponse>
{
	[Serializable]
	public class Request
	{
		public int HUNTID;

		public HuntForm HFM;
	}

	private Request m_sRequest;

	public HuntForm HuntForm
	{
		set
		{
		}
	}

	public int HuntID
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
