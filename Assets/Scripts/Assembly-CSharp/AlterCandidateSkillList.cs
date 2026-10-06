using UnityEngine;

public class AlterCandidateSkillList : UIListViewBase<AlterCandidateSkillItem>
{
	[SerializeField]
	private UIScrollListArrow m_sArrow;

	[SerializeField]
	private UITweenReset m_sAnim;

	public virtual void Bringin()
	{
	}

	public virtual void OnClose()
	{
	}

	protected virtual void OnCloseEnd()
	{
	}

	public void Init(AlchemyConfirm.CandidateSkill[] candidates)
	{
	}
}
