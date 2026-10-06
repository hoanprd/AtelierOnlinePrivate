using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ShopMenuCom : ShopMenuBase
{
	private EShopComKind m_eSelectTab;

	private EShopComKind m_eNextTab;

	[SerializeField]
	private GameObject m_goListObject;

	[SerializeField]
	private ShopComListView m_sListView;

	[SerializeField]
	private ShopComEquipListView m_sEquipListView;

	[SerializeField]
	private List<ShopComTab> m_vTabs;

	[SerializeField]
	private GameObject m_goTabPrefab;

	[SerializeField]
	private UIGrid m_sTabGrid;

	[SerializeField]
	private UIScrollView m_sTabScroll;

	[SerializeField]
	private UIScrollListArrow m_sTabScrollArrow;

	private ShopComInfo.ShopSellInfo m_sTarget;

	private ShopComInfoList m_sInfo;

	private bool m_bInitTab;

	public static int si_StartTab;

	public override void Init()
	{
	}

	public void OnClose()
	{
	}

	public override void Dismiss()
	{
	}

	public void ChangeTab(ShopComTab tab)
	{
	}

	public void OnDecideConfirm(ShopComPriceItem target)
	{
	}

	private void OnDecideBuy(ShopComInfo.ShopSellInfo target)
	{
	}

	private void Buy()
	{
	}

	private void BuyResult(BuyResponse res)
	{
	}

	private void CreateTab()
	{
	}

	private void ResetTab()
	{
	}

	private void InitTab(EShopComKind kind)
	{
	}

	[DebuggerHidden]
	private IEnumerator StartTab()
	{
		return null;
	}
}
