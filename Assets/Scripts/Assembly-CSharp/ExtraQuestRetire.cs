using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ExtraQuestRetire : MonoBehaviour
{
	public delegate void CallBackMethod();

	[SerializeField]
	private AnimationController m_sAnim;

	private bool m_isActive;

	private bool m_isFinishInAnimation;

	public CallBackMethod m_callBack;

	private void Update()
	{
	}

	public void Init()
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
	private IEnumerator RetireSE()
	{
		return null;
	}

	public static ExtraQuestRetire Create(Transform parent)
	{
		return null;
	}

	public static void StartAnimation(Transform parent, CallBackMethod callBack)
	{
	}
}
