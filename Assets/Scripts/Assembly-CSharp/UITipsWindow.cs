using System;
using UnityEngine;

public class UITipsWindow : MonoBehaviour
{
	public UILabel m_sTitleLabel;

	public UILabel m_sLabel;

	public GameObject m_uCloseButton;

	public UITweenReset m_sAnim;

	private bool m_bClicked;

	protected Action m_sCallback;

	public static UITipsWindow CreateOKTipsWindow(string title, string content, Action callback = null)
	{
		return null;
	}

	public void Init(string title, string content, string button, Action callback)
	{
	}

	public void OnClickedOK()
	{
	}

	public void OnEnd()
	{
	}
}
