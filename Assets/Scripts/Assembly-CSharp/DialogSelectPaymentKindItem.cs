using System.Collections.Generic;
using UnityEngine;

public class DialogSelectPaymentKindItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sPrice;

	[SerializeField]
	private UITexture m_txWealthIcon;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UIButton m_sButton;

	private ShopComInfo.ShopSellInfo m_sCurrentPrice;

	private List<ShopComInfo.ShopSellInfo> m_vPriceList;

	public ShopComInfo.ShopSellInfo Price
	{
		get
		{
			return null;
		}
	}

	public void Init(List<ShopComInfo.ShopSellInfo> price)
	{
	}
}
