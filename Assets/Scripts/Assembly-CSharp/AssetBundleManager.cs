using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class AssetBundleManager : MonoBehaviour
{
	public enum EState
	{
		eNone = 0,
		eLoading = 1,
		eComplete = 2,
		eCancel = 3,
		eError = 4
	}

	private class ObjectInfo
	{
		public EState state;

		public Object obj;

		public List<string> objectPathList = new List<string>();

		public List<Object> objectList = new List<Object>();

		public int refCount;

		public void Init()
		{
			state = EState.eNone;
			obj = null;
			if (objectPathList == null)
			{
				objectPathList = new List<string>();
			}
			else
			{
				objectPathList.Clear();
			}
			if (objectList == null)
			{
				objectList = new List<Object>();
			}
			else
			{
				objectList.Clear();
			}
			refCount = 0;
		}
	}

	private class AssetCache : LRUCache<string, ObjectInfo>
	{
		public AssetCache(uint capacity)
			: base(capacity)
		{
		}

		protected override void DisposeItem(CacheItem<string, ObjectInfo> item)
		{
			if (item != null && item.Value != null)
			{
				item.Value.Init();
			}
		}
	}

	public static AssetBundleManager sInstance;

	public static string sExtension = ".unity3d";

	private static string sOLD_ASSET_FILE = "version.json";

	private AssetCache m_aObjectRefs;

	public Dictionary<string, VersionData> m_vVersionList = new Dictionary<string, VersionData>();

	[HideInInspector]
	public List<VersionList> m_sVersionHeader = new List<VersionList>();

	[HideInInspector]
	public VersionHeaderList m_sVersionInfo;

	private bool m_bLoad;

	private const int ASSET_CACHE_MAX = 1024;

	private int mRequestCnt;

	private static AssetBundleManager Instance
	{
		get
		{
			if (sInstance == null)
			{
				sInstance = Object.FindAnyObjectByType<AssetBundleManager>();
				if (sInstance == null)
				{
					GameObject go = new GameObject("AssetBundleManager");
					Object.DontDestroyOnLoad(go);
					sInstance = go.AddComponent<AssetBundleManager>();
				}
			}
			return sInstance;
		}
	}

	public static int ReqCount
	{
		get
		{
			return Instance.mRequestCnt;
		}
	}

	private void Awake()
	{
		sInstance = this;
		if (m_aObjectRefs == null)
		{
			m_aObjectRefs = new AssetCache(ASSET_CACHE_MAX);
		}
		if (m_vVersionList == null)
		{
			m_vVersionList = new Dictionary<string, VersionData>();
		}
		if (m_sVersionHeader == null)
		{
			m_sVersionHeader = new List<VersionList>();
		}
		if (base.transform.parent == null)
		{
			Object.DontDestroyOnLoad(base.gameObject);
		}
	}

	private string GetTag(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return string.Empty;
		}
		int idx = path.IndexOf('/');
		return (idx > 0) ? path.Substring(0, idx) : path;
	}

	private void UnloadCache()
	{
		if (m_aObjectRefs != null)
		{
			m_aObjectRefs.Clear();
		}
	}

	[DebuggerHidden]
	private IEnumerator Download(string[] arg)
	{
		yield break;
	}

	[DebuggerHidden]
	private IEnumerator LoadResource(string path, ObjectInfo info)
	{
		if (info != null)
		{
			Object[] loaded = LoadLocalObjects(path);
			if (loaded != null && loaded.Length > 0)
			{
				info.obj = loaded[0];
				info.objectList = new List<Object>(loaded);
			}
			info.state = EState.eComplete;
		}
		yield break;
	}

	private static Object[] LoadLocalObjects(string mainasset)
	{
		if (string.IsNullOrEmpty(mainasset))
		{
			return null;
		}
		string clean = mainasset.Replace("\\", "/");
		int dot = clean.LastIndexOf('.');
		int slash = clean.LastIndexOf('/');
		string noExt = (dot > slash) ? clean.Substring(0, dot) : clean;

		// 1. Check local cached AssetBundle file if present
		string cacheDir = LocalDirectory.CachesDirectoryPath;
		if (!string.IsNullOrEmpty(cacheDir))
		{
			string[] candidates = new string[2]
			{
				Path.Combine(cacheDir, clean),
				Path.Combine(cacheDir, noExt + sExtension)
			};
			for (int i = 0; i < candidates.Length; i++)
			{
				if (File.Exists(candidates[i]))
				{
					AssetBundle bundle = AssetBundle.LoadFromFile(candidates[i]);
					if (bundle != null)
					{
						Object[] all = bundle.LoadAllAssets();
						bundle.Unload(false);
						if (all != null && all.Length > 0)
						{
							return all;
						}
					}
				}
			}
		}

		// 2. Load from Unity Resources
		Object[] resAll = Resources.LoadAll(noExt);
		if (resAll != null && resAll.Length > 0)
		{
			return resAll;
		}
		Object single = Resources.Load(noExt);
		if (single != null)
		{
			return new Object[1] { single };
		}

		// 3. Fallback for Master/* subpaths -> Master/<fileName>
		if (noExt.StartsWith("Master/"))
		{
			string fileName = Path.GetFileName(noExt);
			Object masterObj = Resources.Load("Master/" + fileName);
			if (masterObj != null)
			{
				return new Object[1] { masterObj };
			}
		}

		return null;
	}

	private Object[] _Get(string mainasset)
	{
		if (string.IsNullOrEmpty(mainasset))
		{
			return null;
		}
		if (m_aObjectRefs == null)
		{
			m_aObjectRefs = new AssetCache(ASSET_CACHE_MAX);
		}
		if (m_aObjectRefs.Exist(mainasset))
		{
			ObjectInfo info = m_aObjectRefs.Get(mainasset);
			if (info != null && info.objectList != null && info.objectList.Count > 0)
			{
				return info.objectList.ToArray();
			}
		}
		return _Load(mainasset);
	}

	private Object[] _Load(string mainasset, string[] subasset = null)
	{
		if (string.IsNullOrEmpty(mainasset))
		{
			return null;
		}
		if (m_aObjectRefs == null)
		{
			m_aObjectRefs = new AssetCache(ASSET_CACHE_MAX);
		}
		if (m_aObjectRefs.Exist(mainasset))
		{
			ObjectInfo cached = m_aObjectRefs.Get(mainasset);
			if (cached != null && cached.state == EState.eComplete)
			{
				cached.refCount++;
				return (cached.objectList != null && cached.objectList.Count > 0) ? cached.objectList.ToArray() : null;
			}
		}
		Object[] objs = LoadLocalObjects(mainasset);
		ObjectInfo info = new ObjectInfo();
		info.Init();
		info.state = EState.eComplete;
		info.refCount = 1;
		if (objs != null && objs.Length > 0)
		{
			info.obj = objs[0];
			info.objectList.AddRange(objs);
		}
		m_aObjectRefs.Add(mainasset, info);
		return objs;
	}

	private bool _IsLoad(string mainasset)
	{
		if (string.IsNullOrEmpty(mainasset))
		{
			return true;
		}
		if (m_aObjectRefs != null && m_aObjectRefs.Exist(mainasset))
		{
			ObjectInfo info = m_aObjectRefs.Get(mainasset);
			return info == null || info.state == EState.eComplete || info.state == EState.eError;
		}
		_Load(mainasset);
		return true;
	}

	private bool _IsLoadAll()
	{
		return mRequestCnt <= 0;
	}

	private void _Unload(string mainasset, bool isRemove = true)
	{
		if (!string.IsNullOrEmpty(mainasset) && m_aObjectRefs != null && isRemove)
		{
			m_aObjectRefs.Remove(mainasset);
		}
	}

	private void _UnloadAll()
	{
		if (m_aObjectRefs != null)
		{
			m_aObjectRefs.Clear();
		}
		mRequestCnt = 0;
	}

	[DebuggerHidden]
	private IEnumerator _UnloadForce()
	{
		_UnloadAll();
		yield break;
	}

	private void _Cancel()
	{
		mRequestCnt = 0;
	}

	private void _Cancel(string path)
	{
	}

	private bool _IsCanceled(string path)
	{
		return false;
	}

	private bool _IsExistObjectRefs(string path)
	{
		return !string.IsNullOrEmpty(path) && m_aObjectRefs != null && m_aObjectRefs.Exist(path);
	}

	public static void SaveVersionInfo()
	{
	}

	public static List<VersionData> LoadVersionInfoLocal()
	{
		return new List<VersionData>();
	}

	public static List<VersionData> GetLaunchUpdateFiles(List<VersionData> old)
	{
		return new List<VersionData>();
	}

	public static void ClearVersionInfo()
	{
		if (Instance.m_vVersionList != null)
		{
			Instance.m_vVersionList.Clear();
		}
		if (Instance.m_sVersionHeader != null)
		{
			Instance.m_sVersionHeader.Clear();
		}
	}

	public static void RegistVersionInfo(VersionList list)
	{
		if (list == null)
		{
			return;
		}
		if (Instance.m_sVersionHeader == null)
		{
			Instance.m_sVersionHeader = new List<VersionList>();
		}
		Instance.m_sVersionHeader.Add(list);
		if (list.list != null)
		{
			for (int i = 0; i < list.list.Count; i++)
			{
				VersionData vd = list.list[i];
				if (vd != null && !string.IsNullOrEmpty(vd.path))
				{
					RegistVersionInfo(vd.path, vd);
				}
			}
		}
	}

	public static void RegistVersionInfo(string path, VersionData version)
	{
		if (!string.IsNullOrEmpty(path) && version != null)
		{
			Instance.m_vVersionList[path] = version;
		}
	}

	public static VersionData GetVersionInfo(string path)
	{
		if (!string.IsNullOrEmpty(path) && Instance.m_vVersionList != null && Instance.m_vVersionList.TryGetValue(path, out VersionData vd))
		{
			return vd;
		}
		return new VersionData
		{
			path = path ?? string.Empty,
			size = 0L,
			download = false
		};
	}

	public static bool ExistVersionInfo(string path)
	{
		return !string.IsNullOrEmpty(path) && Instance.m_vVersionList != null && Instance.m_vVersionList.ContainsKey(path);
	}

	public static List<VersionData> GetRequireList()
	{
		return new List<VersionData>();
	}

	public static List<VersionData> GetAllList()
	{
		return new List<VersionData>();
	}

	public static List<VersionData> GetList(EAssetDownloadTiming timing)
	{
		return new List<VersionData>();
	}

	public static Object[] Get(VersionData mainasset)
	{
		return (mainasset != null) ? Get(mainasset.path) : null;
	}

	public static Object[] Load(VersionData mainasset)
	{
		return (mainasset != null) ? Load(mainasset.path) : null;
	}

	public static bool IsLoad(VersionData mainasset)
	{
		return mainasset == null || IsLoad(mainasset.path);
	}

	public static bool IsLoad(VersionData[] mainassets)
	{
		if (mainassets == null)
		{
			return true;
		}
		for (int i = 0; i < mainassets.Length; i++)
		{
			if (!IsLoad(mainassets[i]))
			{
				return false;
			}
		}
		return true;
	}

	public static Object[] Get(string mainasset)
	{
		return Instance._Get(mainasset);
	}

	public static Object[] Load(string mainasset, string[] subasset = null)
	{
		return Instance._Load(mainasset, subasset);
	}

	public static bool IsLoad(string mainasset)
	{
		return Instance._IsLoad(mainasset);
	}

	public static bool IsLoad(string[] mainassets)
	{
		if (mainassets == null)
		{
			return true;
		}
		for (int i = 0; i < mainassets.Length; i++)
		{
			if (!IsLoad(mainassets[i]))
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsLoadAll()
	{
		return Instance._IsLoadAll();
	}

	public static void Unload(string mainasset, bool isRemove = true)
	{
		Instance._Unload(mainasset, isRemove);
	}

	public static void UnloadAll()
	{
		Instance._UnloadAll();
	}

	[DebuggerHidden]
	public static IEnumerator UnloadForce()
	{
		return Instance._UnloadForce();
	}

	public static void Cancel()
	{
		Instance._Cancel();
	}

	public static void Cancel(string path)
	{
		Instance._Cancel(path);
	}

	public static bool IsCanceled(string path)
	{
		return Instance._IsCanceled(path);
	}

	public bool IsLoading()
	{
		return m_bLoad || mRequestCnt > 0;
	}

	public static bool IsExistObjectRefs(string path)
	{
		return Instance._IsExistObjectRefs(path);
	}

	public static bool IsExistAsset(string path)
	{
		return LoadLocalObjects(path) != null;
	}
}
