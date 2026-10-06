using UnityEngine;

public class EquipSkillItem : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private SkillMark m_sSkillMark;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UIButton m_sDetailButton;

	[SerializeField]
	private GameObject m_goNone;

	private ActiveSkill m_sMaster;

	public ActiveSkill Skill
	{
		get
		{
			return null;
		}
	}

	public void SetOnDetailEvent(MonoBehaviour target, string methodName)
	{
	}

	public void SetChangeColor()
	{
	}

	public void Init(ActiveSkill skill)
	{
	}

	public void OnDetail()
	{
	}
}
