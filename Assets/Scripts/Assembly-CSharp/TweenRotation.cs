using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Rotation")]
public class TweenRotation : UITweener
{
    public Vector3 from;

    public Vector3 to;

    public bool quaternionLerp;

    private Transform mTrans;

    public Transform cachedTransform
    {
        get
        {
            if (mTrans == null) mTrans = transform;
            return mTrans;
        }
    }

    [Obsolete("Use 'value' instead")]
    public Quaternion rotation
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

    public Quaternion value
    {
        get
        {
            return cachedTransform.localRotation;
        }
        set
        {
            cachedTransform.localRotation = value;
        }
    }

    protected override void OnUpdate(float factor, bool isFinished)
    {
        if (!quaternionLerp)
        {
            Vector3 eul = Vector3.Lerp(from, to, factor);
            cachedTransform.localEulerAngles = eul;
        }
        else
        {
            cachedTransform.localRotation = Quaternion.Slerp(Quaternion.Euler(from), Quaternion.Euler(to), factor);
        }
    }

    public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
    {
        TweenRotation comp = UITweener.Begin<TweenRotation>(go, duration);
        comp.from = comp.value.eulerAngles;
        comp.to = rot.eulerAngles;

        if (duration <= 0f)
        {
            comp.Sample(1f, true);
            comp.enabled = false;
        }
        return comp;
    }

    public override void SetStartToCurrentValue()
    {
        from = cachedTransform.localEulerAngles;
    }

    public override void SetEndToCurrentValue()
    {
        to = cachedTransform.localEulerAngles;
    }

    private void SetCurrentValueToStart()
    {
        cachedTransform.localEulerAngles = from;
    }

    private void SetCurrentValueToEnd()
    {
        cachedTransform.localEulerAngles = to;
    }
}