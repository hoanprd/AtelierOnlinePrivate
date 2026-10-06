using System;

[Serializable]
public class RankingRewardInfo
{
	public int RANK_MIN;

	public int RANK_MAX;

	public RewardInfo[] REW;

	public long BD_SCORE;

	public RankingRewardInfo()
	{
	}

	public RankingRewardInfo(int RANK_MIN, int RANK_MAX, long BD_SCORE, int iRankArea)
	{
	}
}
