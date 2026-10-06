using System;
using System.Collections;
using System.Diagnostics;
using Ranking;
using UnityEngine;

public class RankingRewardUI : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private RankingRewardTab[] m_scrTabList;

	[SerializeField]
	private AnimationController m_scrWindowAnim;

	[SerializeField]
	private RankingRewardUIRank m_scrRankUI;

	[SerializeField]
	private RankingRewardUIScore m_scrScoreUI;

	[SerializeField]
	private RankingRewardBarWrapList m_scrBarWrapList;

	private eRankingReward m_eRewardMode;

	private eRankingType m_eRankingType;

	private int m_iCycle;

	private Action m_acAPIEndCallback;

	private Action m_acCloseCallback;

	private bool m_bInitialized;

	private bool m_bDismissNow;

	public void Init(eRankingType eRanking, int iCycle, Action acAPIEndCallback)
	{
	}

	public void Close(Action acCallBack)
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void OnChangeTab(eRankingReward eReward)
	{
	}

	private void OnBringInEnd()
	{
	}

	private void OnDismissEnd()
	{
	}

	[DebuggerHidden]
	private IEnumerator Init_Coroutine()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator API_RankReward()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator API_ScoreReward()
	{
		return null;
	}

	private void DispRankReward(RankingTopRewardData clsRes, RankingMngInfo clsMng)
	{
	}

	private void DispScoreReward(RankingScoreRewardData clsRes, RankingMngInfo clsMng, RankingUserData clsMyData)
	{
	}

	private void SetEnableTab(bool bEnable)
	{
	}
}
