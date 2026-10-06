using UnityEngine;

public class TreasureTargetItem : TreasureTargetInfoBase
{
	[SerializeField]
	protected UILabel m_sTime;

	[SerializeField]
	protected Reward m_sReward;

	[SerializeField]
	protected Condition m_sCondition;

	[SerializeField]
	protected GameObject m_goRunning;

	[SerializeField]
	protected GameObject m_goDecideButton;

	[SerializeField]
	protected GameObject m_goTimeRoot;

	public override void Init(HuntInfo info)
	{
	}
}
