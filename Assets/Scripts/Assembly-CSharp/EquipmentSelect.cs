using System.Collections.Generic;
using UnityEngine;

public class EquipmentSelect : UIWrapListBase
{
	public Transform m_trDetailRoot;

	public EquipmentStatus m_sStatus;

	public EquipmentModel m_sModel;

	public EquipmentVisualSetting m_sVisual;

	public Transform m_trSortWindowRoot;

	public UILabel m_sFilterName;

	public SortStateInfo m_sSortState;

	private SortFilterWindow m_sSortWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private InventoryInfo m_sNowItem;

	private List<InventoryInfo> m_vEnableList;

	private List<InventoryInfo> m_vDispList;

	private List<InventoryInfo> m_vEquiped;

	private CharaDetail m_sEditData;

	private CharaDetail m_sPrevData;

	private long m_iPrevInventoryID;

	private EEquipKind m_eKind;

	private int m_iPart;

	private ECategory m_eNowCategory;

	private bool m_bVisualMode;

	private MasterItem m_sWeaponMaster;

	private ESubCategory m_eWeaponKind;

	private const string SORT_PREFIX = "EQUIP_SELECT";

	public CharaDetail EditData
	{
		get
		{
			return null;
		}
	}

	protected override bool CreatePrefab()
	{
		return false;
	}

	public void OnSelectEquip(ItemBar target)
	{
	}

	public void OnDetailItem(ItemBar target)
	{
	}

	private EquipData GetEquipData()
	{
		return null;
	}

	private void InitEquipStatus(InventoryInfo inv)
	{
	}

	public void Init(EEquipKind kind, int part, CharaDetail chara, InventoryInfo select, List<InventoryInfo> enableList, List<InventoryInfo> equiped, bool visualMode)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	private string GetSortPrefix()
	{
		return null;
	}

	private ESortKind GetDefaultSortKind()
	{
		return ESortKind.eNO;
	}

	private void LoadSort()
	{
	}

	private void OnSortDecide(bool update)
	{
	}

	private void MakeDispList()
	{
	}

	public void OnFilter()
	{
	}

	public void OnSort()
	{
	}

	private ECategory GetSelectCategory(EEquipPart part)
	{
		return ECategory.eNONE;
	}
}
