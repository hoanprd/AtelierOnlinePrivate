using System;
using System.Collections.Generic;
using UnityEngine;

public class AssetManager : MonoBehaviour
{
	[Serializable]
	public class Version
	{
		public List<VersionData> list;

		public void Add(VersionData data)
		{
		}

		public void Add(List<VersionData> list)
		{
		}

		public VersionData Find(string path)
		{
			return null;
		}

		public List<VersionData> GetList(EAssetDownloadTiming timing)
		{
			return null;
		}

		public List<VersionData> GetList(bool raw)
		{
			return null;
		}

		public List<VersionData> GetRequireList()
		{
			return null;
		}
	}

	public AssetVersionChecker m_sVersion;

	public AssetBundleManager m_sAssetBundle;

	public Version m_sVersionList;

	public void LoadRequest(string root, string assetName)
	{
	}

	public bool IsLoad(string root, string assetName)
	{
		return false;
	}

	public UnityEngine.Object LoadAsset(string root, string assetName)
	{
		return null;
	}

	public UnityEngine.Object LoadAssetFromAssetBundle(string root, string assetName)
	{
		return null;
	}

	public UnityEngine.Object LoadAssetFromResource(string root, string assetName)
	{
		return null;
	}
}
