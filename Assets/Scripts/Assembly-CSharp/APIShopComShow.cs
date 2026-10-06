using System;

public class APIShopComShow : MsgPackAPICommon<ShopComShowResponse>
{
	[Serializable]
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int ID
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
