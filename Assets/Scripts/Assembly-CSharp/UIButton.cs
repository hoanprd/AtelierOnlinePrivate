using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton : UIButtonColor
{
    public static UIButton current;

    public bool dragHighlight;

    public string hoverSprite;

    public string pressedSprite;

    public string disabledSprite;

    public Sprite hoverSprite2D;

    public Sprite pressedSprite2D;

    public Sprite disabledSprite2D;

    public bool pixelSnap;

    public List<EventDelegate> onClick = new List<EventDelegate>();

    [NonSerialized]
    private UISprite mSprite;

    [NonSerialized]
    private UI2DSprite mSprite2D;

    [NonSerialized]
    private string mNormalSprite;

    [NonSerialized]
    private Sprite mNormalSprite2D;

    public override bool isEnabled
    {
        get
        {
            Collider col = GetComponent<Collider>();
            if (col != null) return col.enabled;
            Collider2D col2d = GetComponent<Collider2D>();
            return col2d != null && col2d.enabled;
        }
        set
        {
            if (isEnabled != value)
            {
                Collider col = GetComponent<Collider>();
                if (col != null) col.enabled = value;
                Collider2D col2d = GetComponent<Collider2D>();
                if (col2d != null) col2d.enabled = value;

                UIButtonColor[] comps = GetComponentsInChildren<UIButtonColor>(true);
                for (int i = 0, imax = comps.Length; i < imax; i++)
                {
                    UIButtonColor b = comps[i];
                    b.isEnabled = value;
                    b.SetState(value ? State.Normal : State.Disabled, false);
                }
            }
        }
    }

    public string normalSprite
    {
        get
        {
            if (!mInitDone) OnInit();
            return mNormalSprite;
        }
        set
        {
            if (!mInitDone) OnInit();
            if (mSprite != null && !string.IsNullOrEmpty(mNormalSprite) && mNormalSprite == mSprite.spriteName)
            {
                mNormalSprite = value;
                SetSprite(value);
            }
            else
            {
                mNormalSprite = value;
            }
        }
    }

    public Sprite normalSprite2D
    {
        get
        {
            if (!mInitDone) OnInit();
            return mNormalSprite2D;
        }
        set
        {
            if (!mInitDone) OnInit();
            if (mSprite2D != null && mNormalSprite2D == mSprite2D.sprite2D)
            {
                mNormalSprite2D = value;
                SetSprite(value);
            }
            else
            {
                mNormalSprite2D = value;
            }
        }
    }

    protected override void OnInit()
    {
        base.OnInit();
        mSprite = (mWidget as UISprite);
        mSprite2D = (mWidget as UI2DSprite);

        if (mSprite != null)
        {
            mNormalSprite = mSprite.spriteName;
        }
        if (mSprite2D != null)
        {
            mNormalSprite2D = mSprite2D.sprite2D;
        }
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        if (mSprite != null && !string.IsNullOrEmpty(mNormalSprite))
        {
            mSprite.spriteName = mNormalSprite;
        }
    }

    protected override void OnDragOver()
    {
        if (isEnabled && (dragHighlight || UICamera.currentTouch.pressed == gameObject))
        {
            base.OnDragOver();
        }
    }

    protected override void OnDragOut()
    {
        if (isEnabled && (dragHighlight || UICamera.currentTouch.pressed == gameObject))
        {
            base.OnDragOut();
        }
    }

    protected virtual void OnClick()
    {
        if (isEnabled)
        {
            current = this;
            EventDelegate.Execute(onClick);
            current = null;
        }
    }

    public override void SetState(State state, bool immediate)
    {
        base.SetState(state, immediate);

        switch (state)
        {
            case State.Normal:
                SetSprite(mNormalSprite);
                SetSprite(mNormalSprite2D);
                break;
            case State.Hover:
                SetSprite(string.IsNullOrEmpty(hoverSprite) ? mNormalSprite : hoverSprite);
                SetSprite(hoverSprite2D == null ? mNormalSprite2D : hoverSprite2D);
                break;
            case State.Pressed:
                SetSprite(string.IsNullOrEmpty(pressedSprite) ? mNormalSprite : pressedSprite);
                SetSprite(pressedSprite2D == null ? mNormalSprite2D : pressedSprite2D);
                break;
            case State.Disabled:
                SetSprite(string.IsNullOrEmpty(disabledSprite) ? mNormalSprite : disabledSprite);
                SetSprite(disabledSprite2D == null ? mNormalSprite2D : disabledSprite2D);
                break;
        }
    }

    protected void SetSprite(string sp)
    {
        if (mSprite != null && !string.IsNullOrEmpty(sp) && mSprite.spriteName != sp)
        {
            mSprite.spriteName = sp;
            mSprite.MakePixelPerfect();
            if (pixelSnap)
            {
                Vector3 pos = mSprite.cachedTransform.localPosition;
                pos.x = Mathf.Round(pos.x);
                pos.y = Mathf.Round(pos.y);
                mSprite.cachedTransform.localPosition = pos;
            }
        }
    }

    protected void SetSprite(Sprite sp)
    {
        if (mSprite2D != null && sp != null && mSprite2D.sprite2D != sp)
        {
            mSprite2D.sprite2D = sp;
            mSprite2D.MakePixelPerfect();
            if (pixelSnap)
            {
                Vector3 pos = mSprite2D.cachedTransform.localPosition;
                pos.x = Mathf.Round(pos.x);
                pos.y = Mathf.Round(pos.y);
                mSprite2D.cachedTransform.localPosition = pos;
            }
        }
    }
}