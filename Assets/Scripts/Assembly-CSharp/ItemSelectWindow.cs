using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelectWindow : MonoBehaviour
{
	private enum EState
	{
		eINVENTORY = 0,
		eKIND = 1
	}

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private GameObject m_goPagePrefab;

	[SerializeField]
	private Transform m_trPageRoot;

	[SerializeField]
	private UIWrapContent m_sWrapContent;

	[SerializeField]
	private UIScrollView m_sScrollView;

	[SerializeField]
	private GameObject[] m_agoArrow;

	[SerializeField]
	private UIWrapScrollBar m_sScrollBar;

	[SerializeField]
	private GameObject m_goNoneText;

	[SerializeField]
	private UILabel m_sNeedNum;

	[SerializeField]
	private UILabel m_sHaveNum;

	[SerializeField]
	private UILabel m_sItemName;

	[SerializeField]
	private UISprite m_sItemNamePlate;

	[SerializeField]
	private UIButton m_sBackButton;

	[SerializeField]
	private UIButton m_sSortButton;

	private List<ItemSelectPage> m_vPageList;

	private EState m_eState;

	private int m_iPageMax;

	private List<long> m_viContentList;

	private List<int> m_viKind;

	private List<int> m_viCategory;

	private bool m_bDesc;

	private bool m_bInventoryOnly;

	private int m_iMinNum;

	private int m_iMaxNum;

	private int m_iPrevPage;

	private bool m_bSelectKindOnly;

	private List<int> m_viSelectKind;

	private List<InventoryInfo> m_vSelectItemList;

	private List<InventoryInfo> m_vPrevSelectItemList;

	private List<InventoryInfo> m_vInventoryList;

	private Action<List<InventoryInfo>> m_sExitCallback;

	private Action<List<int>> m_sKindExitCallback;

	private Vector2 m_vScrollPosition;

	private Vector3 m_vScrollY;

	private Transform m_trItemDetailRoot;

	private bool m_bInit;

	private const int ciITEM_MAX = 2;

	private ItemBar m_sDetailTarget;

	public Transform DetailRoot
	{
		set
		{
		}
	}

	public int NeedNum
	{
		get
		{
			return 0;
		}
	}

	public List<InventoryInfo> Selection
	{
		get
		{
			return null;
		}
	}

	public MasterItem MasterItem
	{
		get
		{
			return null;
		}
	}

	private void Init()
	{
	}

	private void OnClose()
	{
	}

	public void OnBackButton()
	{
	}

	public void OnCloseButton()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	private void CreatePage()
	{
	}

	private List<InventoryInfo> GetInventoryList(List<long> idList)
	{
		return null;
	}

	private void InitPage(ItemSelectPage target, int page)
	{
	}

	private void CreateKind()
	{
	}

	private void CreateInventory(int itemID)
	{
	}

	private void ResetScroll()
	{
	}

	public void OnSelectKind(ItemSelectPageKindItem item)
	{
	}

	public void OnSelectInventory(ItemBar item)
	{
	}

	public void OnDetailItem(ItemBar item)
	{
	}

	public void OnDetailItemKind(ItemSelectPageKindItem target)
	{
	}

	private void OnCloseDetail(InventoryList addInventory, int updateFav, int gotoAlter)
	{
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void SetStrageKind(EStorageKind kind)
	{
	}

	public void InitDelivery(bool desc, int material_id, int selectMin, int selectMax, List<InventoryInfo> inv, Action<List<InventoryInfo>> onExit)
	{
	}

	public void Init(bool desc, List<InventoryInfo> selection, int selectMax, int category, Action<List<InventoryInfo>> onExit)
	{
	}

	public void InitKind(int select, List<int> kind, List<InventoryInfo> list, Action<List<int>> onExit)
	{
	}

	public void InitKind(int select, List<InventoryInfo> list, Action<List<int>> onExit)
	{
	}

	public void Init(bool desc, List<InventoryInfo> list, List<InventoryInfo> selection, int selectMax, Action<List<InventoryInfo>> onExit)
	{
	}
}
