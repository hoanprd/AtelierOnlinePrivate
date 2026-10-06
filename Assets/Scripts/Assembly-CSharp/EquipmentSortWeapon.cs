using System;
using UnityEngine;

public class EquipmentSortWeapon : MonoBehaviour
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
	public struct ItemList
	{
		public GameObject goPrefab;

		public UIGrid sGrid;
	}

	public static readonly string[] caSORT_STRING;

	public static readonly int[] casCATEGORY_NAME;

	public ItemList m_sFilterData;

	public ItemList m_sSortData;

	private bool m_bInit;

	private void Start()
	{
	}

	public void Init()
	{
	}
}
