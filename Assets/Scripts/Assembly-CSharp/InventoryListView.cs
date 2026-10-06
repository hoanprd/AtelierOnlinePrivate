using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryListView : MonoBehaviour
{
	[Serializable]
	public abstract class ListItemInfo<T>
	{
		public UIScrollView sScrollList;

		public UIDragScrollView sDrag;

		public UIWrapContent sWrapContent;

		public GameObject goPrefab;

		public UIWrapScrollBar sScrollBar;

		[HideInInspector]
		public List<T> vLineList;

		[HideInInspector]
		public List<ItemBar> vInventoryList;

		public bool Enable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Create()
		{
		}

		public void Init(int lineNum, UIWrapContent.OnInitializeItem onInitializeItem)
		{
		}

		public void SetEnableSelectButton(bool sw)
		{
		}

		protected abstract void Clear();
	}

	[Serializable]
	public class RestoreItemList : ListItemInfo<InventoryListRestoreItem>
	{
		protected override void Clear()
		{
		}
	}

	[SerializeField]
	private InventoryNormalListView m_sNormalList;

	[SerializeField]
	private RestoreItemList m_sRestore;

	[SerializeField]
	private Transform m_trSortWindowRoot;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private UILabel m_sFilterName;

	[SerializeField]
	private GameObject m_goNoneMark;

	[SerializeField]
	protected UILabel m_sCount;

	protected bool m_bRestore;

	protected InventoryListManager.EInventoryEditKind m_eEditMode;

	protected ECategory m_eMainCategory;

	protected ESubCategory m_eSubCategory;

	protected List<InventoryInfo> m_vInventories;

	private int m_iHaveNum;

	private int m_iLimitNum;

	private List<InventoryListRestoreItem> m_vRestoreList;

	private List<InventoryInfo> m_vDispInventories;

	private int m_iLineNum;

	private List<InventoryInfo> m_vSelectList;

	private EInventoryMainTabKind m_eFilterGroup;

	private SortFilterWindow m_sSortFilterWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private ItemBarEvent m_sSelectEvent;

	private ItemBarEvent m_sDetailEvent;

	private const string SORT_PREFIX = "INVENTORY_";

	public List<InventoryInfo> SelectList
	{
		get
		{
			return null;
		}
	}

	public int ItemNum
	{
		get
		{
			return 0;
		}
	}

	public void ResetSelect()
	{
	}

	public virtual void UpdateLimit(int limit)
	{
	}

	public void InitEvent(ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}

	public void SetMode(InventoryListManager.EInventoryEditKind editKind)
	{
	}

	public void Init(InventoryListManager.EInventoryEditKind editKind, EInventoryMainTabKind kind, int limit, List<InventoryInfo> inventories)
	{
	}

	public void UpdateInventory(List<InventoryInfo> inventories)
	{
	}

	public void Init(EInventoryMainTabKind kind)
	{
	}

	private void Init()
	{
	}

	public bool SelectAll()
	{
		return false;
	}

	public void Select(ItemBar item)
	{
	}

	private void Awake()
	{
	}

	public void CreateRestoreList(List<InventoryInfo> list)
	{
	}

	public void CreateList(List<InventoryInfo> list)
	{
	}

	public void OnLoopRestoreItem(GameObject target, int wrapIndex, int realIndex)
	{
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

	public void OnSortButton()
	{
	}

	public void OnFilterButton()
	{
	}
}
