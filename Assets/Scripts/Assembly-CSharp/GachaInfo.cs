using System;
using System.Collections.Generic;

[Serializable]
public class GachaInfo
{
	[Serializable]
	public class PriceInfo
	{
		public int DF;

		public int CNT_1;

		public int CNT_10;

		public int CNT_P;
	}

	[Serializable]
	public class LimitInfo
	{
		public int NUM;

		public int NUM_1;

		public int NUM_10;

		public int NUM_P;

		public int NOD_1;

		public int NOD_10;

		public int NOD_P;

		public int CNT;

		public int CNT_1;

		public int CNT_10;

		public int CNT_P;

		public int COD_1;

		public int COD_10;

		public int COD_P;
	}

	[Serializable]
	public class SellInfo
	{
		public int SELLID;

		public int SELLGRPID;

		public int WTHDF;

		public int PAYONLY;

		public int WTHCNT;

		public int LOTCNT;

		public int WL_LMT;

		public int WL_CNT;

		public int DAY_LMT;

		public int DAY_CNT;

		public void AddLottery()
		{
		}

		public bool IsEnableLottery()
		{
			return false;
		}

		public bool IsLimited()
		{
			return false;
		}
	}

	[Serializable]
	public class Data
	{
		public int DF;

		public int CATEG;

		public int ICON;

		public string IMG;

		public string NAME;

		public string DESC;

		public ShopBanner BNR;

		public ShopBanner BNR_L;

		public EventInfo MRK;

		public ProductionInfo PRD;

		public LimitInfo LMT;

		public PriceInfo[] PRC;

		public List<SellInfo> SELL;

		public string DISPORDER;

		public List<SellInfo> GetSellGroup(int groupID)
		{
			return null;
		}
	}

	public int NO;

	public string NAME;

	public Data[] LIST;
}
