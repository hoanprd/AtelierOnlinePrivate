using System;

[Serializable]
public class ShopBuy
{
	[Serializable]
	public class GetItem : InventoryDetail
	{
		public int CNT;
	}

	public GetItem[] GET;
}
