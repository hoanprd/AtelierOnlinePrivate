using System;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class AsyncLocalFileLoader : MonoBehaviour
{
	private Thread m_Thread;

	private string m_sPath;

	private Action<string> m_Callback;

	private string m_sContent;

	private bool m_bSendCallBack;

	private bool m_bDestroyGameObject;

	private Stopwatch m_sStopWatch;

	public void Exec(string path, bool destroy, Action<string> callback)
	{
	}

	private void OnDestroy()
	{
	}

	private void ThreadWork()
	{
	}

	private void Update()
	{
	}

	public static GameObject Regist(string path, bool destroy, Action<string> callback = null)
	{
		return null;
	}
}
