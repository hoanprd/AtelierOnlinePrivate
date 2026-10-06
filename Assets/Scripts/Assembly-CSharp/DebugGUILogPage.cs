using UnityEngine;

public class DebugGUILogPage : MonoBehaviour, IDebugGUIPage
{
	private static readonly int LOG_MAX;

	private static readonly int DRAW_LOG_SIZE;

	private int mDrawType;

	private int mLogIndex;

	private void AddDrawType(DebugManagerGUI.LogType drawType)
	{
	}

	private void RemoveDrawType(DebugManagerGUI.LogType drawType)
	{
	}

	private void ReverseDrawType(DebugManagerGUI.LogType drawType)
	{
	}

	private bool CheckMask(DebugManagerGUI.LogType drawType)
	{
		return false;
	}

	public void OnGUIPage(Rect rect)
	{
	}

	public string GetFooterText()
	{
		return null;
	}

	private bool LogButton(string title, DebugManagerGUI.LogType drawType)
	{
		return false;
	}
}
