using Ranking;
using UnityEngine;

public class RankingRewardBarBase : MonoBehaviour
{
	[SerializeField]
	protected UIGrid m_scrItemGrid;

	[SerializeField]
	protected Transform m_trDialogRoot;

	private eRewardType[] m_eRewardTypeAry;

	protected ItemBar[] m_scrItemBarAry;

	public void Test()
	{
	}

	protected void Initialize()
	{
	}

	protected void SetRewardIcon(RewardInfo[] clsReward)
	{
	}

	private void OnRewardDetail(ItemBar scrBar)
	{
	}
}
