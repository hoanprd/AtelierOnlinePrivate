using System.Collections.Generic;
using UnityEngine;

public class ScreenText : MonoBehaviour
{
	private sealed class ScreenTextData
	{
		public string Text;

		public float Timer;
	}

	public GUIStyle Style;

	public float MessageFadeTime;

	private readonly List<ScreenTextData> messages;

	public void AddMessage(string message)
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	public static void Log(object obj)
	{
	}

	public static void Log(string format, params object[] args)
	{
	}
}
