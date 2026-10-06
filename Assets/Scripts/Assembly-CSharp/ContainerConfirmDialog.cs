using System;
using System.Collections.Generic;
using UnityEngine;

public class ContainerConfirmDialog : UIWrapListBase
{
	[SerializeField]
	private UILabel m_sMessage;

	[SerializeField]
	private UILabel m_sSelectNum;

	[SerializeField]
	private UITweenReset m_sAnim;

	private List<InventoryInfo> m_vItemList;

	private Action<bool> m_sOnDdecideEvent;

	private bool m_bDecide;

	private GameObject m_sCollider;

	private const int ciITEM_MAX = 5;

	public void Init(string boxName, List<InventoryInfo> inv, Action<bool> onDecide)
	{
	}

	private void OnBringinFinish()
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	private void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
