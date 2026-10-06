using UnityEngine;

public class RankingRewardUIRank : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private RankingMyStatus m_scrMyStatus;

	public void Init(RankingMngInfo clsInfo, RankingUserData clsMyData)
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
