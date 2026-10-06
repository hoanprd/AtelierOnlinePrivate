using System;
using System.Collections.Generic;
using UnityEngine;

public class CompositeManager : MonoBehaviour
{
	public enum EKind
	{
		eRESPIRE = 0,
		eFORGE = 1,
		eOVERWRITE = 2,
		eFLOOD = 3
	}

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private AnimationController m_sKindSelect;

	[SerializeField]
	private AnimationController m_sItemSelectAnim;

	[SerializeField]
	private GameObject m_goItemSelectRoot;

	[SerializeField]
	private Transform m_trItemDetailRoot;

	private int m_iPageNum;

	[SerializeField]
	private UIWrapScrollBar m_sScrollBar;

	[SerializeField]
	private UIWrapContent m_sWrapContent;

	[SerializeField]
	private UIScrollView m_sScroll;

	[SerializeField]
	private GameObject m_goListItemPrefab;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private UILabel m_sFiltername;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UILabel m_sMessage;

	[SerializeField]
	private UILabel m_sTotalNum;

	[SerializeField]
	private GameObject m_goTabRoot;

	[SerializeField]
	private GameObject m_goNoneText;

	[SerializeField]
	private RecipeListTabItem[] m_asMaterialTab;

	[SerializeField]
	private UILabel m_sKindName;

	[SerializeField]
	private OverwriteSkillWindow m_sOverwriteDialog;

	[SerializeField]
	private CompositeExecuteDialog m_sExecuteDialog;

	[SerializeField]
	private CompositeKindButton[] m_asCategoryButton;

	private List<CompositeListItem> m_vListItem;

	private List<InventoryInfo> m_vInventory;

	private List<InventoryInfo> m_vDispList;

	private EKind m_eKind;

	private ECategory m_eCategory;

	private MasterItem m_sSelectInventory;

	private List<int> m_vKindList;

	private ItemDetailWindow m_sItemDetailWindow;

	private SortFilterWindow m_sSortFilterWindow;

	private bool m_bKind;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private Action m_sOnExit;

	private bool m_bCloseNow;

	private const string SORT_PREFIX = "COMPOSITE_";

	private const int ciDISP_ITEM_MAX = 2;

	private void Awake()
	{
	}

	public void Init(Action onExit = null)
	{
	}

	public void OnSelectCompositeKind(EKind kind)
	{
	}

	private void OnReceiveSummary(ResponseDataCommon res)
	{
	}

	private void InitSelectKind()
	{
	}

	private void InitState()
	{
	}

	private void CreateKindList()
	{
	}

	private void CreateInventoryList(MasterItem master, List<InventoryInfo> list)
	{
	}

	private void CreateAllList()
	{
	}

	private void InitLine(int line, CompositeListItem target)
	{
	}

	private void InitInventoryLine(int line, CompositeListItem target)
	{
	}

	private void OnLoopItem(GameObject go, int wrawpIndex, int realIndex)
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnBack(InventoryInfo target, List<long> removeList)
	{
	}

	private void LoadSort()
	{
	}

	private void OnSortDecide(bool update)
	{
	}

	private void OnItemSelectInAnimEnd()
	{
	}

	private ESortKind GetDefaultSortKind()
	{
		return ESortKind.eNO;
	}

	public void OnSortButton()
	{
	}

	public void OnFilterButton()
	{
	}

	public void OnChangeCategory(ECategory categ)
	{
	}

	public void OnDetail(ItemBar inv)
	{
	}

	public void OnDetail(InventoryInfo inv)
	{
	}

	public void OnDetailKind(MasterItem master)
	{
	}

	public void OnClose()
	{
	}

	public void OnBackKindList()
	{
	}

	public void OnSelectKind(CompositeKindItem item)
	{
	}

	public void OnSelectInventory(ItemBar item)
	{
	}
}
