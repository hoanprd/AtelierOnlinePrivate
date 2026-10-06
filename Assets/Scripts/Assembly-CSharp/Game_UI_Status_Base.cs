using UnityEngine;

public class Game_UI_Status_Base : MonoBehaviour
{
	private float m_fLerpRate;

	private Color m_sDefaultColor;

	private readonly Color m_sDecColor;

	private readonly Color m_sAddColor;

	protected void Lerp(UILabel label, ref int value, int target)
	{
	}
}
