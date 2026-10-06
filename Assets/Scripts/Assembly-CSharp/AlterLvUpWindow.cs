using System;
using UnityEngine;

public class AlterLvUpWindow : MonoBehaviour
{
	public UILabel m_beforeLv;

	public UILabel m_curLv;

	public UITweenReset m_sAnim;

	private Action m_sOnClose;

	public void Init(int beforLv, int curLv, Action onClose = null)
	{
	}

	public void OnDismiss()
	{
	}

	private void OnClose()
	{
	}
}
