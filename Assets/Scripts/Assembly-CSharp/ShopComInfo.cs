using System;
using System.Collections.Generic;

[Serializable]
public class ShopComInfo
{
	[Serializable]
	public class PriceInfo
	{
		public int DF;

		public int CNT;
	}

	[Serializable]
	public class LimitInfo
	{
		public int NUM;

		public int USD;
	}

	[Serializable]
	public class Data
	{
		public int DF;

		public int CATEG;

		public int ICON;

		public string IMG;

		public string NAME;

		public string KANA;

		public string DESC;

		public ShopBanner BNR;

		public ShopBanner BNR_L;

		public EventInfo MRK;

		public ProductionInfo PRD;

		public LimitInfo LMT;

		public PriceInfo[] PRC;

		public ShopSellInfo[] SELL;

		public bool IsEnableBuy()
		{
			return false;
		}

		public void AddUseCount(int groupID)
		{
		}
	}

	[Serializable]
	public class LimitTypeInfo
	{
		public int TYPE;

		public LimitInfo INFO;
	}

	[Serializable]
	public class ShopSellInfo
	{
		public int SELLID;

		public int SELLGRPID;

		public int WTHDF;

		public int PAYONLY;

		public int WTHCNT;

		public List<LimitTypeInfo> LMT;

		public bool IsEnableBuy()
		{
			return false;
		}

		public LimitTypeInfo GetActiveLimit()
		{
			return null;
		}

		public int GetRemainCount()
		{
			return 0;
		}

		public void AddUseCount()
		{
		}
	}

	public int NO;

	public string NAME;

	public Data[] LIST;

	public bool IsEnable()
	{
		return false;
	}
}
