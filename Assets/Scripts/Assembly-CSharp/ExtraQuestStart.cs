using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ExtraQuestStart : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sQuestTitle;

	[SerializeField]
	private AnimationController m_sAnim;

	private Action m_callback;

	private bool m_isActive;

	private bool m_isFinishInAnimation;

	private void Update()
	{
	}

	public void Init(int questDF, Action callback)
	{
	}

	public void OnEndDismiss()
	{
	}

	[DebuggerHidden]
	private IEnumerator PlayInAnimation(float waitTime)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator PlayOutAnimation(float waitTime)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator StartSE()
	{
		return null;
	}

	public static ExtraQuestStart Create(Transform root)
	{
		return null;
	}

	public static void ExecAnimaiton(Transform root, int questDF, Action callback = null)
	{
	}
}
