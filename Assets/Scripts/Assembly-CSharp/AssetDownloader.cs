using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AssetDownloader : MonoBehaviour
{
	private Dictionary<VersionData, string> m_vErrorInfo = new Dictionary<VersionData, string>();

	private float m_fProgress;

	private bool m_bCancel;

	private bool m_bEnd;

	private List<VersionData> m_vRequestList = new List<VersionData>();

	private int m_iRequestIndex;

	private int m_iCompleteCount;

	private int m_iConcurrency = 3;

	private List<AssetDownloaderOne> m_vDownloader = new List<AssetDownloaderOne>();

	public float Progress
	{
		get
		{
			return m_fProgress;
		}
	}

	public bool IsEnd
	{
		get
		{
			return m_bEnd;
		}
	}

	public bool IsCancel
	{
		get
		{
			return m_bCancel;
		}
	}

	public bool IsError
	{
		get
		{
			return m_vErrorInfo != null && m_vErrorInfo.Count > 0;
		}
	}

	public void Execute(List<VersionData> request, int concurrency = 3)
	{
		Init(request, concurrency);
		StartCoroutine(Download());
	}

	private void Update()
	{
	}

	protected void Init(List<VersionData> request, int concurrency)
	{
		if (m_vErrorInfo == null)
		{
			m_vErrorInfo = new Dictionary<VersionData, string>();
		}
		else
		{
			m_vErrorInfo.Clear();
		}
		m_vRequestList = request ?? new List<VersionData>();
		m_iConcurrency = Mathf.Max(1, concurrency);
		m_iRequestIndex = 0;
		m_iCompleteCount = 0;
		m_bCancel = false;
		m_bEnd = false;
		m_fProgress = 0f;
	}

	[DebuggerHidden]
	protected IEnumerator Download()
	{
		// Offline Client Mode: complete asset check cleanly using local assets
		yield return null;
		m_iCompleteCount = (m_vRequestList != null) ? m_vRequestList.Count : 0;
		m_fProgress = 1f;
		m_bEnd = true;
	}

	private void Next()
	{
	}
}
