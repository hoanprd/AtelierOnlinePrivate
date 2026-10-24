using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Position")]
public class TweenPosition : UITweener
{
    public Vector3 from;

    public Vector3 to;

    [HideInInspector]
    public bool worldSpace;

    private Transform mTrans;

    private UIRect mRect;

    public Transform cachedTransform
    {
        get
        {
            if (mTrans == null)
            {
                mTrans = transform;
            }
            return mTrans;
        }
    }

    [Obsolete("Use 'value' instead")]
    public Vector3 position
    {
        get
        {
            return value;
        }
        set
        {
            this.value = value;
        }
    }

    public Vector3 value
    {
        get
        {
            if (mRect == null)
            {
                mRect = GetComponent<UIRect>();
            }

            if (mRect != null && !worldSpace)
            {
                return mRect.cachedTransform.localPosition;
            }
            return worldSpace ? cachedTransform.position : cachedTransform.localPosition;
        }
        set
        {
            if (mRect == null)
            {
                mRect = GetComponent<UIRect>();
            }

            if (mRect != null && !worldSpace)
            {
                mRect.cachedTransform.localPosition = value;
            }
            else
            {
                if (worldSpace)
                {
                    cachedTransform.position = value;
                }
                else
                {
                    cachedTransform.localPosition = value;
                }
            }
        }
    }

    private void Awake()
    {
        mRect = GetComponent<UIRect>();
    }

    protected override void OnUpdate(float factor, bool isFinished)
    {
        value = Vector3.Lerp(from, to, factor);
    }

    public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
    {
        TweenPosition comp = UITweener.Begin<TweenPosition>(go, duration);
        comp.from = comp.value;
        comp.to = pos;
        comp.worldSpace = false;

        if (duration <= 0f)
        {
            comp.Sample(1f, true);
            comp.enabled = false;
        }
        return comp;
    }

    public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
    {
        TweenPosition comp = UITweener.Begin<TweenPosition>(go, duration);
        comp.from = comp.value;
        comp.to = pos;
        comp.worldSpace = worldSpace;

        if (duration <= 0f)
        {
            comp.Sample(1f, true);
            comp.enabled = false;
        }
        return comp;
    }

    public override void SetStartToCurrentValue()
    {
        from = value;
    }

    public override void SetEndToCurrentValue()
    {
        to = value;
    }

    private void SetCurrentValueToStart()
    {
        value = from;
    }

    private void SetCurrentValueToEnd()
    {
        value = to;
    }
}