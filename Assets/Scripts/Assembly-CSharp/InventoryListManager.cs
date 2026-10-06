using System.Collections.Generic;
using UnityEngine;

public class InventoryListManager : MonoBehaviour
{
	public enum EInventoryEditKind
	{
		eLIST = 0,
		eDISPOSE = 1,
		eDROP = 2,
		eRESTORE = 3,
		eBRING = 4
	}

	[SerializeField]
	private AnimationController[] m_sAnim;

	[SerializeField]
	private InventoryListView m_sList;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private InventoryMainTab[] m_asMainTabList;

	[SerializeField]
	private UIButton m_sBackButton;

	[SerializeField]
	private GameObject m_goListButton;

	[SerializeField]
	private GameObject m_goDisposeDropButton;

	[SerializeField]
	private GameObject m_goRestoreButton;

	[SerializeField]
	private Transform m_trItemDetailRoot;

	[SerializeField]
	private UILabel[] m_asSelectNum;

	[SerializeField]
	private UILabel[] m_asDisposeValue;

	[SerializeField]
	private UILabel[] m_asDisposeText;

	[SerializeField]
	private UILabel m_sDisposeInfoText;

	[SerializeField]
	private UIButton m_sDisposeButton;

	[SerializeField]
	private InventoryListRestoreList m_sRestoreList;

	private EInventoryMainTabKind m_eTabKind;

	private EInventoryEditKind m_eStartEditKind;

	private EInventoryEditKind m_eEditKind;

	private EInventoryEditKind m_eDropKind;

	private bool m_bField;

	private InventoryList m_sInventories;

	private ItemDetailWindow m_sItemDetailWindow;

	private ItemBar m_sDetailTarget;

	private bool m_bEnableBack;

	private List<InventoryInfo> m_sCeilItemes;

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public bool IsEnd()
	{
		return false;
	}

	public void Init(InventoryList inv, EInventoryEditKind kind = EInventoryEditKind.eLIST, bool enableBack = true)
	{
	}

	private List<InventoryInfo> GetInventoryList()
	{
		return null;
	}

	private void UpdateInfo()
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnChangeTab(EInventoryMainTabKind categ)
	{
	}

	public void OnDetail(ItemBar inventory)
	{
	}

	private void OnCloseDetail(InventoryList addInventory, int updateFav, int gotoAlter)
	{
	}

	private void OnAlterEnd(bool execute, List<InventoryInfo> createList, List<InventoryInfo> useList)
	{
	}

	public void OnSelect(ItemBar item)
	{
	}

	public void OnSelectAll()
	{
	}

	public void OnRestoreList()
	{
	}

	private void SetMode(EInventoryEditKind kind)
	{
	}

	public void OnChangeModeDisposeOrDrop()
	{
	}

	public void OnRestore()
	{
	}

	public void OnDisposeOrDrop()
	{
	}

	private void OnDrop()
	{
	}

	private void OnDispose()
	{
	}

	public void OnExpansion()
	{
	}

	private void OnExpansionFinish(InventoryEnlargeResponse res)
	{
	}
}
