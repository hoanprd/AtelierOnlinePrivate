using System;
using UnityEngine;

public class DialogTermOfService : UIWindowBase
{
	private EButtonKind m_eResult;

	private Action<EButtonKind> m_sResultEvent;

	[SerializeField]
	private UILabel m_sText;

	public void Init(Action<EButtonKind> onResult, bool isUpdate)
	{
	}

	public void OnDecide()
	{
	}

	public void OnDispTerms()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public static DialogTermOfService Create()
	{
		return null;
	}
}
