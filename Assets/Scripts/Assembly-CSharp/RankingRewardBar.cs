using UnityEngine;

public class RankingRewardBar : MonoBehaviour
{
	[SerializeField]
	private RankingRankRewardBar m_scrRankBar;

	[SerializeField]
	private RankingScoreRewardBar m_scrScoreBar;

	public void Init(RankingRewardInfo clsReward, int iMyRank, string strIconPath)
	{
	}

	public void Init(RankingScoreRewardInfo clsReward, long lMyScore, string strIconPath)
	{
	}
}
