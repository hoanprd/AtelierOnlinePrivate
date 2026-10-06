using System.Collections;
using System.Diagnostics;

public class AssetVersionChecker : AssetDownloaderBase
{
	private enum EKind
	{
		eHEADER = 0,
		eLIST = 1,
		eNUM = 2
	}

	private bool m_bExecute;

	private bool m_bUpdateFileVersion;

	private EKind m_eKind;

	private bool m_bUpdateFileList;

	private static AssetVersionChecker _instance;

	public static AssetVersionChecker Instance
	{
		get
		{
			return null;
		}
	}

	public new static EDownloadResult Result
	{
		get
		{
			return EDownloadResult.eSUCCESS;
		}
	}

	public new static bool IsEnd
	{
		get
		{
			return false;
		}
	}

	protected override void Init()
	{
	}

	public override void Execute()
	{
	}

	[DebuggerHidden]
	private IEnumerator Download()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator ExecLoader(AssetDownloaderBase loader)
	{
		return null;
	}

	private void UpdateFileVersion()
	{
	}

	private void Awake()
	{
	}

	public static void Request()
	{
	}

	public static void UpdateRequest()
	{
	}
}
