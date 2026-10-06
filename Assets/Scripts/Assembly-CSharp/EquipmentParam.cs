using UnityEngine;

public class EquipmentParam : EquipParamItem
{
	[SerializeField]
	private Color m_sUpColor;

	[SerializeField]
	private Color m_sDownColor;

	[SerializeField]
	private UILabel m_sVariation;

	[SerializeField]
	private GameObject m_sUpMark;

	[SerializeField]
	private GameObject m_sDownMark;

	[SerializeField]
	private UILabel m_sExtraValue;

	public void SetValue(int now, int extra, int element)
	{
	}

	public void SetValue(int prev, int now, int extra, int element)
	{
	}
}
