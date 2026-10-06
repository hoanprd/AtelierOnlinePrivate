using System.Collections.Generic;
using Ranking;
using UnityEngine;

public class RankingResponseManager : MonoBehaviour
{
	private static RankingResponseManager s_scrInstance;

	private List<TopRankingData> m_clsRankTopResList;

	private List<FriendRankingData> m_clsRankFriendResList;

	private Dictionary<KeyValuePair<eRankingType, int>, RankingTopRewardData> m_clsTopRewResDic;

	private Dictionary<KeyValuePair<eRankingType, int>, RankingScoreRewardData> m_clsScoreRewResDic;

	public static RankingResponseManager Instance
	{
		get
		{
			return null;
		}
	}

	public void SetRankingTop(TopRankingData clsRes)
	{
	}

	public void SetRankingFriend(FriendRankingData clsRes)
	{
	}

	public void SetTopReward(RankingTopRewardData clsRes, eRankingType eRanking, int iCycle)
	{
	}

	public void SetScoreReward(RankingScoreRewardData clsRes, eRankingType eRanking, int iCycle)
	{
	}

	public TopRankingData GetRankingTop(eRankingType eRanking, int iCycle)
	{
		return null;
	}

	public FriendRankingData GetRankingFriend(eRankingType eRanking, int iCycle)
	{
		return null;
	}

	public RankingTopRewardData GetTopReward(eRankingType eRanking, int iCycle)
	{
		return null;
	}

	public RankingScoreRewardData GetScoreReward(eRankingType eRanking, int iCycle)
	{
		return null;
	}

	public RankingMngInfo GetRankingMngInfo(eRankingType eRanking, int iCycle)
	{
		return null;
	}

	public RankingUserData GetMyRankingData(eRankingType eRanking, int iCycle)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
