using UnityEngine;

public class EquipmentVisualItem : MonoBehaviour
{
	[SerializeField]
	private EEquipVisualPart m_ePart;

	[SerializeField]
	private GameObject m_sOn;

	[SerializeField]
	private GameObject m_sOff;

	private bool m_bIsVisual;

	public bool IsVisual
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EEquipVisualPart Part
	{
		get
		{
			return EEquipVisualPart.eHEAD;
		}
	}
}
