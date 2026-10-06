using UnityEngine;

public class System_Resolution_Manager : MonoBehaviour
{
	public enum eDisplayRatioKind
	{
		Ratio_3_2 = 0,
		Ratio_4_3 = 1,
		Ratio_16_9 = 2,
		Ratio_2_1 = 3,
		EnumMax = 4
	}

	public static readonly float[] sc_fRatioValue;

	public eDisplayRatioKind m_eDEBUG_RatioKind;

	private static eDisplayRatioKind m_eRatioKind;

	private void Awake()
	{
	}

	public void CheckDisplayRatio()
	{
	}

	public static eDisplayRatioKind GetRatioKind()
	{
		return eDisplayRatioKind.Ratio_3_2;
	}
}
