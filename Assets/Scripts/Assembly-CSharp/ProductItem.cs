using UnityEngine;

public class ProductItem : MonoBehaviour
{
	[SerializeField]
	private UISprite m_sIcon;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sTotal;

	[SerializeField]
	private UILabel m_sGetNum;

	[SerializeField]
	private UILabel m_sBonus;

	[SerializeField]
	private UILabel m_sPrice;

	[SerializeField]
	private UILabel m_sLimit;

	[SerializeField]
	private UIButton m_sBuyButton;

	[SerializeField]
	private GameObject m_goLimited;

	[SerializeField]
	private GameObject m_goDetailButton;

	private ProductInfo m_sInfo;

	public ProductInfo Info
	{
		get
		{
			return null;
		}
	}

	public void Init(ProductInfo info)
	{
	}
}
