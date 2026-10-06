using UnityEngine;

public class EquipmentAutoStatusPriorityToggle : MonoBehaviour
{
	[SerializeField]
	private UIToggle m_sToggle;

	[SerializeField]
	private EquipStatusEnum m_eStatusPriority;

	public UIToggle Toggle
	{
		get
		{
			return null;
		}
	}

	public EquipStatusEnum StatusPriority
	{
		get
		{
			return EquipStatusEnum.NONE;
		}
	}
}
