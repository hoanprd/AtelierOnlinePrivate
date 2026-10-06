public class APIHomeInventoryRestore : MsgPackAPICommon<RestoreResponse>
{
	public class Request
	{
		public class InventoryID
		{
			public long ID;
		}

		public InventoryID[] LIST;
	}

	private Request m_sRequest;

	public long[] List
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
