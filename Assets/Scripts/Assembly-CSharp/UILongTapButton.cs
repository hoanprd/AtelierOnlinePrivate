using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UILongTapButton : MonoBehaviour
{
	public float m_fWaitTime;

	public List<EventDelegate> m_sEvent;

	public List<EventDelegate> m_sLongEvent;

	public List<EventDelegate> m_sReleaseEvent;

	public UITweenReset m_sClickAnim;

	private Stopwatch m_sStopWatch;

	private bool m_bLongtap;

	private bool m_bTapEnd;

	public bool IsClickEnabled { get; set; }

	public bool IsLongTapEnabled { get; set; }

	public bool IsCheckTutorial { get; set; }

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

	public void OnButtonClick()
	{
	}

	public void OnButtonPressStart()
	{
	}

	public void OnButtonPressEnd()
	{
	}

	public void OnDrag()
	{
	}
}
