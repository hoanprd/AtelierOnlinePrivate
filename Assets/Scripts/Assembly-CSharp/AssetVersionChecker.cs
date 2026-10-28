using System.Collections;
using System.Diagnostics;
using UnityEngine;

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
			if (_instance == null)
			{
				_instance = Object.FindAnyObjectByType<AssetVersionChecker>();
				if (_instance == null)
				{
					GameObject go = new GameObject("AssetVersionChecker");
					Object.DontDestroyOnLoad(go);
					_instance = go.AddComponent<AssetVersionChecker>();
				}
			}
			return _instance;
		}
	}

	public new static EDownloadResult Result
	{
		get
		{
			return (_instance != null) ? ((AssetDownloaderBase)_instance).Result : EDownloadResult.eSUCCESS;
		}
	}

	public new static bool IsEnd
	{
		get
		{
			return _instance == null || ((AssetDownloaderBase)_instance).IsEnd;
		}
	}

	protected override void Init()
	{
		base.Init();
		m_bExecute = false;
		m_bUpdateFileVersion = false;
		m_bUpdateFileList = false;
	}

	public override void Execute()
	{
		Init();
		m_bExecute = true;
		StartCoroutine(Download());
	}

	[DebuggerHidden]
	private IEnumerator Download()
	{
		// Offline Client Mode: bypass remote CDN version check and use local assets
		yield return null;
		m_fProgress = 1f;
		SetResult(EDownloadResult.eSUCCESS);
		m_bExecute = false;
	}

	[DebuggerHidden]
	private IEnumerator ExecLoader(AssetDownloaderBase loader)
	{
		if (loader != null)
		{
			loader.Execute();
			while (!loader.IsEnd)
			{
				yield return null;
			}
		}
	}

	private void UpdateFileVersion()
	{
	}

	private void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			if (base.transform.parent == null)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
	}

	public static void Request()
	{
		Instance.Execute();
	}

	public static void UpdateRequest()
	{
		Instance.Execute();
	}
}
