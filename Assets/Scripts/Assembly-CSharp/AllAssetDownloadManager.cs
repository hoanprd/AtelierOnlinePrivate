using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AllAssetDownloadManager : UIWindowBase
{
	[SerializeField]
	private GameObject m_goConfirm;

	[SerializeField]
	private GameObject m_goProgress;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UILabel m_sConfirmText;

	[SerializeField]
	private UISlider m_sProgess;

	[SerializeField]
	private UILabel m_sInfoLabel;

	private List<VersionData> m_vDownloadList;

	private bool m_bDownloadComplete;

	private Action<bool> m_sOnClose;

	public void Init(string content, List<VersionData> list, Action<bool> onClose)
	{
	}

	public void Init()
	{
	}

	private void CalcFileSize()
	{
	}

	public void OnDownloadStart()
	{
	}

	[DebuggerHidden]
	private IEnumerator Exec()
	{
		return null;
	}

	protected override void OnCloseEnd()
	{
	}

	public static AllAssetDownloadManager Create(Transform root = null)
	{
		return null;
	}
}
