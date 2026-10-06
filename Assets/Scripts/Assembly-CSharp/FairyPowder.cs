using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FairyPowder : MonoBehaviour
{
	public static bool s_bUpdateFairy;

	private Coroutine m_clsCoroutine;

	private DateTime m_clsEndTime;

	private bool m_bUseFairy;

	private int m_iTotalSeconds_Log;

	[SerializeField]
	private UIButton m_scrFairyButton;

	[SerializeField]
	private List<GameObject> m_goActiveObjList;

	[SerializeField]
	private List<UILabel> m_scrEndTimeLabelList;

	public void OnClickedButton()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void SetActiveFairyObj(bool bActive)
	{
	}

	private void SetEndTimeLabel(string strText)
	{
	}

	private void OnYNDialog(EButtonKind eResult)
	{
	}

	[DebuggerHidden]
	private IEnumerator UseFairyPowder()
	{
		return null;
	}
}
