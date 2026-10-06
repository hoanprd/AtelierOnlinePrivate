using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class System_MenuManager : MonoBehaviour
{
	public enum eSystemMenuKind
	{
		None = -1,
		Title = 0,
		Academy = 1,
		Field = 2,
		Opening = 3,
		EnumMax = 4
	}

	private static readonly int LOG_CACHE_MAX;

	private static System_MenuManager g_scrInst;

	private eSystemMenuKind m_eSystemMenuKind_Now;

	public eSystemMenuKind m_eSystemMenuKind_Req;

	public GameObject m_goCoverFrontPrefab;

	private GameObject m_goTouchBlockCollision;

	private DialogError m_sErrorDialog;

	private List<string> logList;

	public bool IsDone { get; set; }

	private void Awake()
	{
	}

	public static System_MenuManager GetInst()
	{
		return null;
	}

	public eSystemMenuKind GetNowMenu()
	{
		return eSystemMenuKind.Title;
	}

	public static bool IsMapArea()
	{
		return false;
	}

	public static bool IsField()
	{
		return false;
	}

	public static bool IsVillage()
	{
		return false;
	}

	private float GetDeltaTime()
	{
		return 0f;
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	public void SetMenuRequest(eSystemMenuKind eKind, bool force = false, bool fadein = false, bool fadeout = false)
	{
	}

	[DebuggerHidden]
	private IEnumerator ChangeScene(eSystemMenuKind next, bool fadein, bool fadeout)
	{
		return null;
	}

	private void TitleInit()
	{
	}

	public void SetCover(bool bFlag)
	{
	}

	private void ReceivedLog(string condition, string stackTrace, LogType type)
	{
	}

	private void OnApplicationPause(bool isPaused)
	{
	}
}
