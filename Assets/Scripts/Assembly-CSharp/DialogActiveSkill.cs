using UnityEngine;

public class DialogActiveSkill : UIWindowBase
{
	[SerializeField]
	private UILabel m_sSkillName;

	[SerializeField]
	private UITexture m_sSkillIcon;

	[SerializeField]
	private UILabel m_sContext;

	[SerializeField]
	private GameObject m_sSkillStatus;

	[SerializeField]
	private UIGrid m_sSkillStatusRoot;

	private bool m_bDestroy;

	private bool m_bBringin;

	public void OnAnimationEnd()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public void Init(ActiveSkill master)
	{
	}

	public static DialogActiveSkill CreateDialog(int df)
	{
		return null;
	}
}
