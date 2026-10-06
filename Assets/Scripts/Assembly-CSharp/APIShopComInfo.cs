public class APIShopComInfo : MsgPackAPICommon<ShopComInfoResponse>
{
	public class Request
	{
		public int CATEG;
	}

	private Request m_sRequest;

	public override byte[] GetAPI()
	{
		return null;
	}
}
