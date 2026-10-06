using System.Collections;
using System.Diagnostics;

public class AssetDownloaderOne : AssetDownloaderBase
{
	protected string m_sInfo;

	protected VersionData m_sData;

	public string Info
	{
		get
		{
			return null;
		}
	}

	public VersionData VersionData
	{
		get
		{
			return null;
		}
	}

	protected override void Init()
	{
	}

	public void SetData(VersionData data)
	{
	}

	public void Execute(VersionData data)
	{
	}

	public override void Execute()
	{
	}

	[DebuggerHidden]
	protected IEnumerator Download(VersionData data)
	{
		return null;
	}

	[DebuggerHidden]
	protected IEnumerator DownloadFile(string downloadPath, string savePath, string hash)
	{
		return null;
	}

	[DebuggerHidden]
	protected IEnumerator UpdateVersionInfo()
	{
		return null;
	}

	public static bool IsNeedDownload(VersionData data)
	{
		return false;
	}
}
