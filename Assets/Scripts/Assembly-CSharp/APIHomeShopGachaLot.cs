public class APIHomeShopGachaLot : MsgPackAPICommon<ShopGachaLotResponse>
{
	public class Request
	{
		public int DF;

		public int SELLID;
	}

	private Request m_sRequest;

	public int ID
	{
		set
		{
		}
	}

	public int SELLID
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
