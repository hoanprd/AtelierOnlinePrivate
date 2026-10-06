using UnityEngine;

public class TreasureDetail : TreasureTargetInfoBase
{
	[SerializeField]
	private Transform m_sDetailRoot;

	[SerializeField]
	private Condition m_sCondition;

	[SerializeField]
	private Bonus m_sBonus;

	public override void Init(HuntInfo info)
	{
	}
}
