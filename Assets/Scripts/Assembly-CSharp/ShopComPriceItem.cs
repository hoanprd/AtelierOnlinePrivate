using System;
using System.Collections.Generic;
using UnityEngine;

public class ShopComPriceItem : MonoBehaviour
{
	[Serializable]
	public class Compensation
	{
		public GameObject goRoot;

		public UITexture txWealthIcon;

		public UITexture txFaceIcon;

		public UILabel sHave;
	}

	[SerializeField]
	private UIButton m_sButton;

	[SerializeField]
	private UILabel m_sPrice;

	[SerializeField]
	private UITexture m_txWealthIcon;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private Compensation m_sCompensation;

	private List<ShopComInfo.ShopSellInfo> m_vPriceList;

	private ShopComInfo.ShopSellInfo m_sCurrentPrice;

	private bool m_bMulti;

	public ShopComInfo.ShopSellInfo Price
	{
		get
		{
			return null;
		}
	}

	public List<ShopComInfo.ShopSellInfo> PriceList
	{
		get
		{
			return null;
		}
	}

	public bool IsMulti
	{
		get
		{
			return false;
		}
	}

	public void InitMulti(List<ShopComInfo.ShopSellInfo> price)
	{
	}

	public void Init(List<ShopComInfo.ShopSellInfo> price)
	{
	}

	private void InitPrice()
	{
	}

	public void UpdateInfo()
	{
	}
}
