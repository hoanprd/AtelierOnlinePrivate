using UnityEngine;

public class RankingRankRewardBar : RankingRewardBarBase
{
	[SerializeField]
	private UILabel m_scrRankLabel;

	[SerializeField]
	private UILabel m_scrScoreLabel;

	[SerializeField]
	private UITexture m_scrScoreIcon;

	[SerializeField]
	private GameObject m_goMyBase;

	[SerializeField]
	private GameObject m_goOtherBase;

	public void Init(RankingRewardInfo clsReward, int iMyRank, string strIconPath)
	{
	}
}
