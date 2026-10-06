using UnityEngine;

public class RankingRewardUIScore : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private UITexture[] m_scrScoreIconAry;

	[SerializeField]
	private UILabel m_scrMyScore;

	[SerializeField]
	private UILabel m_scrNextScore;

	public void Init(RankingMngInfo clsInfo, long lMyScore, long lNextScore)
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public bool IsActive()
	{
		return false;
	}
}
