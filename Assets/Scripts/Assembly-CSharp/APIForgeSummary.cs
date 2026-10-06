using System.Collections.Generic;

public class APIForgeSummary : APISimple
{
	public class Request
	{
		public class Category
		{
			public int CT;

			public Category(ECategory categ)
			{
			}

			public Category()
			{
			}
		}

		public List<Category> CATEG;
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
}
