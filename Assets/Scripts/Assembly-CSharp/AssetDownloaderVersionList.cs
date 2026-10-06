using System.Collections;
using System.Diagnostics;

public class AssetDownloaderVersionList : AssetDownloaderBase
{
	private bool m_bSaveComplete;

	private bool m_bSaveResult;

	private int m_iCompleteNum;

	private int m_iFileNum;

	private VersionHeaderList m_sVersionData;

	private bool m_bUpdateFile;

	public bool IsUpdateFile()
	{
		return false;
	}

	protected override void Init()
	{
	}

	public void Execute(VersionHeaderList data)
	{
	}

	public override void Execute()
	{
	}

	[DebuggerHidden]
	protected IEnumerator Download()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator DownloadVersionList(string fileName, string path, string lastUpdate)
	{
		return null;
	}

	public void SaveEnd(bool success, string path)
	{
	}
}
