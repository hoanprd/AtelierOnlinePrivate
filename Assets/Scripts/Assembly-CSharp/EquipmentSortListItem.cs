using UnityEngine;

public class EquipmentSortListItem : MonoBehaviour
{
	public UIToggle m_sToggle;

	public UIToggledObjects m_sToggleObj;

	public UILabel m_sName;

	private int m_iKind;

	public int Kind
	{
		get
		{
			return 0;
		}
	}

	public void Init(int kind, string name)
	{
	}

	public void SetStatus(bool sw, bool notify)
	{
	}
}
