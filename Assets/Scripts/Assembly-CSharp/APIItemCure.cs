using System;

public class APIItemCure : APISimple
{
	public class Request
	{
		[Serializable]
		public class Item
		{
			public long ID;
		}

		public Item[] USE;
	}

	private Request m_sRequest;

	public long[] ItemList
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
