using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class EffectCoroutine : MonoBehaviour
{
	private float m_timer;

	public void StartCoroutine(float time = 2f)
	{
	}

	private void OnDisable()
	{
	}

	[DebuggerHidden]
	public IEnumerator DestroyCoroutine(float time)
	{
		return null;
	}
}
