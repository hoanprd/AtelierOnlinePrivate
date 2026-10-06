using System.Collections.Generic;
using UnityEngine;

public abstract class EquipmentParamBase : MonoBehaviour
{
	public UIGrid m_sGrid;

	public GameObject m_sPrefab;

	protected bool m_bInit;

	protected CharaSpec m_sRowSpec;

	protected CharaSpec m_sExtraSpec;

	protected void Create()
	{
	}

	protected abstract void CreateList();

	protected abstract void SetValue();

	protected abstract void SetDiffValue(CharaDetail now, List<InventoryInfo> inv);

	protected void CalcSpec(CharaDetail detail, List<InventoryInfo> inv, out CharaSpec rowSpec, out CharaSpec extraSpec)
	{
		rowSpec = null;
		extraSpec = null;
	}

	public void Init(CharaDetail detail, List<InventoryInfo> inv)
	{
	}

	public void InitDiff(CharaDetail now, List<InventoryInfo> inv)
	{
	}
}
