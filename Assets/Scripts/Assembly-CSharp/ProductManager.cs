using System;
using UnityEngine;

public class ProductManager : UIListViewBase<ProductItem>
{
	[SerializeField]
	private AnimationController[] m_asAnim;

	[SerializeField]
	private HomeBannerManager m_sBanner;

	[SerializeField]
	private Transform m_trDetailRoot;

	[SerializeField]
	private ProductCheckAge m_sCheckAgeWindow;

	[SerializeField]
	private UILabel m_sTotal;

	[SerializeField]
	private UILabel m_sFree;

	[SerializeField]
	private UILabel m_sCompensation;

	[SerializeField]
	private GameObject m_goGotoShop;

	[SerializeField]
	private GameObject m_goGotoGacha;

	private ProductInfoList m_sInfo;

	private ProductInfo m_sBuyItem;

	private Action m_sGotoShop;

	private Action m_sGotoGacha;

	private bool m_connecting;

	private void Update()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void UpdateHave()
	{
	}

	public void Init(ProductInfoList info, Action onGotoShop = null, Action onGotoGacha = null)
	{
	}

	private void OnStoreInitialized(bool is_success)
	{
	}

	private void OnRestore(bool result, string product_id)
	{
	}

	public void UpdateProductInfo()
	{
	}

	public void UpdateProductInfoUI(ProductInfoList products)
	{
	}

	public void OnGotoGacha()
	{
	}

	public void OnGotoShop()
	{
	}

	public void OnDetail(ProductInfo item)
	{
	}

	public void OnBuy(ProductInfo item)
	{
	}

	private void OnBuyConfirm()
	{
	}

	private void PurchaseResult(bool is_success, string product_id)
	{
	}

	public void OnFundSettlementInfo()
	{
	}

	public void OnSpecifiedCommercialTransactionInfo()
	{
	}

	public static ProductManager Create()
	{
		return null;
	}
}
