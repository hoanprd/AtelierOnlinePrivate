using System.Collections.Generic;
using UnityEngine;

public class HomeBannerManager : MonoBehaviour
{
	public GameObject m_goPrefab;

	public UIScrollView m_sScroll;

	public UICenterOnChild m_sCenter;

	public UIWrapContent m_sWrap;

	public UIPageGrid m_sPage;

	private int m_iPageNum;

	private int m_iIndex;

	private HomeBannerPlate m_sCenterObject;

	private float m_fWaitTime;

	private bool m_bInit;

	private List<ShopBanner> m_vBanner;

	private List<HomeBannerPlate> m_vItemList;

	private const int ciOBJECT_NUM = 4;

	private const float cfWAIT_SPAN = 5f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private Transform GetNext()
	{
		return null;
	}

	public void Init(List<ShopBanner> list = null)
	{
	}

	private void OnDrag()
	{
	}

	private void OnCenter(GameObject center)
	{
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}
}
