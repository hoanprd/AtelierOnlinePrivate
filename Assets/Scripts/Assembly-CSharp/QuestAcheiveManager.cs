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

	private static List<QuestDetail> m_clsQuestList = new List<QuestDetail>();

	private static bool m_bEndExec = true;

	private static bool m_bAutoUpdateQuest = true;

	private static bool m_bAutoDispPop = true;

	private static Coroutine m_cUnlockPerform;

	private static List<int> m_iIgnoreStartList = new List<int>();

	private static QuestMainTitle m_clsMainTitle;

	private static QuestTelop m_clsTelop;

	private static QuestAcheiveClearStart m_clsClearStart;

	public static void Regist(QuestDetail clsAcheive)
	{
		if (clsAcheive != null && m_clsQuestList != null)
		{
			m_clsQuestList.Add(clsAcheive);
		}
	}

	public static void Regist(int iDF, int iSTT, int iSTP)
	{
	}

	public static void AutoUpdateQuest(bool bAutoUpdate)
	{
		m_bAutoUpdateQuest = bAutoUpdate;
	}

	public static void AutoDispPop(bool bDisp)
	{
		m_bAutoDispPop = bDisp;
	}

	public static void AddIgnoreStartDF(int iDF)
	{
		if (m_iIgnoreStartList != null && !m_iIgnoreStartList.Contains(iDF))
		{
			m_iIgnoreStartList.Add(iDF);
		}
	}

	public static void ResetExec()
	{
		m_bEndExec = true;
		if (m_clsQuestList != null)
		{
			m_clsQuestList.Clear();
		}
		if (m_iIgnoreStartList != null)
		{
			m_iIgnoreStartList.Clear();
		}
	}

	public static void Init()
	{
		m_bEndExec = true;
		if (m_clsQuestList != null)
		{
			m_clsQuestList.Clear();
		}
	}

	public static bool IsEnd()
	{
		return m_bEndExec;
	}

	[DebuggerHidden]
	private static IEnumerator Exec()
	{
		m_bEndExec = true;
		yield break;
	}

	[DebuggerHidden]
	private static IEnumerator QuestPerform(Action<bool> acCallback)
	{
		if (acCallback != null)
		{
			acCallback(false);
		}
		yield break;
	}

	[DebuggerHidden]
	public static IEnumerator QuestAchievePerform(List<QuestDetail> clsStartList, Action<bool> acCallback)
	{
		if (acCallback != null)
		{
			acCallback(false);
		}
		yield break;
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
		yield break;
	}

	[DebuggerHidden]
	private static IEnumerator ChallengeQuestPerform()
	{
		yield break;
	}

	private static void DispPerform(ePerform eKind, QuestDetail clsDetail, Action acCallback)
	{
		if (acCallback != null)
		{
			acCallback();
		}
	}

	private static void ReleasePerformObj(ePerform eKind)
	{
	}

	[DebuggerHidden]
	private static IEnumerator UpdateSpawner()
	{
		yield break;
	}

	[DebuggerHidden]
	private static IEnumerator QuestUnlockPerform(List<QuestDetail> clsQuestList)
	{
		yield break;
	}

	public static void StopUnlockPerform()
	{
		m_cUnlockPerform = null;
	}

	[DebuggerHidden]
	public static IEnumerator UnlockTutorial()
	{
		yield break;
	}
}
