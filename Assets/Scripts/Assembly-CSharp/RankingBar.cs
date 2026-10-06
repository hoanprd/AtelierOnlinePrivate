using UnityEngine;

public class RankingBar : MonoBehaviour
{
	public enum eLabel
	{
		PlayerName = 0,
		Score = 1,
		RankingNum = 2,
		EnumMax = 3
	}

	public enum eTexture
	{
		Leader = 0,
		Score = 1,
		EnumMax = 2
	}

	private static readonly int sr_iRankIconNum;

	[SerializeField]
	private GameObject m_goMyBase;

	[SerializeField]
	private GameObject m_goOtherBase;

	[SerializeField]
	private Transform m_trDegreeRoot;

	[SerializeField]
	private UIButton m_scrApllyBtn;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private UITexture[] m_scrTextureAry;

	[SerializeField]
	private UISprite m_scrRankSprite;

	private long m_lUserId;

	private DegreeIcon m_scrDegree;

	private void Awake()
	{
	}

	public void Init(RankingUserData clsData, string strScoreIconPath)
	{
	}

	public void OnDetailButton()
	{
	}

	private void OnClickedApply()
	{
	}

	private void SetLabelText(eLabel eKind, string strText)
	{
	}

	private void SetTexturePath(eTexture eKind, string strPath, bool bAsset = true, string strDefault = "")
	{
	}
}
