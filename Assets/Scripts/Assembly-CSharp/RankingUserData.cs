using System;

[Serializable]
public class RankingUserData
{
	public long ID;

	public string NA;

	public int RANK;

	public long SCORE;

	public int CH;

	public int TTL_DF;

	public int TTL_ST;

	public RankingUserData()
	{
	}

	public RankingUserData(long ID, string NA, int RANK, long SCORE, int CH, int TTL_DF, int TTL_ST)
	{
	}

	public RankingUserData(RankingUserData clsOrg)
	{
	}
}
