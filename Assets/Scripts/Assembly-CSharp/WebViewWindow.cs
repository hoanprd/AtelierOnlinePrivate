using System;
using UnityEngine;

public class WebViewWindow : MonoBehaviour
{
	public UITweenReset m_sAnim;

	public UIButton m_sCloseButton;

	public UITexture m_txDispArea;

	[HideInInspector]
	public string m_Url;

	private Action<string> m_finishCallback;

	private WebViewObject m_sWebViewObject;

	private static WebViewWindow sInstance;

	public void Init(string url, Action<string> finishCallback = null)
	{
	}

	private void OnError(string error)
	{
	}

	private void SetMargin()
	{
	}

	private void OnOpenEnd()
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnClose()
	{
	}

	public void CallBack(string message)
	{
	}

	private void CallFinishCallback(string result)
	{
	}

	public static WebViewWindow Create()
	{
		return null;
	}
}
