using System;
using System.Collections.Generic;

public class UIFloatSliderManager : SingletonBase<UIFloatSliderManager>
{
	public class CallbackData
	{
		public ESliderDirection eDirection;

		public Action sUp;

		public Action sDown;

		public float fMinSpeed;

		public float fMaxSpeed;

		public bool bDisp;
	}

	public UIFloatSlider m_sVertical;

	public UIFloatSlider m_sHorizontal;

	private CallbackData m_sCurrent;

	private List<CallbackData> m_vCallbackList;

	protected override void Awake()
	{
	}

	public bool IsDisp()
	{
		return false;
	}

	public void Suspend()
	{
	}

	public void Resume()
	{
	}

	public void Push(ESliderDirection direction, Action up, Action down, float min = 0.1f, float max = 0.8f)
	{
	}

	public void Pop()
	{
	}

	private void Set()
	{
	}
}
