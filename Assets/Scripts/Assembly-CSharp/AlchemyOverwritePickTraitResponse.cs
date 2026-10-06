using System;
using System.Collections.Generic;

[Serializable]
public class AlchemyOverwritePickTraitResponse
{
	[Serializable]
	public class WealthAmount
	{
		public int TYPE;

		public int AMOUNT;
	}

	public Dictionary<string, List<WealthAmount>> WTH_COSTS;

	public List<int> ENABLED_TRT;
}
