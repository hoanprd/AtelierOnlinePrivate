using System.Collections;
using System.Diagnostics;
using UnityEngine;

public abstract class AssetDownloaderBase : MonoBehaviour
{
	protected const float cfTIMEOUT = 60f;

	protected string m_sError;

	protected EDownloadStatus m_eStatus;

	protected EDownloadResult m_eResult;

	protected bool m_bEnd;

	protected bool m_bCancel;

	protected float m_fProgress;

	protected static DialogCommon sDialog;

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

	public EDownloadResult Result
	{
		get
		{
			return EDownloadResult.eSUCCESS;
		}
	}

	public string ErrorMsg
	{
		get
		{
			return null;
		}
	}

	public void Cancel()
	{
	}

	[DebuggerHidden]
	public IEnumerator DispErrorDialog()
	{
		return null;
	}

	private void SetError(EDownloadResult result)
	{
	}

	protected virtual void Init()
	{
	}

	protected void SetErrorText(string content)
	{
	}

	protected virtual void SetResult(EDownloadResult result)
	{
	}

	public abstract void Execute();

	public virtual void Text<T>(T data)
	{
	}
}
