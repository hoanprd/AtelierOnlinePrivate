using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class QuestAcheiveManager
{
	private enum ePerform
	{
		Start = 0,
		StartChapter = 1,
		StartChallenge = 2,
		Clear = 3,
		ClearChapter = 4
	}

	private static List<QuestDetail> m_clsQuestList;

	private static bool m_bEndExec;

	private static bool m_bAutoUpdateQuest;

	private static bool m_bAutoDispPop;

	private static Coroutine m_cUnlockPerform;

	private static List<int> m_iIgnoreStartList;

	private static QuestMainTitle m_clsMainTitle;

	private static QuestTelop m_clsTelop;

	private static QuestAcheiveClearStart m_clsClearStart;

	public static void Regist(QuestDetail clsAcheive)
	{
	}

	public static void Regist(int iDF, int iSTT, int iSTP)
	{
	}

	public static void AutoUpdateQuest(bool bAutoUpdate)
	{
	}

	public static void AutoDispPop(bool bDisp)
	{
	}

	public static void AddIgnoreStartDF(int iDF)
	{
	}

	public static void ResetExec()
	{
	}

	public static void Init()
	{
	}

	public static bool IsEnd()
	{
		return false;
	}

	[DebuggerHidden]
	private static IEnumerator Exec()
	{
		return null;
	}

	[DebuggerHidden]
	private static IEnumerator QuestPerform(Action<bool> acCallback)
	{
		return null;
	}

	[DebuggerHidden]
	public static IEnumerator QuestAchievePerform(List<QuestDetail> clsStartList, Action<bool> acCallback)
	{
		return null;
	}

	private static bool IsAchieveMain(MasterQuestInfo clsMaster, List<QuestDetail> clsStartList)
	{
		return false;
	}

	private static void Statistics(QuestDetail clsDetail)
	{
	}

	[DebuggerHidden]
	private static IEnumerator QuestStartPerform(List<QuestDetail> clsStartList)
	{
		return null;
	}

	[DebuggerHidden]
	private static IEnumerator ChallengeQuestPerform()
	{
		return null;
	}

	private static void DispPerform(ePerform eKind, QuestDetail clsDetail, Action acCallback)
	{
	}

	private static void ReleasePerformObj(ePerform eKind)
	{
	}

	[DebuggerHidden]
	private static IEnumerator UpdateSpawner()
	{
		return null;
	}

	[DebuggerHidden]
	private static IEnumerator QuestUnlockPerform(List<QuestDetail> clsQuestList)
	{
		return null;
	}

	public static void StopUnlockPerform()
	{
	}

	[DebuggerHidden]
	public static IEnumerator UnlockTutorial()
	{
		return null;
	}
}
