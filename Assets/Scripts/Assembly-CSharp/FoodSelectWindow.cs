using System;
using System.Collections.Generic;
using UnityEngine;

public class FoodSelectWindow : MonoBehaviour
{
	[SerializeField]
	private UIButton m_sDecideButton;

	[SerializeField]
	private SpawnPrefabData m_sSelectWindow;

	private ItemSelectWindow m_sWindow;

	public void Init(List<InventoryInfo> list, List<InventoryInfo> select, Transform detailRoot, Action<List<InventoryInfo>> onChoose)
	{
	}

	public void Dismiss()
	{
	}

	private void Update()
	{
	}
}
