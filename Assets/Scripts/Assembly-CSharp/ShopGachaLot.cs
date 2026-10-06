using System;
using System.Collections.Generic;

[Serializable]
public class ShopGachaLot
{
	[Serializable]
	public class LotGetItem
	{
		public int DF;

		public int TRT;
	}

	[Serializable]
	public class LotResult
	{
		public int NO;

		public int DF;

		public int NEW;

		public int GRD;

		public int WTH;

		public long ID;

		public int QTY;

		public int TRT;

		public int LV;

		public List<LotGetItem> MAT;

		public bool IsChara()
		{
			return false;
		}

		public bool IsLimitbreak()
		{
			return false;
		}

		public bool IsNew()
		{
			return false;
		}
	}

	[Serializable]
	public class BeneInfo
	{
		public int SELLGRPID;

		public int GACHACNT;

		public List<long> REWARDLIST;
	}

	public PriceInfo[] PRC;

	public List<LotResult> LOT;

	public List<BeneInfo> BEN;
}
