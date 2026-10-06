using System;
using System.Collections.Generic;

[Serializable]
public class MasterBlazeArts : MasterRecordDFBase
{
	[Serializable]
	public class BlazeArtsParam
	{
		public int SKILL_DF;

		public int EXP_PT;
	}

	public List<BlazeArtsParam> LV;

	public int GetLv(int exp)
	{
		return 0;
	}

	public int GetMaxLv()
	{
		return 0;
	}

	public int GetNeedExp(int lv)
	{
		return 0;
	}
}
