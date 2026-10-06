using System.Collections.Generic;
using UnityEngine;

public class UITweenReset : MonoBehaviour
{
	public GameObject m_root;

	public int m_tweenGroup;

	public bool m_inChildren;

	public UITweener[] m_tween;

	public bool m_onActive;

	public List<EventDelegate> m_onFinished;

	private EventDelegate m_onFinishedCallback;

	private bool m_forward;

	private int m_tweenCount;

	private float m_fWaitTime;

	private float m_fPassedTime;

	public bool IsForward
	{
		get
		{
			return false;
		}
	}

	private EventDelegate FinishCallback
	{
		get
		{
			return null;
		}
	}

	public bool IsAnimEnd
	{
		get
		{
			return false;
		}
	}

	private void Update()
	{
	}

	public void FindTweener()
	{
	}

	public void SetStart(bool callOnFinish = false)
	{
	}

	public void SetFinish(bool callOnFinish = false)
	{
	}

	public void ResetTween(bool forward = true, bool reset = true)
	{
	}

	public void Reset()
	{
	}

	public void TweenReverse()
	{
	}

	public void TweenForward()
	{
	}

	public void ResetTweenReverse()
	{
	}

	public void ResetTweenForward()
	{
	}

	public void SetOnFinish(EventDelegate del)
	{
	}

	public void AddOnFinish(EventDelegate del)
	{
	}

	public void RemoveOnFinish(EventDelegate del)
	{
	}

	public void ResetOnFinish()
	{
	}

	public void OnEnable()
	{
	}

	public void Clear()
	{
	}

	public float GetPlayPer()
	{
		return 0f;
	}

	private void OnFinish()
	{
	}
}
