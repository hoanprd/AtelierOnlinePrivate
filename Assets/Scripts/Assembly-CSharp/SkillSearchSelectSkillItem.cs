using UnityEngine;

public class SkillSearchSelectSkillItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sCategoryName;

	[SerializeField]
	private UILabel m_sName;

	private int m_iID;

	public int ID
	{
		get
		{
			return 0;
		}
	}

	public void Init(SkillCategRecord categ)
	{
	}
}
