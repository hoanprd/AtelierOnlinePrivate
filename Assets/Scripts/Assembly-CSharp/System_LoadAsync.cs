using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class System_LoadAsync : MonoBehaviour
{
	public Renderer m_targetRenderer;

	public void LoadRequest_Texture(string filePath, string[] fileNameArray)
	{
		if (fileNameArray != null && fileNameArray.Length > 0)
		{
			StartCoroutine(LoadAsyncCoroutine_Texture(filePath, fileNameArray));
		}
	}

	public void LoadRequest_Texture(string filePath, List<string> fileNameList)
	{
		if (fileNameList != null && fileNameList.Count > 0)
		{
			StartCoroutine(LoadAsyncCoroutine_Texture(filePath, fileNameList.ToArray()));
		}
	}

	[DebuggerHidden]
	public IEnumerator LoadAsyncCoroutine_Texture(string filePath, string[] fileNameArray)
	{
		if (m_targetRenderer == null || fileNameArray == null || fileNameArray.Length == 0)
		{
			yield break;
		}
		for (int i = 0; i < fileNameArray.Length; i++)
		{
			string fileName = fileNameArray[i];
			if (string.IsNullOrEmpty(fileName)) continue;
			string fullPath = string.IsNullOrEmpty(filePath) ? fileName : (filePath.TrimEnd('/') + "/" + fileName);
			yield return AssetBundleManager.Load(fullPath);
			UnityEngine.Object[] objs = AssetBundleManager.Get(fullPath);
			Texture tex = (objs != null && objs.Length > 0) ? (objs[0] as Texture) : Resources.Load<Texture>(fullPath);
			if (tex != null && m_targetRenderer != null && m_targetRenderer.material != null)
			{
				m_targetRenderer.material.mainTexture = tex;
			}
		}
	}
}
