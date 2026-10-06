using System.Collections.Generic;
using UnityEngine;

public class ShopGachaDetail : MonoBehaviour
{
	private class PickupItemData
	{
		public int GEN;

		public int DF;

		public PickupItemData(ShopGachaShow.Coordinate coordinate, int df)
		{
		}
	}

	private enum EKind
	{
		eBANNER = 0,
		eCOODINATE = 1,
		eITEM = 2,
		eCHARA = 3
	}

	[SerializeField]
	private UITexture m_txBannerL;

	[SerializeField]
	private ShopModel m_sModel;

	[SerializeField]
	private ShopGachaPriceList m_sPrice;

	[SerializeField]
	private ShopGachaCoordinateList m_sCoordinate;

	[SerializeField]
	private ShopGachaEquipInfo m_sEquipInfo;

	[SerializeField]
	private UIPageGrid m_sPage;

	[SerializeField]
	private GameObject m_sNextPageCollider;

	[SerializeField]
	private UITexture m_txCharaAllTexture;

	[SerializeField]
	private UITweenReset m_sChangeAnim;

	[SerializeField]
	private GameObject m_goBannerRoot;

	[SerializeField]
	private GameObject m_goCharaRoot;

	[SerializeField]
	private GameObject m_goPickupRoot;

	[SerializeField]
	private GameObject[] m_agoInfoObject;

	[SerializeField]
	public AnimationController m_sAnim;

	private float m_fWaitTime;

	private GachaInfo.Data m_sInfo;

	private ShopGachaShow m_sDetail;

	private ShopGachaShow.Coordinate m_sNowCoordinate;

	private List<object> m_pageList;

	private int m_iPage;

	private bool m_bNextDir;

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void Init()
	{
	}

	public void UpdatePrice()
	{
	}

	public void Init(GachaInfo.Data info, ShopGachaShow detail)
	{
	}

	public void OnNext(bool next)
	{
	}

	private void Update()
	{
	}

	private void InitNextInfo()
	{
	}

	private void UpdatePage()
	{
	}

	private void UpdatePage(ShopGachaShow.Coordinate data)
	{
	}

	private void UpdatePage(ShopGachaShow.Item data)
	{
	}

	private void UpdatePage(ShopGachaShow.Chara data)
	{
	}

	private void InitLineup(EKind kind)
	{
	}
}
