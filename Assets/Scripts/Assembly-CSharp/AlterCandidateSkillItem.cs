using UnityEngine;

public class AlterCandidateSkillItem : SkillMark
{
	[SerializeField]
	private UILabel m_sRate;

	[SerializeField]
	private GameObject m_goRankUp;

	[SerializeField]
	private GameObject m_goFIX;

	public void Init(AlchemyConfirm.CandidateSkill skill, int denominator)
	{
	}
}
