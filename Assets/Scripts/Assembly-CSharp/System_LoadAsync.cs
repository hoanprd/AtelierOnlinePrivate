using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class System_LoadAsync : MonoBehaviour
{
	public Renderer m_targetRenderer;

	public void LoadRequest_Texture(string filePath, string[] fileNameArray)
	{
	}

	public void LoadRequest_Texture(string filePath, List<string> fileNameList)
	{
	}

	[DebuggerHidden]
	public IEnumerator LoadAsyncCoroutine_Texture(string filePath, string[] fileNameArray)
	{
		return null;
	}
}
