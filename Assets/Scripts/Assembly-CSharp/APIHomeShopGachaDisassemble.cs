using System;
using System.Collections.Generic;

public class APIHomeShopGachaDisassemble : MsgPackAPICommon<ShopGachaDisassembleResponse>
{
	[Serializable]
	public class Request
	{
		[Serializable]
		public class LotInfo
		{
			public int NO;

			public long ID;
		}

		public int DF;

		public List<LotInfo> LOT;
	}

	public Request m_sRequest;

	public int DF
	{
		set
		{
		}
	}

	public List<Request.LotInfo> lot
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
