using System.Collections.Generic;
using UnityEngine;

public class DialogGachaBenefits : UIWindowBase
{
	[SerializeField]
	private UIGrid m_trItemBarRootGrid;

	public void Init(List<PresentInfo> rewards)
	{
	}

	public void OnDecide()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public static DialogGachaBenefits Create()
	{
		return null;
	}
}
