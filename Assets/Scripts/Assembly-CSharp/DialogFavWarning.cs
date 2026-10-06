using System;
using System.Collections.Generic;
using UnityEngine;

public class DialogFavWarning : UIWrapListBase
{
	private List<InventoryInfo> m_vInventories;

	private Action<EButtonKind> m_sResultEvent;

	private EButtonKind m_eResult;

	public void Init(List<InventoryInfo> inv, Action<EButtonKind> result)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	public void OnOK()
	{
	}

	public void OnNG()
	{
	}

	private void Close()
	{
	}

	public static DialogFavWarning Create(Transform root)
	{
		return null;
	}
}
