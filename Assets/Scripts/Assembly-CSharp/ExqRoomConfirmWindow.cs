using System;
using UnityEngine;

public class ExqRoomConfirmWindow : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sConfirmTitle;

	[SerializeField]
	private UILabel m_sConfirmText;

	[SerializeField]
	private UITweenReset m_sAnim;

	private Action m_sOnYesEvent;

	private Action m_sOnNoEvent;

	public void Init(string confirm_title, string confirm_text, Action okEvent, Action noEvent = null)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
