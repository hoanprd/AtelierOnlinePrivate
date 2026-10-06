using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestDeliveryManager : MonoBehaviour
{
	public UIButton m_sButton;

	public Transform m_trItemSelectRoot;

	public GameObject m_goItemSelectPrefab;

	public Transform m_trItemDetailRoot;

	private ItemSelectWindow m_sSelectWindow;

	private ItemDetailWindow m_sItemDetailWindow;

	private int m_iMinNum;

	private int m_iMaxNum;

	private Action<bool, List<InventoryInfo>> m_sCallback;

	private bool m_bDecide;

	public void Init(int material_id, List<InventoryInfo> inv, int minNum, int maxNum, Action<bool, List<InventoryInfo>> callback)
	{
	}

	public void OnDecide()
	{
	}

	private void Decide()
	{
	}

	public void ConfirmResult(EButtonKind result)
	{
	}

	public void OnExit(List<InventoryInfo> selection)
	{
	}

	public void OnDetail(InventoryInfo material)
	{
	}

	private void Update()
	{
	}

	public static QuestDeliveryManager Create(Transform root)
	{
		return null;
	}
}
