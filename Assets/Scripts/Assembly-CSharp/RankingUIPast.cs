using UnityEngine;

public class RankingUIPast : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private GameObject[] m_goArrow;

	[SerializeField]
	private UIPageGrid m_scrPageUI;

	public void Init(RankingMngInfo clsInfo, int iPageNow, int iPageMax)
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
