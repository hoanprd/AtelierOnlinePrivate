using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UIRepeatButton : MonoBehaviour
{
	public float m_fDefaultWaitTime;

	public Color m_sDisableColor;

	public List<EventDelegate> m_sEvent;

	public UITweenReset m_sClickAnim;

	private Stopwatch m_sStopWatch;

	private bool m_bLongtap;

	private float m_fWaitTime;

	private bool m_bEnabled;

	private UIWidget[] m_sSprite;

	private Collider m_sCollider;

	public bool IsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Awake()
	{
	}

	private void Update()
	{
	}

	private bool IsLongTap()
	{
		return false;
	}

	private void ExecuteLongTap()
	{
	}

	public void OnButtonPressStart()
	{
	}

	public void OnButtonPressEnd()
	{
	}
}
