using System;
using UnityEngine;

public class QuestMainTitle : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sChapter;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private Animation m_sAnim;

	[SerializeField]
	private UILabel m_sNextChapter;

	private Action m_sOnFinishEvent;

	private void ClearTest()
	{
	}

	private void UnlockTest()
	{
	}

	public void InitUnlock(int df, Action onFinish = null)
	{
	}

	public void InitClear(int df, Action onFinish = null)
	{
	}

	private void Update()
	{
	}

	public static QuestMainTitle Create(Transform root)
	{
		return null;
	}
}
