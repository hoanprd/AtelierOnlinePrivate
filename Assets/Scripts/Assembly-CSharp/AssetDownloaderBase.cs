using System.Collections;
using System.Diagnostics;
using UnityEngine;

public abstract class AssetDownloaderBase : MonoBehaviour
{
	protected const float cfTIMEOUT = 60f;

	protected string m_sError = string.Empty;

	protected EDownloadStatus m_eStatus;

	protected EDownloadResult m_eResult = EDownloadResult.eNONE;

	protected bool m_bEnd;

	protected bool m_bCancel;

	protected float m_fProgress;

	protected static DialogCommon sDialog;

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

	public EDownloadResult Result
	{
		get
		{
			return m_eResult;
		}
	}

	public string ErrorMsg
	{
		get
		{
			return m_sError;
		}
	}

	public void Cancel()
	{
		m_bCancel = true;
		SetResult(EDownloadResult.eCANCEL);
	}

	[DebuggerHidden]
	public IEnumerator DispErrorDialog()
	{
		yield break;
	}

	private void SetError(EDownloadResult result)
	{
		m_eResult = result;
		m_bEnd = true;
	}

	protected virtual void Init()
	{
		m_sError = string.Empty;
		m_eStatus = EDownloadStatus.eWAIT;
		m_eResult = EDownloadResult.eNONE;
		m_bEnd = false;
		m_bCancel = false;
		m_fProgress = 0f;
	}

	protected void SetErrorText(string content)
	{
		m_sError = content ?? string.Empty;
	}

	protected virtual void SetResult(EDownloadResult result)
	{
		m_eResult = result;
		m_bEnd = true;
		if (result == EDownloadResult.eSUCCESS || result == EDownloadResult.eNONE)
		{
			m_fProgress = 1f;
		}
	}

	public abstract void Execute();

	public virtual void Text<T>(T data)
	{
	}
}
