public class APIComProductPurchase : MsgPackAPICommon<ProductPurchaseResponse>
{
	public class Request
	{
		public string PID;

		public string JSON;

		public string SIGNATURE;
	}

	private Request m_sRequest;

	public string ProductID
	{
		set
		{
		}
	}

	public string Json
	{
		set
		{
		}
	}

	public string Signature
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
