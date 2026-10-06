using System;
using Mission;

[Serializable]
public class DegreeMissionInfo
{
	[Serializable]
	public class Step
	{
		public int STP;

		public int RTY;

		public int BDR;

		public string NAME;

		public string DESC;

		public int CLR;

		public int GVN;

		public RewardItem[] RWD_ITM;

		public RewardWorth[] RWD_WTH;
	}

	public int DF;

	public int NOW;

	public int NXT;

	public int BAS;

	public int BDR;

	public int CMP;

	public int CNT;

	public int TYP;

	public int RTY;

	public string NAME;

	public string DESC;

	public RewardItem[] RWD_ITM;

	public RewardWorth[] RWD_WTH;

	public Step[] STPS;

	public int GetDispPrio()
	{
		return 0;
	}

	public static int Compare(DegreeMissionInfo a, DegreeMissionInfo b)
	{
		return 0;
	}

	public bool IsAchieve()
	{
		return false;
	}

	public bool IsType(int type)
	{
		return false;
	}
}
