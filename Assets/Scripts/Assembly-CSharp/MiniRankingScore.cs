using UnityEngine;

public class MiniRankingScore : MonoBehaviour
{
	public static bool s_bDisplay;

	[SerializeField]
	private GameObject m_goActiveObj;

	[SerializeField]
	private UILabel m_scrScore;

	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private UILabel m_scrLavel;

	[SerializeField]
	private GameObject m_goBoostLab;

	[SerializeField]
	private UILabel m_scrReversal;

	public void Init(MiniRankingInfo mri)
	{
	}

	public void Init()
	{
	}

	private void Awake()
	{
	}

	public void Update()
	{
	}

	private void SetActiveFairyObj(bool bActive)
	{
	}

	public void SetScoreLabel(int score)
	{
	}

	private void updateReversalText()
	{
	}
}
