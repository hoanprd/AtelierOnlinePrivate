using System;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Scroll Bar")]
public class UIScrollBar : UISlider
{
    private enum Direction
    {
        Horizontal = 0,
        Vertical = 1,
        Upgraded = 2
    }

    [HideInInspector]
    [SerializeField]
    protected float mSize = 1f;

    [HideInInspector]
    [SerializeField]
    private float mScroll = 0f;

    [HideInInspector]
    [SerializeField]
    private Direction mDir = Direction.Upgraded;

    [Obsolete]
    public float scrollValue
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

    public float barSize
    {
        get
        {
            return mSize;
        }
        set
        {
            float clamped = Mathf.Clamp01(value);
            if (mSize != clamped)
            {
                mSize = clamped;
                this.value = this.value;
                ForceUpdate();
            }
        }
    }

    protected override void Upgrade()
    {
        if (mDir != Direction.Upgraded)
        {
            mDir = Direction.Upgraded;
            this.value = mScroll;
        }
    }

    protected override void OnStart()
    {
        base.OnStart();
        if (mDir != Direction.Upgraded)
        {
            Upgrade();
        }
    }

    protected override float LocalToValue(Vector2 localPos)
    {
        if (mFG == null) return base.LocalToValue(localPos);

        Bounds b = NGUIMath.CalculateRelativeWidgetBounds(mFG.cachedTransform, mFG.cachedTransform);
        float size = (isHorizontal ? b.size.x : b.size.y);

        if (size == 0f) return 0f;

        float local = (isHorizontal ? (localPos.x - b.min.x) : (localPos.y - b.min.y));
        return Mathf.Clamp01(local / size);
    }

    public override void ForceUpdate()
    {
        if (mFG != null)
        {
            base.ForceUpdate();
            Transform t = (thumb != null) ? thumb : (transform.childCount > 0 ? transform.GetChild(0) : null);
            if (t != null)
            {
                Vector3 scale = mFG.cachedTransform.localScale;
                Vector4 border = mFG.border;

                float width = Mathf.Max(0f, scale.x - border.x - border.z);
                float height = Mathf.Max(0f, scale.y - border.y - border.w);

                Vector3 localScale = t.localScale;

                if (isHorizontal)
                {
                    localScale.x = Mathf.Clamp(width * mSize, height, width);
                }
                else
                {
                    localScale.y = Mathf.Clamp(height * mSize, width, height);
                }

                t.localScale = localScale;
            }
        }
    }
}