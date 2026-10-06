using UnityEngine;

public class SkillCharaListItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UIButton m_sDetailButton;

	[SerializeField]
	private GameObject m_goLockRoot;

	[SerializeField]
	private UILabel m_sLockLV;

	private ActiveSkill m_sMaster;

	public void Init(MasterChara.Skill skill, bool unlock = false)
	{
	}

	public void OnDetail()
	{
	}
}
