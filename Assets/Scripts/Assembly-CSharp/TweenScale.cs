using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Scale")]
public class TweenScale : UITweener
{
    public Vector3 from = Vector3.one;
    public Vector3 to = Vector3.one;
    public bool updateTable;

    private Transform mTrans;
    private UITable mTable;

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

    public Vector3 value
    {
        get
        {
            return cachedTransform.localScale;
        }
        set
        {
            cachedTransform.localScale = value;
        }
    }

    [System.Obsolete("Use 'value' instead")]
    public Vector3 scale
    {
        get
        {
            return this.value;
        }
        set
        {
            this.value = value;
        }
    }

    protected override void OnUpdate(float factor, bool isFinished)
    {
        value = Vector3.Lerp(from, to, factor);

        if (updateTable)
        {
            if (mTable == null)
            {
                mTable = NGUITools.FindInParents<UITable>(gameObject);
                if (mTable == null)
                {
                    updateTable = false;
                    return;
                }
            }
            mTable.repositionNow = true;
        }
    }

    public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
    {
        TweenScale comp = UITweener.Begin<TweenScale>(go, duration);
        comp.from = comp.value;
        comp.to = scale;

        if (duration <= 0f)
        {
            comp.Sample(1f, true); // Sửa thành chữ S hoa ở đây
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