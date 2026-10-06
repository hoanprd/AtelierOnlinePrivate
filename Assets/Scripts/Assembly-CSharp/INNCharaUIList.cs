using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class INNCharaUIList : UIListViewBase<INNCharaUI>
{
	private Action m_acOnEndHeal;

	private Action m_acOnEndDismiss;

	private void Update()
	{
	}

	private bool IsEndHeal()
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator StartBringIn()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator StartDismiss(bool bWhile)
	{
		return null;
	}

	public void MakeObject(List<MultiPlay_CharaMemberData> clsMemberList)
	{
	}

	public void Heal(Action acCallBack)
	{
	}

	public void Dismiss(Action acCallBack, bool bWhile)
	{
	}
}
