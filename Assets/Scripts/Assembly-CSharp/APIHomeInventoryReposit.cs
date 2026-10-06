public class APIHomeInventoryReposit : APISimple
{
	public class Request
	{
		public class RepositItem
		{
			public long ID;
		}

		public RepositItem[] LIST;
	}

	private Request m_sRequest;

	public long[] RepositList
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
