using UnityEngine;

public class SkillSearchLineupItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UIToggle m_sToggle;

	[SerializeField]
	private UIToggledObjects m_sToggleObj;

	private int m_iID;

	public int ID
	{
		get
		{
			return 0;
		}
	}

	public bool Select
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(string name, int id, bool select)
	{
	}
}
