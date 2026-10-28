using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIToggle : UIWidgetContainer
{
	public delegate bool Validate(bool choice);

	public static BetterList<UIToggle> list = new BetterList<UIToggle>();

	public static UIToggle current;

	public int group;

	public UIWidget activeSprite;

	public bool invertSpriteState;

	public Animation activeAnimation;

	public Animator animator;

	public UITweener tween;

	public bool startsActive;

	public bool instantTween;

	public bool optionCanBeNone;

	public List<EventDelegate> onChange = new List<EventDelegate>();

	public Validate validator;

	[HideInInspector]
	[SerializeField]
	private UISprite checkSprite;

	[HideInInspector]
	[SerializeField]
	private Animation checkAnimation;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string functionName = "OnActivate";

	[HideInInspector]
	[SerializeField]
	private bool startsChecked;

	private bool mIsActive = true;

	private bool mStarted;

	public bool value
	{
		get { return mStarted ? mIsActive : startsActive; }
		set
		{
			if (!mStarted) startsActive = value;
			else if (group == 0 || value || optionCanBeNone || !mStarted) Set(value);
		}
	}

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
	public bool isChecked
	{
		get { return value; }
		set { this.value = value; }
	}

	public static UIToggle GetActiveToggle(int group)
	{
		for (int i = 0; i < list.size; i++)
		{
			UIToggle toggle = list.buffer[i];
			if (toggle != null && toggle.group == group && toggle.mIsActive)
				return toggle;
		}
		return null;
	}

	private void OnEnable()
	{
		list.Add(this);
	}

	private void OnDisable()
	{
		list.Remove(this);
	}

	public void Start()
	{
		if (mStarted) return;
		if (startsChecked)
		{
			startsChecked = false;
			startsActive = true;
		}
		if (!Application.isPlaying)
		{
			if (checkSprite != null && activeSprite == null)
			{
				activeSprite = checkSprite;
				checkSprite = null;
			}
			if (checkAnimation != null && activeAnimation == null)
			{
				activeAnimation = checkAnimation;
				checkAnimation = null;
			}
			if (Application.isEditor && activeSprite != null)
				activeSprite.alpha = (invertSpriteState ? (startsActive ? 0f : 1f) : (startsActive ? 1f : 0f));
			return;
		}

		mIsActive = !startsActive;
		mStarted = true;
		bool instant = instantTween;
		instantTween = true;
		Set(startsActive);
		instantTween = instant;
	}

	private void OnClick()
	{
		if (enabled && isColliderEnabled && UICamera.currentTouchID != -2)
			value = !value;
	}

	public void Set(bool state, bool notify = true)
	{
		if (validator != null && !validator(state)) return;

		if (!mStarted)
		{
			mIsActive = state;
			startsActive = state;
			if (activeSprite != null)
				activeSprite.alpha = (invertSpriteState ? (state ? 0f : 1f) : (state ? 1f : 0f));
			return;
		}

		if (mIsActive != state)
		{
			if (group != 0 && state)
			{
				int i = 0;
				int imax = list.size;
				while (i < imax)
				{
					UIToggle cb = list.buffer[i];
					if (cb != this && cb.group == group) cb.Set(false);
					if ( list.size != imax )
					{
						imax = list.size;
						i = 0;
					}
					else ++i;
				}
			}

			mIsActive = state;

			if (activeSprite != null)
			{
				if (instantTween || !NGUITools.GetActive(this))
					activeSprite.alpha = (invertSpriteState ? (mIsActive ? 0f : 1f) : (mIsActive ? 1f : 0f));
				else
					TweenAlpha.Begin(activeSprite.gameObject, 0.15f, invertSpriteState ? (mIsActive ? 0f : 1f) : (mIsActive ? 1f : 0f));
			}

			if (notify && current == null)
			{
				UIToggle tog = current;
				current = this;
				if (EventDelegate.IsValid(onChange))
				{
					EventDelegate.Execute(onChange);
				}
				else if (eventReceiver != null && !string.IsNullOrEmpty(functionName))
				{
					eventReceiver.SendMessage(functionName, mIsActive, SendMessageOptions.DontRequireReceiver);
				}
				current = tog;
			}

			if (tween != null)
			{
				tween.Play(state);
				if (instantTween) tween.tweenFactor = state ? 1f : 0f;
			}
		}
	}
}
