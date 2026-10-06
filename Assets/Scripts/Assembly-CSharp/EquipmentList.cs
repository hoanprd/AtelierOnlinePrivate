using System;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentList : MonoBehaviour
{
	[Serializable]
	public class ButtonInfo
	{
		public GameObject goReccomendButton;

		public UIGrid sGrid;
	}

	public GameObject m_goTabRoot;

	public EquipmentListTab[] m_asTabList;

	public ButtonInfo m_sButton;

	public UILabel m_sPower;

	public GameObject m_goMainRoot;

	public EquipmentListItem m_sMainPrefab;

	public List<EquipmentListItem> m_vMainEquipListItem;

	public GameObject m_goSubRoot;

	public UILabel m_sSubEquipNum;

	public UILabel m_sSubEquipMaxNum;

	public UIGrid m_sSubGrid;

	public UIScrollView m_sSubScrollView;

	public EquipmentSubListItem m_sSubPrefab;

	private List<EquipmentSubListItem> m_vSubEquipListItem;

	public EEquipKind m_eKind;

	private CharaDetail m_sTargetChara;

	private List<InventoryInfo> m_sInventoryList;

	private EEquipStatusKind m_eDispKind;

	private bool m_bVisualMode;

	public EEquipKind Kind
	{
		get
		{
			return EEquipKind.eMAIN;
		}
	}

	public void Init()
	{
	}

	public void OnChangeTab(EEquipKind kind)
	{
	}

	private void InitTab()
	{
	}

	private void OnEnable()
	{
	}

	public void OnChangeStatusKind()
	{
	}

	public void Init(CharaDetail chara, List<InventoryInfo> inventories, bool visualMode, EEquipKind kind, bool reset = false)
	{
	}

	public void Init(CharaDetail chara, List<InventoryInfo> inventories, bool visualMode, bool reset = false)
	{
	}

	private void SetMode()
	{
	}

	private void InitMain(CharaDetail chara)
	{
	}

	private void InitSub(CharaDetail chara)
	{
	}
}
