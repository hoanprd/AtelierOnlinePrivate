public class APIComFairyItem : MsgPackAPICommon<FairyItemResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int Item
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
