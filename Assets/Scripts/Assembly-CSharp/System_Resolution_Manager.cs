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

	static System_Resolution_Manager()
	{
		sc_fRatioValue = new float[4] { 1.5f, 1.3333334f, 1.7777778f, 2f };
		m_eRatioKind = eDisplayRatioKind.EnumMax;
	}

	private void Awake()
	{
		CheckDisplayRatio();
	}

	public void CheckDisplayRatio()
	{
		m_eRatioKind = ComputeRatioKind();
	}

	private static eDisplayRatioKind ComputeRatioKind()
	{
		int w = Screen.width;
		int h = Screen.height;
		if (h <= 0)
		{
			return eDisplayRatioKind.Ratio_16_9;
		}
		float aspect = (w >= h) ? ((float)w / (float)h) : ((float)h / (float)w);
		eDisplayRatioKind best = eDisplayRatioKind.Ratio_16_9;
		float bestDiff = float.MaxValue;
		for (int i = 0; i < sc_fRatioValue.Length; i++)
		{
			float diff = Mathf.Abs(aspect - sc_fRatioValue[i]);
			if (diff < bestDiff)
			{
				bestDiff = diff;
				best = (eDisplayRatioKind)i;
			}
		}
		return best;
	}

	public static eDisplayRatioKind GetRatioKind()
	{
		if (m_eRatioKind == eDisplayRatioKind.EnumMax)
		{
			m_eRatioKind = ComputeRatioKind();
		}
		return m_eRatioKind;
	}
}
