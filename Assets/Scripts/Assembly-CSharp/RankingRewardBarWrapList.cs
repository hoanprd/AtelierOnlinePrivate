using System.Collections.Generic;
using Ranking;
using UnityEngine;

public class RankingRewardBarWrapList : UIWrapListBase
{
	private eRankingReward m_eReward;

	private List<RankingRewardInfo> m_clsRankRewList;

	private List<RankingScoreRewardInfo> m_clsScoreRewList;

	private RankingUserData m_clsMyData;

	private string m_strIconPath;

	public void Init(RankingRewardInfo[] clsRewardAry, string strIconPath, RankingUserData clsMyData)
	{
	}

	public void Init(RankingScoreRewardInfo[] clsRewardAry, string strIconPath, RankingUserData clsMyData)
	{
	}

	private void Awake()
	{
	}

	protected override void InitItem(int iIndex, GameObject goTarget)
	{
	}
}
