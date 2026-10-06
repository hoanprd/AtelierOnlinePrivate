public class APIHomeShopGachaLotP : MsgPackAPICommon<ShopGachaLotResponse>
{
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
