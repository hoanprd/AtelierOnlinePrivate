using UnityEngine;

public class RankingScoreRewardBar : RankingRewardBarBase
{
	[SerializeField]
	private UILabel m_scrScoreLabel;

	[SerializeField]
	private UISprite m_scrStamp;

	[SerializeField]
	private UITexture m_scrScoreIcon;

	public void Init(RankingScoreRewardInfo clsReward, long lMyScore, string strIconPath)
	{
	}
}
