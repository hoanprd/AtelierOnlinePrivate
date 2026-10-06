using System;

[Serializable]
public class ShopComDetail
{
	[Serializable]
	public class Item
	{
		public int DF;

		public int CNT;

		public int QTY;

		public int TRT;

		public int LV;
	}

	public Item[] ITM;

	public PresentWealthInfo[] WTH;

	public bool IsMultiItem()
	{
		return false;
	}

	public Item GetCurrentItem()
	{
		return null;
	}

	public PresentWealthInfo GetCurrentWealth()
	{
		return null;
	}
}
