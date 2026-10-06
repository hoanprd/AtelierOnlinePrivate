using System.Collections;
using UnityEngine;

public class CoroutineHandler : MonoBehaviour
{
	protected static CoroutineHandler m_Instance;

	public static CoroutineHandler instance
	{
		get
		{
			return null;
		}
	}

	public void OnDisable()
	{
	}

	public static Coroutine StartStaticCoroutine(IEnumerator coroutine)
	{
		return null;
	}

	public static void StopStaticCoroutines(Coroutine coroutine)
	{
	}
}
