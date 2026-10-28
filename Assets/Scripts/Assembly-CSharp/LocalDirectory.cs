using System.IO;
using UnityEngine;

public static class LocalDirectory
{
	private static string APPLICATION_ROOT_PATH;

	public static string PermanentDirectoryPath
	{
		get
		{
			Init();
			string root = Application.isEditor ? ApplicationRootPath : Application.persistentDataPath;
			return root + "/Documents";
		}
	}

	public static string CachesDirectoryPath
	{
		get
		{
			Init();
			if (Application.isEditor)
			{
				return ApplicationRootPath + "/PrivateDocuments";
			}
			return Application.persistentDataPath + "/Caches";
		}
	}

	public static string TempDirectoryPath
	{
		get
		{
			Init();
			string root = Application.isEditor ? ApplicationRootPath : Application.persistentDataPath;
			return root + "/tmp";
		}
	}

	public static string DebugDirectoryPath
	{
		get
		{
			return CachesDirectoryPath + "/Debug";
		}
	}

	public static string ApplicationRootPath
	{
		get
		{
			Init();
			return APPLICATION_ROOT_PATH;
		}
	}

	public static string StreamingAssetsURL
	{
		get
		{
			if (Application.isEditor)
			{
				return "file://" + Application.dataPath + "/StreamingAssets";
			}
			return "jar:file://" + Application.dataPath + "!/assets";
		}
	}

	public static string StreamingAssetsDirectory
	{
		get
		{
			if (Application.isEditor)
			{
				return Application.dataPath + "/StreamingAssets";
			}
			return Application.dataPath + "!/assets";
		}
	}

	private static void Init()
	{
		if (APPLICATION_ROOT_PATH != null)
		{
			return;
		}
		InitRootPath();
		InitDirectoryPath();
	}

	private static void InitRootPath()
	{
		string dataPath = Application.dataPath;
		if (Application.isEditor && !string.IsNullOrEmpty(dataPath))
		{
			int idx = dataPath.LastIndexOf('/');
			if (idx > 0)
			{
				dataPath = dataPath.Substring(0, idx);
			}
		}
		APPLICATION_ROOT_PATH = dataPath;
		Debug.Log("APPLICATION_ROOT_PATH = " + APPLICATION_ROOT_PATH);
	}

	private static void InitDirectoryPath()
	{
		if (!Directory.Exists(CachesDirectoryPath))
		{
			Directory.CreateDirectory(CachesDirectoryPath);
			Debug.Log("Create Directory : " + CachesDirectoryPath);
		}
		if (!Directory.Exists(DebugDirectoryPath))
		{
			Directory.CreateDirectory(DebugDirectoryPath);
		}
		if (!Directory.Exists(PermanentDirectoryPath))
		{
			Directory.CreateDirectory(PermanentDirectoryPath);
			Debug.Log("Create Directory " + PermanentDirectoryPath);
		}
		if (!Directory.Exists(TempDirectoryPath))
		{
			Directory.CreateDirectory(TempDirectoryPath);
			Debug.Log("Create Directory " + TempDirectoryPath);
		}
	}

	public static void DeleteCacheDirectory()
	{
		string cacheDir = CachesDirectoryPath;
		if (Directory.Exists(cacheDir))
		{
			Directory.Delete(cacheDir, true);
		}
		Directory.CreateDirectory(cacheDir);
	}
}
