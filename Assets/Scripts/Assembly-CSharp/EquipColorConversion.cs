using System.Collections.Generic;
using UnityEngine;

public class EquipColorConversion : MonoBehaviour
{
	public enum EColor
	{
		eRED = 0,
		ePINK = 1,
		ePURPLE = 2,
		eBLUE = 3,
		eSKY = 4,
		eGREEN = 5,
		eYELLOW = 6,
		eORANGE = 7
	}

	private enum EColorTable
	{
		eRED = 0,
		eGREEN = 1,
		eBLUE = 2
	}

	public float m_fBaseHue;

	public float m_fBaseSaturation;

	public float m_fBaseValue;

	[SerializeField]
	private Color m_sBaseColor;

	[SerializeField]
	private EColor m_eColorKind;

	private List<Material> m_vsMaterials;

	private const string csSHADER_NAME = "Custom/MaskHueConvertion";

	private void OnValidate()
	{
	}

	private void Awake()
	{
	}

	public void Default()
	{
	}

	public void Change(EColor color)
	{
	}

	private void CalcSaturation()
	{
	}

	private void CalcValue()
	{
	}

	private void CalcHue()
	{
	}
}
