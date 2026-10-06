using UnityEngine;

public class GachaDirButton : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goSkipButton;

	[SerializeField]
	private GameObject m_goMultiReceiveButton;

	[SerializeField]
	private GameObject m_goSingleReceiveButton;

	[SerializeField]
	private GameObject m_goCharaGetButton;

	[SerializeField]
	private GameObject m_goOKButton;

	[SerializeField]
	private UILabel m_sWealthNum;

	[SerializeField]
	private UITexture[] m_atxWealthIcon;

	[SerializeField]
	private UILabel m_sPrice;

	[SerializeField]
	private GameObject m_goCompensationMark;

	[SerializeField]
	private GameObject m_goRetryButton;

	[SerializeField]
	private UILabel m_sRetryComment;

	[SerializeField]
	private UIToggle m_sSwitchDecomposeButton;

	[SerializeField]
	private UIToggledObjects m_sSwitchDecomposeToggle;

	[SerializeField]
	private UILabel m_sWarning;

	private bool m_bIsSkip;

	public bool IsSkip()
	{
		return false;
	}

	public void Init(bool enableSkip = false)
	{
	}

	public void InitDirection(bool reset = true)
	{
	}

	public void InitSingle(ShopGachaLot.LotResult data, bool OkButton)
	{
	}

	public void InitMulti(ShopGachaLot data, GachaInfo.Data info, GachaInfo.SellInfo price, bool restart = false)
	{
	}

	public void OnSkip()
	{
	}
}
