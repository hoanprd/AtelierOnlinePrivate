using System;

[Serializable]
public class Restore
{
	[Serializable]
	public class GetItem
	{
		public long ID;

		public int DF;
	}

	public GetItem[] GET;
}
