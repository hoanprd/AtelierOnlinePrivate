using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class GlobalCoroutine : MonoBehaviour
{
	public static void Go(IEnumerator coroutine)
	{
	}

	[DebuggerHidden]
	private IEnumerator Do(IEnumerator src)
	{
		return null;
	}
}
