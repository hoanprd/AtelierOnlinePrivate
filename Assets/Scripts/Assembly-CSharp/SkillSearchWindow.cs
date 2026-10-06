using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillSearchWindow : UIWindowBase
{
	public enum EStatus
	{
		eSELECT = 0,
		eSKILLLIST = 1,
		eITEMLIST = 2,
		eNUM = 3
	}

	public enum EInventoryKind
	{
		eEQUIP = 0,
		eMATERIAL = 1,
		eALL = 2
	}

	[SerializeField]
	private UILabel m_sSpoonNum;

	[SerializeField]
	private GameObject[] m_agoWindow;

	[SerializeField]
	private GameObject m_goMenu;

	[SerializeField]
	private UILabel m_sMenuTitle;

	[SerializeField]
	private SkillSearchCategoryList m_sCategoryList;

	[SerializeField]
	private SkillSearchInventoryList m_sInventoryList;

	[SerializeField]
	private GameObject m_goSelectedPrefab;

	[SerializeField]
	private Transform m_trSelectedItemRoot;

	[SerializeField]
	private GameObject m_goSelectedItemRoot;

	private SkillSearchInventoryItem m_sSelectedInfo;

	private List<EStatus> m_veStatusLog;

	private EStatus m_ePrevStatus;

	private EStatus m_eStatus;

	private EInventoryKind m_eInventoryKind;

	private Action<InventoryInfo> m_sOnClose;

	private List<InventoryInfo> m_vTraitList;

	private InventoryInfo m_sSelectItem;

	private Transform m_trSortRoot;

	private Dictionary<long, int> m_mExternalCostInfo;

	public void Init(List<InventoryInfo> trait, InventoryInfo select, Action<InventoryInfo> onClose, Transform sortRoot, Dictionary<long, int> externalCostInfo = null)
	{
	}

	public void OnSkillFromEquip()
	{
	}

	public void OnSkillFromMaterial()
	{
	}

	public void OnSelectFromEquip()
	{
	}

	public void OnSelectFromMaterial()
	{
	}

	public void OnSelectCategory()
	{
	}

	public void OnDecide()
	{
	}

	public void OnBack()
	{
	}

	public void OnRemoveNow()
	{
	}

	private void BackStatus()
	{
	}

	private void NextStatus(EStatus stat)
	{
	}

	private void SetStatus(EStatus stat, bool force = false)
	{
	}

	protected override void OnCloseEnd()
	{
	}
}
