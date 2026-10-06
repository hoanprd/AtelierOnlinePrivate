using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class QuestTelop : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UILabel m_sChapter;

	[SerializeField]
	private UILabel m_sText;

	[SerializeField]
	private UISprite m_sQuestIcon;

	[SerializeField]
	private GameObject m_sSyougouIcon;

	[SerializeField]
	private GameObject m_sDegreeObj;

	private UITweenReset m_sAnim;

	private Action m_sOnFinishEvent;

	private void QuestOccurrenceTest1()
	{
	}

	private void QuestOccurrenceTest4()
	{
	}

	private void QuestOccurrenceTest2()
	{
	}

	private void QuestOccurrenceTest3()
	{
	}

	private void TitleTest()
	{
	}

	private void DairyCompleteTest()
	{
	}

	private void NewScenarioTest()
	{
	}

	public void InitQuestOccurrence(int df, Action onFinish = null)
	{
	}

	public void InitDegree(int df, int step, Action onFinish = null)
	{
	}

	public void InitDairyComplete(int df, Action onFinish = null)
	{
	}

	public void InitNewScenario(int df, Action onFinish = null)
	{
	}

	private void OnOpenEnd()
	{
	}

	private void OnCloseEnd()
	{
	}

	[DebuggerHidden]
	private IEnumerator WaitTime()
	{
		return null;
	}

	public static QuestTelop Create(Transform root)
	{
		return null;
	}
}
