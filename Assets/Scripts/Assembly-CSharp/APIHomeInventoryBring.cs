public class APIHomeInventoryBring : APISimple
{
	public class Request
	{
		public class RetainItem
		{
			public long ID;
		}

		public RetainItem[] LIST;
	}

	private Request m_sRequest;

	public long[] BringList
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
