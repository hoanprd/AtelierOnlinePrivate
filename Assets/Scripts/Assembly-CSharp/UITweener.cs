using System;
using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

public abstract class UITweener : MonoBehaviour
{
	[DoNotObfuscateNGUI]
	public enum Method
	{
		Linear = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
		BounceIn = 4,
		BounceOut = 5
	}

	[DoNotObfuscateNGUI]
	public enum Style
	{
		Once = 0,
		Loop = 1,
		PingPong = 2
	}

	public static UITweener current;

	[HideInInspector]
	public Method method;

	[HideInInspector]
	public Style style;

	[HideInInspector]
	public AnimationCurve animationCurve = new AnimationCurve(new Keyframe(0f, 0f, 0f, 1f), new Keyframe(1f, 1f, 1f, 0f));

	[HideInInspector]
	public bool ignoreTimeScale = true;

	[HideInInspector]
	public float delay;

	[HideInInspector]
	public float duration = 1f;

	[HideInInspector]
	public bool steeperCurves;

	[HideInInspector]
	public int tweenGroup;

	public bool useFixedUpdate;

	[HideInInspector]
	public List<EventDelegate> onFinished = new List<EventDelegate>();

	[HideInInspector]
	public GameObject eventReceiver;

	[HideInInspector]
	public string callWhenFinished;

	[NonSerialized]
	public float timeScale = 1f;

	private bool mStarted;

	private float mStartTime;

	private float mDuration;

	private float mAmountPerDelta = 1000f;

	private float mFactor;

	private List<EventDelegate> mTemp;

	public float amountPerDelta
	{
		get
		{
			if (duration == 0f)
			{
				return 1000f;
			}
			if (mDuration != duration)
			{
				mDuration = duration;
				mAmountPerDelta = Mathf.Abs((duration > 0f) ? (1f / duration) : 1000f) * Mathf.Sign(mAmountPerDelta);
			}
			return mAmountPerDelta;
		}
	}

	public float tweenFactor
	{
		get
		{
			return mFactor;
		}
		set
		{
			mFactor = Mathf.Clamp01(value);
		}
	}

	public Direction direction
	{
		get
		{
			return (amountPerDelta < 0f) ? Direction.Reverse : Direction.Forward;
		}
	}

	private void Reset()
	{
		if (!mStarted)
		{
			SetStartToCurrentValue();
			SetEndToCurrentValue();
		}
	}

	protected virtual void Start()
	{
		DoUpdate();
	}

	protected void Update()
	{
		if (!useFixedUpdate)
		{
			DoUpdate();
		}
	}

	protected void FixedUpdate()
	{
		if (useFixedUpdate)
		{
			DoUpdate();
		}
	}

	protected void DoUpdate()
	{
		float delta = (ignoreTimeScale && !useFixedUpdate) ? Time.unscaledDeltaTime : Time.deltaTime;
		if (timeScale > 0f && timeScale != 1f)
		{
			delta *= timeScale;
		}
		float now = (ignoreTimeScale && !useFixedUpdate) ? Time.unscaledTime : Time.time;
		if (!mStarted)
		{
			delta = 0f;
			mStarted = true;
			mStartTime = now + delay;
		}
		if (now < mStartTime)
		{
			return;
		}
		mFactor += ((duration == 0f) ? 1f : (amountPerDelta * delta));
		if (style == Style.Loop)
		{
			if (mFactor > 1f)
			{
				mFactor -= Mathf.Floor(mFactor);
			}
			else if (mFactor < 0f)
			{
				mFactor = 1f - (mFactor - Mathf.Floor(mFactor));
			}
		}
		else if (style == Style.PingPong)
		{
			if (mFactor > 1f)
			{
				mFactor = 1f - (mFactor - Mathf.Floor(mFactor));
				mAmountPerDelta = 0f - mAmountPerDelta;
			}
			else if (mFactor < 0f)
			{
				mFactor = 0f - mFactor;
				mFactor -= Mathf.Floor(mFactor);
				mAmountPerDelta = 0f - mAmountPerDelta;
			}
		}
		if (style == Style.Once && (duration == 0f || mFactor > 1f || mFactor < 0f))
		{
			mFactor = Mathf.Clamp01(mFactor);
			Sample(mFactor, true);
			enabled = false;
			if (current != this)
			{
				UITweener prev = current;
				current = this;
				if (onFinished != null)
				{
					mTemp = onFinished;
					onFinished = new List<EventDelegate>();
					EventDelegate.Execute(mTemp);
					for (int i = 0; i < mTemp.Count; i++)
					{
						EventDelegate ev = mTemp[i];
						if (ev != null && !ev.oneShot)
						{
							EventDelegate.Add(onFinished, ev, ev.oneShot);
						}
					}
					mTemp = null;
				}
				if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
				{
					eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
				}
				current = prev;
			}
		}
		else
		{
			Sample(mFactor, false);
		}
	}

	public void SetOnFinished(EventDelegate.Callback del)
	{
		EventDelegate.Set(onFinished, del);
	}

	public void SetOnFinished(EventDelegate del)
	{
		EventDelegate.Set(onFinished, del);
	}

	public void AddOnFinished(EventDelegate.Callback del)
	{
		EventDelegate.Add(onFinished, del);
	}

	public void AddOnFinished(EventDelegate del)
	{
		EventDelegate.Add(onFinished, del);
	}

	public void RemoveOnFinished(EventDelegate del)
	{
		if (onFinished != null)
		{
			onFinished.Remove(del);
		}
		if (mTemp != null)
		{
			mTemp.Remove(del);
		}
	}

	private void OnDisable()
	{
		mStarted = false;
	}

	public void Finish()
	{
		if (enabled)
		{
			Sample((mAmountPerDelta < 0f) ? 0f : 1f, true);
			enabled = false;
		}
	}

	public void Sample(float factor, bool isFinished)
	{
		float val = Mathf.Clamp01(factor);
		if (method == Method.EaseIn)
		{
			val = 1f - Mathf.Sin((float)Math.PI * 0.5f * (1f - val));
			if (steeperCurves)
			{
				val *= val;
			}
		}
		else if (method == Method.EaseOut)
		{
			val = Mathf.Sin((float)Math.PI * 0.5f * val);
			if (steeperCurves)
			{
				val = 1f - val;
				val = 1f - val * val;
			}
		}
		else if (method == Method.EaseInOut)
		{
			val -= Mathf.Sin(val * ((float)Math.PI * 2f)) / ((float)Math.PI * 2f);
			if (steeperCurves)
			{
				val = val * 2f - 1f;
				float sign = Mathf.Sign(val);
				val = 1f - Mathf.Abs(val);
				val = 1f - val * val;
				val = sign * val * 0.5f + 0.5f;
			}
		}
		else if (method == Method.BounceIn)
		{
			val = BounceLogic(val);
		}
		else if (method == Method.BounceOut)
		{
			val = 1f - BounceLogic(1f - val);
		}
		OnUpdate((animationCurve != null && animationCurve.length > 0) ? animationCurve.Evaluate(val) : val, isFinished);
	}

	private float BounceLogic(float val)
	{
		if (val < 0.363636f)
		{
			val = 7.5685f * val * val;
		}
		else if (val < 0.727272f)
		{
			val -= 0.545454f;
			val = 7.5625f * val * val + 0.75f;
		}
		else if (val < 0.90909f)
		{
			val -= 0.818181f;
			val = 7.5625f * val * val + 0.9375f;
		}
		else
		{
			val -= 0.9545454f;
			val = 7.5625f * val * val + 0.984375f;
		}
		return val;
	}

	[Obsolete]
	public void Play()
	{
		Play(true);
	}

	public void PlayForward()
	{
		Play(true);
	}

	public void PlayReverse()
	{
		Play(false);
	}

	public virtual void Play(bool forward)
	{
		mAmountPerDelta = Mathf.Abs(amountPerDelta);
		if (!forward)
		{
			mAmountPerDelta = 0f - mAmountPerDelta;
		}
		if (!enabled)
		{
			enabled = true;
			mStarted = false;
		}
		DoUpdate();
	}

	public void ResetToBeginning()
	{
		mStarted = false;
		mFactor = ((amountPerDelta < 0f) ? 1f : 0f);
		Sample(mFactor, false);
	}

	public void Toggle()
	{
		if (mFactor > 0f)
		{
			mAmountPerDelta = 0f - amountPerDelta;
		}
		else
		{
			mAmountPerDelta = Mathf.Abs(amountPerDelta);
		}
		enabled = true;
	}

	protected abstract void OnUpdate(float factor, bool isFinished);

	public static T Begin<T>(GameObject go, float duration, float delay = 0f) where T : UITweener
	{
		T comp = go.GetComponent<T>();
		if (comp != null && comp.tweenGroup != 0)
		{
			comp = null;
			T[] comps = go.GetComponents<T>();
			for (int i = 0; i < comps.Length; i++)
			{
				if (comps[i] != null && comps[i].tweenGroup == 0)
				{
					comp = comps[i];
					break;
				}
			}
		}
		if (comp == null)
		{
			comp = go.AddComponent<T>();
			if (comp == null)
			{
				return null;
			}
		}
		comp.mStarted = false;
		comp.mFactor = 0f;
		comp.duration = duration;
		comp.mDuration = duration;
		comp.delay = delay;
		comp.mAmountPerDelta = ((duration > 0f) ? Mathf.Abs(1f / duration) : 1000f);
		comp.style = Style.Once;
		comp.animationCurve = new AnimationCurve(new Keyframe(0f, 0f, 0f, 1f), new Keyframe(1f, 1f, 1f, 0f));
		comp.eventReceiver = null;
		comp.callWhenFinished = null;
		comp.onFinished.Clear();
		if (comp.mTemp != null)
		{
			comp.mTemp.Clear();
		}
		comp.enabled = true;
		return comp;
	}

	public virtual void SetStartToCurrentValue()
	{
	}

	public virtual void SetEndToCurrentValue()
	{
	}
}
