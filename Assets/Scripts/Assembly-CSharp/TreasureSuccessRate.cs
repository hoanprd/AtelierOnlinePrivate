using System.Collections.Generic;
using UnityEngine;

public class TreasureSuccessRate : MonoBehaviour
{
	public enum ERate
	{
		eNORMAL = 1,
		eGREAT = 2,
		eHIGH_GREAT = 3
	}

	[SerializeField]
	private UISprite[] m_asRateFrame;

	[SerializeField]
	private UILabel m_sSuccessPercent;

	[SerializeField]
	private UILabel m_sSuccessKind;

	[SerializeField]
	private UISprite[] m_asGraphs;

	private float[] m_afTargetValue;

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private UITweenReset m_sChangeAnim;

	private float m_fLerpRate;

	private int m_iSuccessKind;

	public void Init(List<HuntRate> rate, bool immidiate = true)
	{
	}

	private void UpdateFrame(HuntRate rate)
	{
	}

	private void Update()
	{
	}

	protected void Lerp(UISprite sprite, float target)
	{
	}
}
