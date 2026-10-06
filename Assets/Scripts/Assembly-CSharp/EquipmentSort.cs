using System;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSort : MonoBehaviour
{
	public enum ESortKind
	{
		eQUARITY = 0,
		eLEVEL = 1,
		eATK = 2,
		eDEF = 3,
		eDEF_MGC = 4,
		eAGI = 5,
		eNUM = 6
	}

	[Serializable]
	public struct ObjectData
	{
		public GameObject goPrefab;

		public UIGrid sGrid;
	}

	public static readonly string[] caSORT_STRING;

	public static readonly int[] casCATEGORY_NAME;

	public GameObject m_goWeaponRoot;

	public Transform m_goWeaponSortRoot;

	public GameObject m_goArmorRoot;

	public Transform m_goArmorSortRoot;

	public ObjectData m_sFilterData;

	public ObjectData m_sSortData;

	public UITweenReset m_sAnim;

	private int m_iSort;

	private List<int> m_viFilter;

	private bool m_bCreate;

	private Action m_sExitCallback;

	public int Sort
	{
		get
		{
			return 0;
		}
	}

	public List<int> Filter
	{
		get
		{
			return null;
		}
	}

	private void Create()
	{
	}

	private void InitSort(int sort)
	{
	}

	private void InitFilter(List<int> list)
	{
	}

	public void Init(int sort, Action callback = null)
	{
	}

	public void Init(int sort, List<int> filter, Action callback = null)
	{
	}

	public void OnClose()
	{
	}

	private void OnDismiss()
	{
	}

	public void OnFilterSelect(EquipmentFilterListItem item)
	{
	}

	public void OnSortSelect(EquipmentSortListItem item)
	{
	}
}
