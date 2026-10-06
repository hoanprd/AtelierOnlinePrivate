using System;
using System.Collections.Generic;
using UnityEngine;

public class CompositeConfirmDialog : UIWrapListBase
{
	[SerializeField]
	private UILabel m_sSelectNum;

	private List<CompositeMaterial> m_vFeeds;

	private List<CompositeListItem> m_vList;

	private Action<EButtonKind> m_sOnResult;

	public void Init(Action<EButtonKind> onResult, List<CompositeMaterial> mat)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	protected override void InitItem(int line, GameObject target)
	{
	}
}
