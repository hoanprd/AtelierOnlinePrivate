using System;
using UnityEngine;

[ExecuteInEditMode]
public class UISlider : UIProgressBar
{
	private enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
		Upgraded = 2
	}

	[HideInInspector]
	[SerializeField]
	private Transform foreground;

	[HideInInspector]
	[SerializeField]
	private float rawValue = 1f;

	[HideInInspector]
	[SerializeField]
	private Direction direction = Direction.Upgraded;

	[HideInInspector]
	[SerializeField]
	protected bool mInverted;

	public bool isColliderEnabled
	{
		get
		{
			Collider c = GetComponent<Collider>();
			if (c != null) return c.enabled;
			Collider2D b = GetComponent<Collider2D>();
			return b != null && b.enabled;
		}
	}

	[Obsolete]
	public float sliderValue
	{
		get { return value; }
		set { this.value = value; }
	}

	[Obsolete]
	public bool inverted
	{
		get { return isInverted; }
		set { }
	}

	protected override void Upgrade()
	{
		if (direction != Direction.Upgraded)
		{
			mValue = rawValue;
			if (foreground != null)
				mFG = foreground.GetComponent<UIWidget>();
			if (direction == Direction.Horizontal)
				mFill = (mInverted ? FillDirection.RightToLeft : FillDirection.LeftToRight);
			else
				mFill = (mInverted ? FillDirection.TopToBottom : FillDirection.BottomToTop);
			direction = Direction.Upgraded;
		}
	}

	protected override void OnStart()
	{
		GameObject bg = ((mBG != null && (mBG.GetComponent<Collider>() != null || mBG.GetComponent<Collider2D>() != null)) ? mBG.gameObject : gameObject);
		UIEventListener bgl = UIEventListener.Get(bg);
		bgl.onPress = (UIEventListener.BoolDelegate)Delegate.Combine(bgl.onPress, new UIEventListener.BoolDelegate(OnPressBackground));
		bgl.onDrag = (UIEventListener.VectorDelegate)Delegate.Combine(bgl.onDrag, new UIEventListener.VectorDelegate(OnDragBackground));

		if (thumb != null && (thumb.GetComponent<Collider>() != null || thumb.GetComponent<Collider2D>() != null) && (mFG == null || thumb != mFG.cachedTransform))
		{
			UIEventListener fgl = UIEventListener.Get(thumb.gameObject);
			fgl.onPress = (UIEventListener.BoolDelegate)Delegate.Combine(fgl.onPress, new UIEventListener.BoolDelegate(OnPressForeground));
			fgl.onDrag = (UIEventListener.VectorDelegate)Delegate.Combine(fgl.onDrag, new UIEventListener.VectorDelegate(OnDragForeground));
		}
	}

	protected void OnPressBackground(GameObject go, bool isPressed)
	{
		if (UICamera.currentScheme == UICamera.ControlScheme.Controller) return;
		mCam = UICamera.currentCamera;
		value = ScreenToValue(UICameraExt.lastEventPosition_Safe());
		if (!isPressed && onDragFinished != null) onDragFinished();
	}

	protected void OnDragBackground(GameObject go, Vector2 delta)
	{
		if (UICamera.currentScheme == UICamera.ControlScheme.Controller) return;
		mCam = UICamera.currentCamera;
		value = ScreenToValue(UICameraExt.lastEventPosition_Safe());
	}

	protected void OnPressForeground(GameObject go, bool isPressed)
	{
		if (UICamera.currentScheme == UICamera.ControlScheme.Controller) return;
		mCam = UICamera.currentCamera;
		if (isPressed)
		{
			mOffset = ((mFG == null) ? 0f : (value - ScreenToValue(UICameraExt.lastEventPosition_Safe())));
		}
		else if (onDragFinished != null)
		{
			onDragFinished();
		}
	}

	protected void OnDragForeground(GameObject go, Vector2 delta)
	{
		if (UICamera.currentScheme == UICamera.ControlScheme.Controller) return;
		mCam = UICamera.currentCamera;
		value = mOffset + ScreenToValue(UICameraExt.lastEventPosition_Safe());
	}

	public override void OnPan(Vector2 delta)
	{
		if (enabled && isColliderEnabled) base.OnPan(delta);
	}
}

internal static class UICameraExt
{
	public static Vector2 lastEventPosition_Safe()
	{
		return (UICamera.currentTouch != null) ? UICamera.currentTouch.pos : (Vector2)Input.mousePosition;
	}
}
