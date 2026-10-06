using UnityEngine;

public class BlazeArtsListItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UIButton m_sDetailButton;

	[SerializeField]
	private UILabel m_sLv;

	private ActiveSkill m_sMaster;

	private int m_iLv;

	public void Init(MasterChara.Skill skill)
	{
	}

	public void OnDetail()
	{
	}
}
