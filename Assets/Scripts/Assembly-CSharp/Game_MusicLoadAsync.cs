using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class Game_MusicLoadAsync : MonoBehaviour
{
	public void LoadRequest(string filePath)
	{
	}

	[DebuggerHidden]
	public IEnumerator LoadAsyncCoroutine(string filePath)
	{
		return null;
	}
}
