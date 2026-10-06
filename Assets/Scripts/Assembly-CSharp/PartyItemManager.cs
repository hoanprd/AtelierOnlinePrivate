using System.Collections.Generic;
using UnityEngine;

public class PartyItemManager : UIListViewBase<PartyItemListItem>
{
	public enum EKind
	{
		eMANUAL = 0,
		eAUTO = 1
	}

	[SerializeField]
	private AnimationController[] m_asAnim;

	[SerializeField]
	private GameObject m_goItemSelectRoot;

	[SerializeField]
	private SpawnPrefabData m_sItemSelect;

	[SerializeField]
	private UILabel m_sNotes;

	private InventoryList m_sInventory;

	private PartyItemInfo m_sInfo;

	private EKind m_eKind;

	private PartyItemListItem m_sSelectItem;

	private List<long> m_vRepositList;

	private List<long> m_vBringList;

	private bool m_bDecide;

	private PartyEditRequest m_sRequest;

	private Transform m_trDetailRoot;

	private const int ciTOGGLE_GROUP = 4;

	private void OnDisable()
	{
	}

	public void Init(InventoryList inv, PartyItemInfo info, PartyEditRequest req, Transform detailRoot)
	{
	}

	public void ChangeTab(PartyItemTab select)
	{
	}

	public void OnSelectItem(PartyItemListItem target)
	{
	}

	public void OnDecideSelection()
	{
	}

	public void OnDetailKind(ItemBar target)
	{
	}

	public void OnAlter(PartyItemListItem target)
	{
	}

	public void OnClose()
	{
	}

	private void UpdateInfo()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnCloseSelectWindow(List<int> selection)
	{
	}

	private void InitList()
	{
	}

	private void InitAuto()
	{
	}

	private void InitManual()
	{
	}

	private int GetHaveCount(int df)
	{
		return 0;
	}

	private PartyItemListItem.EAlterState IsAlter(int df)
	{
		return PartyItemListItem.EAlterState.eNONE;
	}
}
