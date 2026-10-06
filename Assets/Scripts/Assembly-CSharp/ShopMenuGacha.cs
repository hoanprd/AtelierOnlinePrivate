using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ShopMenuGacha : ShopMenuBase
{
	[SerializeField]
	private ShopGachaList m_sList;

	[SerializeField]
	private ShopModel m_sModel;

	[SerializeField]
	private ShopGachaDetail m_sDetail;

	private Action m_sOnGotoShop;

	private ShopGachaPriceItem m_sBuyTarget;

	private ShopGachaLotResponse m_sLotResult;

	private GachaInfoList m_sInfo;

	public void SetGotoShopEvent(Action gotoShop)
	{
	}

	public override void Init()
	{
	}

	public void Restart()
	{
	}

	private void ReceiveInfo(GachaInfoResponse res)
	{
	}

	[DebuggerHidden]
	private IEnumerator TutorialWait()
	{
		return null;
	}

	public void OnClose()
	{
	}

	public override void Bringin()
	{
	}

	public override void Dismiss()
	{
	}

	public void OnGotoShop()
	{
	}

	public void OnDecideBuy(ShopGachaPriceItem item)
	{
	}

	private void Buy(ShopGachaPriceItem item)
	{
	}

	private void OnAPI_GachaLot(ShopGachaLotResponse res)
	{
	}

	[DebuggerHidden]
	private IEnumerator DispGachaDirection(bool restartAfterDirection = false)
	{
		return null;
	}

	public override bool IsDispBadge()
	{
		return false;
	}

	private void DispLotResultInfo()
	{
	}

	public void OnLineup()
	{
	}

	public void OnPrivacyPolicy()
	{
	}

	public static string GetBuyConfirmText(GachaInfo.Data info, GachaInfo.SellInfo price)
	{
		return null;
	}
}
