using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class TreasureResultObserver : MonoBehaviour
{
	public void Init(HuntInfo info, HuntResult result, Action onFinish)
	{
	}

	[DebuggerHidden]
	private IEnumerator Execute(HuntInfo info, HuntResult result, Action onFinish)
	{
		return null;
	}
}
