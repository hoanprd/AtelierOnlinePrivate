using UnityEngine;

public class NGUI_ClickButton : MonoBehaviour
{
	protected UIButton m_targetUIButton;

	protected UIEventTrigger m_targetUIEvent;

	protected GameObject m_target;

	protected void Awake()
	{
	}

	protected virtual void AwakeSub()
	{
	}

	protected UIButton GetButtonScr(Transform target)
	{
		return null;
	}

	protected void DecideCallback()
	{
	}

	protected virtual void DecideButton()
	{
	}

	protected void OnEnable()
	{
	}

	protected virtual void OnEnable_Sub()
	{
	}

	public void SetEnableTouch(bool enableTouch)
	{
	}

	public void SetEnableDraw(bool enableDraw)
	{
	}

	public bool IsEnableTouch()
	{
		return false;
	}
}
