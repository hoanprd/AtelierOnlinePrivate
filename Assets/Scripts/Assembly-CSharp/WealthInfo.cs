using System;

[Serializable]
public class WealthInfo : PossessionInfo
{
	[Serializable]
	public class Compensation
	{
		public int PRC;

		public int GVN;
	}

	public Compensation CHG;
}
