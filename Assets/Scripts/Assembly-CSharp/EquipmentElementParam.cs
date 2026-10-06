using UnityEngine;

public class EquipmentElementParam : MonoBehaviour
{
	public UILabel m_sName;

	public UISprite m_sElementIcon;

	public UILabel m_sValue;

	public UILabel m_sExValue;

	public UILabel m_sDiffValue;

	public UISprite m_sUpMark;

	public UISprite m_sDownMark;

	private readonly string[] casELEMENT_NAME;

	public void SetValue(EElement element, int now, int extra)
	{
	}

	public void SetValue(EElement element, int prev, int now, int extra)
	{
	}
}
