using System;
using System.Collections.Generic;

[Serializable]
public class ShopGachaShow
{
	[Serializable]
	public class PickupInfo
	{
		public List<Coordinate> CRD;

		public List<Chara> CHR;

		public List<Item> ITM;
	}

	[Serializable]
	public class Item
	{
		public int DF;

		public int QTY;

		public int[] TRT;

		public int LV;
	}

	[Serializable]
	public class Coordinate
	{
		[Serializable]
		public class Accessory
		{
			public int NO;

			public int DF;
		}

		public int GEN;

		public int HD;

		public int BD;

		public int WR;

		public int WL;

		public List<Accessory> AC;
	}

	[Serializable]
	public class Chara
	{
		public int DF;
	}

	[Serializable]
	public class Benefit
	{
		public PurchaseBenefit BENE;

		public RewardInfoExt[] INFO;
	}

	public PickupInfo PKU;

	public List<Benefit> BENEINFO;
}
