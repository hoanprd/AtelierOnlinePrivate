using System;
using UnityEngine;

public class EquipmentSortArmor : MonoBehaviour
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

	public Transform m_trRoot;

	public ItemList m_sSortData;

	private bool m_bInit;

	private void Start()
	{
	}

	public void Init()
	{
	}
}
