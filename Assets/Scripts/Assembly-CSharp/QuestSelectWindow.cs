using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestSelectWindow : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_scrTween;

	[SerializeField]
	private QuestSelectBarList m_scrBarList;

	private Action<EButtonKind, int> m_acCallback;

	private EButtonKind m_eButtonKind;

	private int m_iSelectDF;

	public static QuestSelectWindow Create(Transform trRoot)
	{
		return null;
	}

	public void Init(List<int> iDFList, Action<EButtonKind, int> acCallback)
	{
	}

	public void Dismiss()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void OnClickBar(QuestSelectBar scrBar)
	{
	}

	public void OnClose()
	{
	}

	public void OnEndDismiss()
	{
	}

	private void Awake()
	{
	}
}
