using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class QuestAcheiveClearStart : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_aClearAnimation;

	[SerializeField]
	private AnimationController m_aStartAnimation;

	[SerializeField]
	private AnimationController m_aChallengeStartAnimation;

	[SerializeField]
	private GameObject m_oClear;

	[SerializeField]
	private GameObject m_oStart;

	[SerializeField]
	private GameObject m_oChallengeStart;

	[SerializeField]
	private UILabel m_uChallengeTitle;

	[SerializeField]
	private GameObject m_oQuestDetailPrefab;

	private GameObject m_oQuestDetailObj;

	private bool m_bClicked;

	private Action m_sOnFinishEvent;

	private int m_questDF;

	public void InitClear(QuestDetail quest, Action onFinish = null)
	{
	}

	public void InitStart(QuestDetail quest, Action onFinish = null)
	{
	}

	public void InitChallengeStart(QuestDetail quest, Action onFinish = null)
	{
	}

	public void OnClickedOK()
	{
	}

	public void OnClickedStart()
	{
	}

	public void OnClickedYesChallengeStart()
	{
	}

	public void OnClickedNoChallengeStart()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void SetActive(bool active)
	{
	}

	private void Awake()
	{
	}

	private void InEndDismiss()
	{
	}

	private void OnEndDismiss()
	{
	}

	[DebuggerHidden]
	private IEnumerator StampSE()
	{
		return null;
	}

	public static QuestAcheiveClearStart Create(Transform root)
	{
		return null;
	}
}
