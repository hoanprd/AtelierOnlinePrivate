using UnityEngine;

public class ItemListFilterItem : MonoBehaviour
{
	public UIToggle m_sToggle;

	public UIToggledObjects m_sToggleObject;

	public UILabel m_sName;

	public UISprite m_sCategoryIcon;

	private int m_iCategory;

	public int Category
	{
		get
		{
			return 0;
		}
	}

	public bool IsSelect
	{
		get
		{
			return false;
		}
	}

	public void Init(int category, bool select)
	{
	}
}
