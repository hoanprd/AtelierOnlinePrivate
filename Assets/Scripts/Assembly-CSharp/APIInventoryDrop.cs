public class APIInventoryDrop : APISimple
{
	public class Request
	{
		public class DropItem
		{
			public long ID;
		}

		public DropItem[] ITEM;
	}

	private Request m_sRequest;

	public long[] DropList
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
