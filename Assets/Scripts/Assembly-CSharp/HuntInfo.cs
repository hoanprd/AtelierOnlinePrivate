using System;
using System.Collections.Generic;

[Serializable]
public class HuntInfo
{
	public int AREADF;

	public int HUNTID;

	public int DTY;

	public string NAME;

	public string ICON;

	public int TM;

	public DfCntInfo DEPWTH;

	public List<DfCntInfo> INSWTH;

	public string DESC;

	public EventInfo MRK;

	public List<JoinCondition> JCND;

	public HuntReward RWD;

	public int STS;

	public int LEFTTM;

	public string CMPDT;

	public HuntForm HFM;

	public List<HuntRate> HRT;

	public void CreateDummy(int no, bool done)
	{
	}

	public int GetRequireMemberNum()
	{
		return 0;
	}

	public int GetRequireMinLv()
	{
		return 0;
	}

	public List<int> GetRequireChara()
	{
		return null;
	}

	public List<List<int>> GetBonusChara(List<PartyMember> mem)
	{
		return null;
	}

	public bool IsReady()
	{
		return false;
	}

	public string GetRemainText()
	{
		return null;
	}

	public int GetPrio()
	{
		return 0;
	}

	public bool IsEvent()
	{
		return false;
	}
}
