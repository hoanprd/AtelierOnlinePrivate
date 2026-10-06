using System;
using System.Collections.Generic;

public class APIShopComSummary : MsgPackAPICommon<ShopComSummaryResponse>
{
	[Serializable]
	public class Request
	{
		public List<int> SHPDF;
	}

	private Request m_sRequest;

	public List<int> SHPDF
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
