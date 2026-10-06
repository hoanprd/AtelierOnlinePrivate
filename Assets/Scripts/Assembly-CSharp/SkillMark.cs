using UnityEngine;

public class SkillMark : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sValue;

	[SerializeField]
	private UISprite m_sSkillMarkIcon;

	[SerializeField]
	private UILabel m_sDetail;

	public void Init(ActiveSkill skill)
	{
	}
}
