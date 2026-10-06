using System;
using System.Collections.Generic;
using Mission;

[Serializable]
public class DailyMissionInfo
{
	[Serializable]
	public class Info
	{
		public int NO;

		public int BDR;

		public string NAME;

		public string DESC;

		public RewardItem[] RWD_ITM;

		public RewardWorth[] RWD_WTH;

		public int NOW;

		public int GVN;

		public string DLN;

		public bool IsComplete()
		{
			return false;
		}
	}

	public int DF;

	public List<Info> LST;

	public void Sort()
	{
	}
}
