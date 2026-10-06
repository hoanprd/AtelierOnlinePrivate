using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class QuestStatusObjectManager : MonoBehaviour
{
	private static QuestStatusObjectManager s_sInstance;

	private Coroutine m_sCoroutine;

	private List<QuestStatusObject> m_sObjectList;

	public static QuestStatusObjectManager Instance
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static void Add(QuestStatusObject sObject)
	{
	}

	public static void Remove(QuestStatusObject sObject)
	{
	}

	public static bool IsExistUpdate()
	{
		return false;
	}

	public static bool IsExistUpdate(List<QuestDetail> sDetailList)
	{
		return false;
	}

	public static void UpdateAll(bool bFadeIn = true)
	{
	}

	public static void UpdateAll(List<QuestDetail> sDetailList, bool bFadeIn = true)
	{
	}

	public static bool IsEndUpdate()
	{
		return false;
	}

	private bool _IsExistUpdate(List<QuestDetail> sDetailList)
	{
		return false;
	}

	private void _UpdateAll(List<QuestDetail> sDetailList, bool bFadeIn)
	{
	}

	[DebuggerHidden]
	private IEnumerator UpdateCoroutine(List<QuestDetail> sDetailList, bool bFadeIn)
	{
		return null;
	}
}
