using UnityEngine;

public class RankingUILatest : MonoBehaviour
{
	private static readonly string st_strDateFormat;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private GameObject m_goOpenRoot;

	[SerializeField]
	private GameObject m_goCountRoot;

	[SerializeField]
	private UILabel m_scrTermLabel;

	[SerializeField]
	private UILabel m_scrLastUpdate;

	public void Init(RankingMngInfo clsInfo)
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
