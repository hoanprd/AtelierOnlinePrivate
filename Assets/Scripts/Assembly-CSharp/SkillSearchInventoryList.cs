using System.Collections.Generic;
using UnityEngine;

public class SkillSearchInventoryList : UIWrapListBase
{
	[SerializeField]
	private GameObject m_goEquipTab;

	[SerializeField]
	private UIButton m_sDecideButton;

	[SerializeField]
	private SkillSearchSubCategoryTab[] m_EquipTab;

	private bool m_bBySkill;

	private ECategory m_eCategory;

	private List<int> m_viSkillList;

	private List<InventoryInfo> m_vInventoryList;

	private List<InventoryInfo> m_vDispInventoryList;

	private InventoryInfo m_sSelect;

	private SkillSearchWindow.EInventoryKind m_eInventoryKind;

	private SkillSearchInventoryItem m_sSelectDetail;

	private ItemDetailWindow m_sDetailWindow;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private Transform m_trSortWindowRoot;

	[SerializeField]
	private UILabel m_sFilterName;

	private SortFilterWindow m_sSortFilterWindow;

	private EFilterKind m_eFilterKind;

	private ESortKind m_eSortKind;

	private EOrder m_eOrderKind;

	private Dictionary<long, int> m_mExternalCostInfo;

	private const string SORT_PREFIX = "SKILLSEARCH_";

	public InventoryInfo SelectItem
	{
		get
		{
			return null;
		}
	}

	public void Init(SkillSearchWindow.EInventoryKind invKind, List<InventoryInfo> inv, InventoryInfo sel, Transform sortRoot, Dictionary<long, int> externalCostInfo = null)
	{
	}

	public void Init(SkillSearchWindow.EInventoryKind invKind, List<int> skillList, List<InventoryInfo> inv, InventoryInfo sel, Transform sortRoot, Dictionary<long, int> externalCostInfo = null)
	{
	}

	private void InitTab(SkillSearchWindow.EInventoryKind invKind, List<InventoryInfo> inv)
	{
	}

	private void MakeList()
	{
	}

	public int GetExternalCost(long ID)
	{
		return 0;
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	public void OnChangeTab(ECategory category)
	{
	}

	public void OnDetail(SkillSearchInventoryItem inv)
	{
	}

	private void OnCloseDetail(InventoryList updateInventory, int updateFav, int gotoAlter)
	{
	}

	public void OnSelect(SkillSearchInventoryItem inv)
	{
	}

	public void OnSortButton()
	{
	}

	public void OnFilterButton()
	{
	}

	private ESortKind GetDefaultSortKind()
	{
		return ESortKind.eNO;
	}

	public void LoadSort()
	{
	}

	private void OnSortDecide(bool update)
	{
	}
}
