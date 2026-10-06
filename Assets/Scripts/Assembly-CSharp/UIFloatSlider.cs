using System;
using UnityEngine;

public class UIFloatSlider : MonoBehaviour
{
	public UISlider m_sSlider;

	private float m_fTimer;

	private float m_fSpan;

	private bool m_bUp;

	private bool m_bMove;

	private float m_fMin;

	private float m_fMax;

	private Action m_sUp;

	private Action m_sDown;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	private void Update()
	{
	}

	private void OnDragFinished()
	{
	}

	private void OnChange()
	{
	}

	public void SetSpeed(float min, float max)
	{
	}

	public void SetCallback(Action up, Action down)
	{
	}
}
