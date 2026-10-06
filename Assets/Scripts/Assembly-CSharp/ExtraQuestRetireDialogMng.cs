using System;
using UnityEngine;

public class ExtraQuestRetireDialogMng : DialogBase
{
	[SerializeField]
	private UILabel m_sDialogText;

	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private GameObject m_goCloseBtn;

	[SerializeField]
	private GameObject m_goTimeLimt;

	protected Action m_sCallBack;

	private bool m_bTimeLimit;

	private bool m_isOwner;

	private void SetDialogText(string txt)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	public void OnAnimationEnd()
	{
	}

	public void ActivateTimeLimit()
	{
	}

	private void CloseWindow()
	{
	}

	private void Start()
	{
	}

	public static ExtraQuestRetireDialogMng CreateRetireDialog(string txt, bool isOwner = false, Action callBack = null, bool timeLimit = false)
	{
		return null;
	}
}
