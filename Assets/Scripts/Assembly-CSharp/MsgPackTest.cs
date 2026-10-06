using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class MsgPackTest : MonoBehaviour
{
	[Serializable]
	public class Unique
	{
		[Serializable]
		public class UrlInfo
		{
			public string API;

			public string WEB;

			public string ASS;
		}

		public UrlInfo URL;
	}

	[Serializable]
	public class APIOverride : ResponseDataCommon
	{
		public Unique API;
	}

	[Serializable]
	private class Request
	{
		public int PLAT;

		public int CV;
	}

	public Text m_sLogText;

	private string m_sLog;

	private void OnGUI()
	{
	}

	[DebuggerHidden]
	private IEnumerator ServerStatus()
	{
		return null;
	}

	public string Analysis(byte[] msgpack)
	{
		return null;
	}

	public string GetAPI()
	{
		return null;
	}

	public virtual string GetDebug(string time, bool ignore_session)
	{
		return null;
	}
}
