using System;
using System.Collections.Generic;
using UnityEngine;

public class SortFilterWindow : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private SortWindow m_sSort;

	[SerializeField]
	private SortWindow m_sFilter;

	[SerializeField]
	private SortWindow m_sOrder;

	[SerializeField]
	private GameObject m_goCloseButton;

	[SerializeField]
	private Transform[] m_atrCloseRoot;

	[SerializeField]
	private UISprite[] m_asBackGround;

	private Action<bool> m_sOnClose;

	private int m_iFilter;

	private int m_iSort;

	private int m_iOrder;

	private int m_iPrevFilter;

	private int m_iPrevSort;

	private int m_iPrevOrder;

	private const int ciSORT_GROUP = 40;

	private const int ciORDER_GROUP = 42;

	private const int ciFILTER_GROUP = 41;

	public EFilterKind Filter
	{
		get
		{
			return EFilterKind.eALL;
		}
	}

	public ESortKind Sort
	{
		get
		{
			return ESortKind.eNO;
		}
	}

	public EOrder Order
	{
		get
		{
			return EOrder.eASC;
		}
	}

	public void Setup(List<EFilterKind> filter)
	{
	}

	public void Setup(List<ESortKind> sort, List<EFilterKind> filter = null)
	{
	}

	public void Init(int sort, int order, int filter, Action<bool> onClose)
	{
	}

	public void OnSelectSort(SortWindowItem item)
	{
	}

	public void OnSelectFilter(SortWindowItem item)
	{
	}

	public void OnSelectOrder(SortWindowItem item)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	public static SortFilterWindow Create(Transform root)
	{
		return null;
	}
}
