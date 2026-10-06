using System;
using System.Collections.Generic;

[Serializable]
public class FoodInfo
{
	[Serializable]
	public class RequestInfo
	{
		public int DF;

		public int QTY;

		public int IS_UNLOCK_RCP;
	}

	[Serializable]
	public class Food
	{
		public int NO;

		public List<RequestInfo> RQ;
	}

	public Food FDM;
}
