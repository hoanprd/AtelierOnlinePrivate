using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class QuestAcheiveWindow : MonoBehaviour
{
	public enum eLabel
	{
		Title = 0,
		QuestType = 1,
		TotalPoint = 2,
		EnumMax = 3
	}

	private static readonly int sr_iRewardWaitCount;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private UISprite m_scrTypeMark;

	[SerializeField]
	private AnimationController m_scrAnimation;

	[SerializeField]
	private QuestCategoryMark m_scrCategory;

	[SerializeField]
	private QuestAcheiveRewardList m_scrReward;

	[SerializeField]
	private GameObject m_oComplete;

	[SerializeField]
	private GameObject m_oClear;

	private bool m_bRewardOK;

	private bool m_bClicked;

	private Coroutine m_cCoroutine;

	private Action m_sOnFinishEvent;

	public void Init(int iQuestDF, Action onFinish = null)
	{
	}

	public void InitComplete(int iDF, Action onFinish = null)
	{
	}

	public void OnClickedOK()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void RewardStart()
	{
	}

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator StartFlow()
	{
		return null;
	}

	private void OnEndDismiss()
	{
	}

	private void SetLabelText(eLabel eKind, string strText)
	{
	}
}
