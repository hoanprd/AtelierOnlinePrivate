using UnityEngine;

public class EquipmentFilterListItem : MonoBehaviour
{
	public UIToggle m_sToggle;

	public UIToggledObjects m_sToggleObj;

	public UISprite m_sCategoryIcon;

	private int m_iCategory;

	public int Category
	{
		get
		{
			return 0;
		}
	}

	public void Init(int category)
	{
	}

	public void SetStatus(bool sw, bool notify)
	{
	}
}
