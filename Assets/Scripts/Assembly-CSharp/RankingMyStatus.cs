using UnityEngine;

public class RankingMyStatus : MonoBehaviour
{
	[SerializeField]
	private UILabel m_scrRankLabel;

	[SerializeField]
	private UILabel m_scrScoreLabel;

	[SerializeField]
	private UITexture m_scrScoreIcon;

	public void Init(int iRank, long lScore, string strIconPath)
	{
	}

	public void Clear()
	{
	}
}
