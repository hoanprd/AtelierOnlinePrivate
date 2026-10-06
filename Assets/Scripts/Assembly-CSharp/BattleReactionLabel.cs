using UnityEngine;

public class BattleReactionLabel : MonoBehaviour
{
	private enum EStep
	{
		eBRINGIN = 1,
		eDOWN = 2,
		eDISMISS = 3,
		eEND = 4
	}

	public UILabel m_sContent;

	private EStep m_eNext;

	private UITweenReset m_sAnim;

	public void Init(string content)
	{
	}

	public bool Move()
	{
		return false;
	}

	private void InitAnim(EStep step)
	{
	}
}
