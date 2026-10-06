public class APIInventoryDispose : APISimple
{
	public class Request
	{
		public class DisposeItemList
		{
			public long ID;
		}

		public DisposeItemList[] ITEM;
	}

	private Request m_sRequest;

	public long[] DisposeList
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
