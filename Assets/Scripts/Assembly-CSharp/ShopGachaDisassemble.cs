using System;
using System.Collections.Generic;

[Serializable]
public class ShopGachaDisassemble
{
	[Serializable]
	public class Item
	{
		public long ID;
	}

	public int NO;

	public List<Item> GET;
}
