using System;
using Ranking;

[Serializable]
public class RankingMngInfo
{
	public int TYPE;

	public int CYC;

	public string NA;

	public int STATE;

	public string START_DT;

	public string END_DT;

	public string LAST_UPDATE_DT;

	public int FACTOR;

	public RankingMngInfo()
	{
	}

	public RankingMngInfo(int TYPE, int CYC, int STATE, string START_DT, string END_DT, string LAST_UPDATE_DT)
	{
	}

	public bool IsMatch(eRankingType eRanking, int iCycle)
	{
		return false;
	}

	public bool IsUpdate(RankingMngInfo clsInfo)
	{
		return false;
	}
}
