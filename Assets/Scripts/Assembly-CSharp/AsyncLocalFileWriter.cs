using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class AsyncLocalFileWriter : MonoBehaviour
{
	public delegate void Result(bool result, string path);

	private Thread m_Thread;

	private string m_sPath;

	private string m_sContent;

	private Result m_Callback;

	private bool m_bReturn;

	private bool m_bSendCallBack;

	private bool m_bDestroyGameObject;

	private Stopwatch m_sStopWatch;

	public void Exec(string path, string content, bool destroy, Result callback = null)
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

	public static GameObject Regist(string path, string content, bool destroy, Result callback = null)
	{
		return null;
	}
}
