using System.Diagnostics;
using UnityEngine;

public class LongTapButton : MonoBehaviour
{
	public float m_f32WaitTime;

	private float m_fChancelDragRadius;

	public UIButton m_sButton;

	public EventDelegate m_sEvent;

	public EventDelegate m_eEvent;

	private Stopwatch m_sStopWatch;

	private UIButtonMessage m_sPressEvent;

	private UIButtonMessage m_sReleaseEvent;

	private Vector2 m_vDragStartPos;

	private bool m_bDragStart;

	public void Awake()
	{
	}

	public void Init()
	{
	}

	public void SetStartDelegate(EventDelegate del)
	{
	}

	public void SetEndDelegate(EventDelegate del)
	{
	}

	public void SetStartDelegate(MonoBehaviour target, string method)
	{
	}

	public void SetEndDelegate(MonoBehaviour target, string method)
	{
	}

	private void Update()
	{
	}

	private void OnButtonPressStart()
	{
	}

	private void OnButtonPressEnd()
	{
	}
}
