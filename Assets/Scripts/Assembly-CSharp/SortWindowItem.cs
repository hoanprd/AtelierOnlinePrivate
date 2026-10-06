using UnityEngine;

public class SortWindowItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UISprite m_sIcon;

	[SerializeField]
	private UIToggle m_sToggle;

	[SerializeField]
	private UIToggledObjects m_sToggleObject;

	private int m_iID;

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

	public int ID
	{
		get
		{
			return 0;
		}
	}

	public void Init(SortItemInfo info, bool select)
	{
	}

	public void Init(int id, string name, int icon, bool select)
	{
	}
}
