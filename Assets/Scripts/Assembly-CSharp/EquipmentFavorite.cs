using System;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentFavorite : MonoBehaviour
{
	private enum EPopupState
	{
		eNONE = 0,
		eEQUIP = 1,
		eRESET = 2,
		eREGIST = 3
	}

	[SerializeField]
	private List<UIToggle> m_vEquipKindToggle;

	public UITexture m_txCharaPic;

	public EquipmentFavDetail m_sDetail;

	public EquipmentFavDetailSub m_sDetailSub;

	public EquipmentFavList m_sList;

	public EquipmentFavListSub m_sListSub;

	public EquipmentFavEditNameWindow m_sNameEdit;

	private EPopupState m_ePopupState;

	private CharaDetail m_sNowEquip;

	private EquipFavoList m_sFavList;

	private List<InventoryInfo> m_vInventory;

	private EEquipKind m_eSelectKind;

	private Action<CharaDetail> m_sOnUpdateEvent;

	public void PreInit(CharaDetail now)
	{
	}

	public void Init(CharaDetail now, EquipFavoList list, List<InventoryInfo> inv, bool visualMode, EEquipKind kind, Action<CharaDetail> onUpdateEvent)
	{
	}

	private void SwitchInit(int selectNo)
	{
	}

	private void FillEquipFavoList(EquipFavoList list)
	{
	}

	private void FillEquipFavoInfo(List<EquipFavoInfo> list, int no)
	{
	}

	private void FillEquipFavoSubInfo(List<EquipFavoSubInfo> list, int no)
	{
	}

	public void OnSwitchMode(UIToggle targetToggle)
	{
	}

	private void ChangeDispList()
	{
	}

	public void OnEditName()
	{
	}

	public void OnEquip()
	{
	}

	public void OnReset()
	{
	}

	public void OnRegist()
	{
	}

	public void OnPopupResult(EButtonKind result)
	{
	}

	private void DispEquipResult()
	{
	}

	private void UpdateFavorite(EquipFavoList list)
	{
	}

	private List<InventoryInfo> ConvertInventoryList()
	{
		return null;
	}
}
