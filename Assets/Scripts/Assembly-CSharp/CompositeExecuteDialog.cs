using System;
using System.Collections.Generic;
using UnityEngine;

public class CompositeExecuteDialog : MonoBehaviour
{
	[SerializeField]
	private AnimationController[] m_asAnim;

	[SerializeField]
	private UILabel m_sCost;

	[SerializeField]
	private CompositeExecuteEffect m_sExecuteEffect;

	[SerializeField]
	private UISprite m_sExecuteIcon;

	[SerializeField]
	private CompositeMaterialInfo m_sMaterialInfo;

	[SerializeField]
	private CompositeEquipInfo m_sEquipInfo;

	[SerializeField]
	private CompositeConfirmDialog m_sConfirm;

	[SerializeField]
	private GameObject m_goLackEther;

	[SerializeField]
	private GameObject m_goListItemPrefab;

	[SerializeField]
	private UIWrapContent m_sWrapContent;

	[SerializeField]
	private UIScrollView m_sScroll;

	[SerializeField]
	private GameObject m_goUpArrow;

	[SerializeField]
	private GameObject m_goDownArrow;

	[SerializeField]
	private GameObject m_goNoneText;

	[SerializeField]
	private UILabel m_sSelectNum;

	[SerializeField]
	private UIWrapScrollBar m_sScrollBar;

	[SerializeField]
	private UISprite m_sCategoryIcon;

	[SerializeField]
	private UILabel m_sItemName;

	[SerializeField]
	private UIButton m_sExecuteButton;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private Transform m_trFilterWindowRoot;

	[SerializeField]
	private UILabel m_sFilterName;

	private bool m_bWeapon;

	private CompositeTarget m_sTarget;

	private int m_iCost;

	private List<CompositeMaterial> m_vFeeds;

	private List<CompositeMaterial> m_vFeedsAll;

	private List<CompositeFeedListItem> m_vList;

	private List<long> m_vSelect;

	private CompositeManager.EKind m_eKind;

	private Action<InventoryInfo, List<long>> m_sOnExit;

	private ItemBarEvent m_sOnDetail;

	private CompositeInfoBase m_sInfo;

	private List<long> m_vRemoveInventoryList;

	private RespireResult m_sResult;

	private SortFilterWindow m_sSortFilterWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private void Awake()
	{
	}

	public void Init(CompositeManager.EKind kind, CompositeInfoResponse res, Action<InventoryInfo, List<long>> onExit, ItemBarEvent onDetail)
	{
	}

	private void MakeList()
	{
	}

	private void MakeDispList()
	{
	}

	private void CalcEXP()
	{
	}

	private void InitLine(int line, CompositeFeedListItem target)
	{
	}

	public void OnClose()
	{
	}

	public void OnExecute()
	{
	}

	public void OnSelect(ItemBar item)
	{
	}

	public void OnReset()
	{
	}

	public void OnRecommend()
	{
	}

	public void OnHelp()
	{
	}

	public void OnOpenFilterWindow()
	{
	}

	public void OnOpenSortWindow()
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

	private void OnConfirmResult(EButtonKind result)
	{
	}

	private void UpdateDirection(RespireResult result)
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnLoopItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void UpdateStatus()
	{
	}

	private void SetSelectNum()
	{
	}
}
