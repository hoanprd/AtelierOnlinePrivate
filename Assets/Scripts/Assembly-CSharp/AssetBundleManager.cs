using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

		public List<string> objectPathList;

		public List<Object> objectList;

		public int refCount;

		public void Init()
		{
		}
	}

	private class AssetCache : LRUCache<string, ObjectInfo>
	{
		public AssetCache(uint capacity)
			: base(0u)
		{
		}

		protected override void DisposeItem(CacheItem<string, ObjectInfo> item)
		{
		}
	}

	public static AssetBundleManager sInstance;

	public static string sExtension;

	private static string sOLD_ASSET_FILE;

	private AssetCache m_aObjectRefs;

	public Dictionary<string, VersionData> m_vVersionList;

	[HideInInspector]
	public List<VersionList> m_sVersionHeader;

	[HideInInspector]
	public VersionHeaderList m_sVersionInfo;

	private bool m_bLoad;

	private const int ASSET_CACHE_MAX = 1024;

	private int mRequestCnt;

	private static AssetBundleManager Instance
	{
		get
		{
			return null;
		}
	}

	public static int ReqCount
	{
		get
		{
			return 0;
		}
	}

	private void Awake()
	{
	}

	private string GetTag(string path)
	{
		return null;
	}

	private void UnloadCache()
	{
	}

	[DebuggerHidden]
	private IEnumerator Download(string[] arg)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator LoadResource(string path, ObjectInfo info)
	{
		return null;
	}

	private Object[] _Get(string mainasset)
	{
		return null;
	}

	private Object[] _Load(string mainasset, string[] subasset = null)
	{
		return null;
	}

	private bool _IsLoad(string mainasset)
	{
		return false;
	}

	private bool _IsLoadAll()
	{
		return false;
	}

	private void _Unload(string mainasset, bool isRemove = true)
	{
	}

	private void _UnloadAll()
	{
	}

	[DebuggerHidden]
	private IEnumerator _UnloadForce()
	{
		return null;
	}

	private void _Cancel()
	{
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
		return false;
	}

	public static void SaveVersionInfo()
	{
	}

	public static List<VersionData> LoadVersionInfoLocal()
	{
		return null;
	}

	public static List<VersionData> GetLaunchUpdateFiles(List<VersionData> old)
	{
		return null;
	}

	public static void ClearVersionInfo()
	{
	}

	public static void RegistVersionInfo(VersionList list)
	{
	}

	public static void RegistVersionInfo(string path, VersionData version)
	{
	}

	public static VersionData GetVersionInfo(string path)
	{
		return null;
	}

	public static bool ExistVersionInfo(string path)
	{
		return false;
	}

	public static List<VersionData> GetRequireList()
	{
		return null;
	}

	public static List<VersionData> GetAllList()
	{
		return null;
	}

	public static List<VersionData> GetList(EAssetDownloadTiming timing)
	{
		return null;
	}

	public static Object[] Get(VersionData mainasset)
	{
		return null;
	}

	public static Object[] Load(VersionData mainasset)
	{
		return null;
	}

	public static bool IsLoad(VersionData mainasset)
	{
		return false;
	}

	public static bool IsLoad(VersionData[] mainassets)
	{
		return false;
	}

	public static Object[] Get(string mainasset)
	{
		return null;
	}

	public static Object[] Load(string mainasset, string[] subasset = null)
	{
		return null;
	}

	public static bool IsLoad(string mainasset)
	{
		return false;
	}

	public static bool IsLoad(string[] mainassets)
	{
		return false;
	}

	public static bool IsLoadAll()
	{
		return false;
	}

	public static void Unload(string mainasset, bool isRemove = true)
	{
	}

	public static void UnloadAll()
	{
	}

	[DebuggerHidden]
	public static IEnumerator UnloadForce()
	{
		return null;
	}

	public static void Cancel()
	{
	}

	public static void Cancel(string path)
	{
	}

	public static bool IsCanceled(string path)
	{
		return false;
	}

	public bool IsLoading()
	{
		return false;
	}

	public static bool IsExistObjectRefs(string path)
	{
		return false;
	}

	public static bool IsExistAsset(string path)
	{
		return false;
	}
}
