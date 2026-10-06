using System.Collections.Generic;
using UnityEngine;

public class DebugManagerGUI : MonoBehaviour
{
	public enum LogType
	{
		Log = 1,
		Warning = 2,
		Error = 4
	}

	public class LogObject
	{
		public string msg;

		public LogType logType;
	}

	private static readonly int LOG_MAX;

	private List<LogObject> logList;

	private static DebugManagerGUI s_sInstance;

	public static DebugManagerGUI Instance
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void OnClickDebugGUI()
	{
	}

	private void AddLog(string log, LogType type)
	{
	}

	public void AddDebugLog(string msg)
	{
	}

	public void AddWarningLog(string msg)
	{
	}

	public void AddErrorLog(string msg)
	{
	}

	public List<LogObject> GetLogList()
	{
		return null;
	}

	public int GetLogMax()
	{
		return 0;
	}

	public void ClearLog()
	{
	}
}
