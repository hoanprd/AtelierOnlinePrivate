using UnityEngine;

public class AlterExecuteResultExtraSkill : MonoBehaviour
{
	[SerializeField]
	private AlterExecuteResultSkillItem m_sFixSkill;

	[SerializeField]
	private GameObject m_goMultiBar;

	[SerializeField]
	private GameObject m_goNonText;

	[SerializeField]
	private GameObject m_goMultiButton;

	[SerializeField]
	private AlterCandidateSkillList m_sCandidateSkill;

	[SerializeField]
	private GameObject m_goRankUp;

	public SkillMark m_skillMark;

	private AlchemyConfirm.Item m_sDetail;

	public void Init(AlchemyConfirm.Item detail)
	{
	}

	public void OnCandidateSkillList()
	{
	}
}
