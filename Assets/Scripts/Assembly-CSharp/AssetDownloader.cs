using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AssetDownloader : MonoBehaviour
{
	private Dictionary<VersionData, string> m_vErrorInfo;

	private float m_fProgress;

	private bool m_bCancel;

	private bool m_bEnd;

	private List<VersionData> m_vRequestList;

	private int m_iRequestIndex;

	private int m_iCompleteCount;

	private int m_iConcurrency;

	private List<AssetDownloaderOne> m_vDownloader;

	public float Progress
	{
		get
		{
			return 0f;
		}
	}

	public bool IsEnd
	{
		get
		{
			return false;
		}
	}

	public bool IsCancel
	{
		get
		{
			return false;
		}
	}

	public bool IsError
	{
		get
		{
			return false;
		}
	}

	public void Execute(List<VersionData> request, int concurrency = 3)
	{
	}

	private void Update()
	{
	}

	protected void Init(List<VersionData> request, int concurrency)
	{
	}

	[DebuggerHidden]
	protected IEnumerator Download()
	{
		return null;
	}

	private void Next()
	{
	}
}
