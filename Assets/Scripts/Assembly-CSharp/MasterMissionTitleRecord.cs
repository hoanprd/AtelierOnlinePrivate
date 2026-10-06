using System;
using System.Collections.Generic;

[Serializable]
public class MasterMissionTitleRecord : MasterRecordDFBase
{
	[Serializable]
	public class Clr
	{
		public int DF;

		public int STP;
	}

	[Serializable]
	public class Msn
	{
		public int STP;

		public int RTY;

		public int BDR;

		public int FON;

		public string NAME;

		public string DESC;
	}

	[Serializable]
	public class Rwd_itm
	{
		public int STP;

		public int DF;

		public int CNT;

		public int QTY;

		public int TRT;
	}

	[Serializable]
	public class Rwd_wth
	{
		public int STP;

		public int DF;

		public int CNT;
	}

	public int CATEG;

	public int TYP;

	public string KEY;

	public int P1;

	public int P2;

	public int OPEN_CHAPTER;

	public int DISP_ORDER;

	public Clr CLR;

	public List<Msn> MSN;

	public Rwd_itm[] RWD_ITM;

	public Rwd_wth[] RWD_WTH;
}
