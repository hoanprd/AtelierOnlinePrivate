using System;
using System.Collections;
using System.Diagnostics;
using Ranking;
using UnityEngine;

public class RankingBoard : MonoBehaviour
{
	[SerializeField]
	private RankingFilterTab[] m_scrTabList;

	[SerializeField]
	private RankingBarWrapList m_scrBarList;

	[SerializeField]
	private RankingMyStatus m_scrStatus;

	private RankingMngInfo m_clsRankingInfo;

	private eRankingFilter m_eFilter;

	private eRankingType m_eRanking;

	private int m_iCycle;

	private Action m_acCallBack;

	public void Init(eRankingType eRanking, int iCycle, Action acCallBack)
	{
	}

	public void OnChangeTab(eRankingFilter eFilter)
	{
	}

	public RankingMngInfo GetInfo()
	{
		return null;
	}

	public void SetEnableTab(bool bEnable)
	{
	}

	private void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator Init_Coroutine(eRankingType eRanking, int iCycle, eRankingFilter eFilter)
	{
		return null;
	}

	private void UpdateFilter()
	{
	}
}
