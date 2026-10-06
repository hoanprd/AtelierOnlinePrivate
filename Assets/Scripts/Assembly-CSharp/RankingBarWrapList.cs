using System.Collections.Generic;
using UnityEngine;

public class RankingBarWrapList : UIWrapListBase
{
	private RankingMngInfo m_clsRankingInfo;

	private List<RankingUserData> m_clsRankingList;

	public void Init(RankingUserData[] clsRankingAry, RankingMngInfo clsInfo)
	{
	}

	private void Awake()
	{
	}

	protected override void InitItem(int iIndex, GameObject goTarget)
	{
	}
}
