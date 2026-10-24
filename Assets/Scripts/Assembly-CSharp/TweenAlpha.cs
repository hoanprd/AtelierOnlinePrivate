using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Alpha")]
public class TweenAlpha : UITweener
{
    public float from = 1f;
    public float to = 1f;

    private bool mCached;
    private UIRect mRect;
    private Material mMat;
    private Light mLight;
    private SpriteRenderer mSr;
    private float mBaseIntensity = 1f;

    [System.Obsolete("Use 'value' instead")]
    public float alpha
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

    public float value
    {
        get
        {
            if (!mCached) Cache();
            if (mRect != null) return mRect.alpha;
            if (mSr != null) return mSr.color.a;
            if (mMat != null) return mMat.color.a;
            if (mLight != null) return mLight.intensity / mBaseIntensity;
            return 1f;
        }
        set
        {
            if (!mCached) Cache();
            if (mRect != null)
            {
                mRect.alpha = value;
            }
            else if (mSr != null)
            {
                Color c = mSr.color;
                c.a = value;
                mSr.color = c;
            }
            else if (mMat != null)
            {
                Color c = mMat.color;
                c.a = value;
                mMat.color = c;
            }
            else if (mLight != null)
            {
                mLight.intensity = mBaseIntensity * value;
            }
        }
    }

    private void Cache()
    {
        mCached = true;
        mRect = GetComponent<UIRect>();
        if (mRect == null)
        {
            mSr = GetComponent<SpriteRenderer>();
            if (mSr == null)
            {
                mLight = GetComponent<Light>();
                if (mLight != null)
                {
                    mBaseIntensity = mLight.intensity;
                }
                else
                {
                    Renderer ren = GetComponent<Renderer>();
                    if (ren != null)
                    {
                        mMat = ren.material;
                    }
                }
            }
        }
    }

    protected override void OnUpdate(float factor, bool isFinished)
    {
        value = Mathf.Lerp(from, to, factor);
    }

    public static TweenAlpha Begin(GameObject go, float duration, float alpha, float delay = 0f)
    {
        TweenAlpha comp = UITweener.Begin<TweenAlpha>(go, duration);
        comp.from = comp.value;
        comp.to = alpha;
        comp.delay = delay;

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
}