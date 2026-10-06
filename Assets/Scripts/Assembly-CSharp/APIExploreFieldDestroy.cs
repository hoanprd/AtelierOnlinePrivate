public class APIExploreFieldDestroy : MsgPackAPICommon<FieldDestroyResponse>
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int FieldID
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
