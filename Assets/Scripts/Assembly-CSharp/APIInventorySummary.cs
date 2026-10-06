public class APIInventorySummary : APISimple
{
	public class Request
	{
		public class Category
		{
			public int CT;
		}

		public Category[] CATEG;
	}

	private Request m_sRequest;

	public int[] CategoryList
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
