using System.Collections;
using System.Diagnostics;

public class AssetDownloaderVersionHeader : AssetDownloaderBase
{
	private bool m_bSaveComplete;

	private bool m_bSaveResult;

	public override void Execute()
	{
	}

	[DebuggerHidden]
	protected IEnumerator Download()
	{
		return null;
	}

	public void SaveEnd(bool success, string path)
	{
	}
}
