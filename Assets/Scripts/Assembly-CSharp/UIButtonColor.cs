using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIButtonColor : UIWidgetContainer
{
    [DoNotObfuscateNGUI]
    public enum State
    {
        Normal = 0,
        Hover = 1,
        Pressed = 2,
        Disabled = 3
    }

    private class ChildInfo
    {
        public Color m_defColor;
        public GameObject m_object;

        public ChildInfo(GameObject obj, Color defColor)
        {
            m_object = obj;
            m_defColor = defColor;
        }
    }

    private ChildInfo[] mChildWidgets;

    public bool mOnChildTween = false;

    public GameObject tweenTarget;

    public Color hover = new Color(0.8f, 0.8f, 0.8f, 1f);

    public Color pressed = new Color(0.7f, 0.7f, 0.7f, 1f);

    public Color disabledColor = new Color(0.5f, 0.5f, 0.5f, 1f);

    public float duration = 0.15f;

    [NonSerialized]
    protected Color mStartingColor;

    [NonSerialized]
    protected Color mDefaultColor;

    [NonSerialized]
    protected bool mInitDone;

    [NonSerialized]
    protected UIWidget mWidget;

    [NonSerialized]
    protected State mState = State.Normal;

    public State state
    {
        get
        {
            return mState;
        }
        set
        {
            SetState(value, false);
        }
    }

    public Color defaultColor
    {
        get
        {
            if (!mInitDone) CacheDefaultColor();
            return mDefaultColor;
        }
        set
        {
            if (!mInitDone) CacheDefaultColor();
            mDefaultColor = value;
            UpdateColor(true);
        }
    }

    public virtual bool isEnabled
    {
        get
        {
            return enabled;
        }
        set
        {
            if (enabled != value)
            {
                enabled = value;
                SetState(value ? (UICamera.hoveredObject == gameObject ? State.Hover : State.Normal) : State.Disabled, false);
            }
        }
    }

    public void ResetDefaultColor()
    {
        defaultColor = mStartingColor;
    }

    public void CacheDefaultColor()
    {
        if (mInitDone) return;
        mInitDone = true;

        if (tweenTarget == null)
            tweenTarget = gameObject;

        mWidget = tweenTarget.GetComponent<UIWidget>();
        if (mWidget != null)
        {
            mStartingColor = mWidget.color;
            mDefaultColor = mStartingColor;
        }
        else
        {
            Renderer ren = tweenTarget.GetComponent<Renderer>();
            if (ren != null)
            {
                if (ren.sharedMaterial != null)
                {
                    mStartingColor = ren.sharedMaterial.color;
                    mDefaultColor = mStartingColor;
                }
            }
            else
            {
                Light lt = tweenTarget.GetComponent<Light>();
                if (lt != null)
                {
                    mStartingColor = lt.color;
                    mDefaultColor = mStartingColor;
                }
            }
        }
    }

    private void Start()
    {
        if (!mInitDone) CacheDefaultColor();
        if (!isEnabled) SetState(State.Disabled, true);
    }

    protected virtual void OnInit()
    {
        CacheDefaultColor();
    }

    protected virtual void OnEnable()
    {
        if (mInitDone)
        {
            if (isEnabled)
            {
                SetState(UICamera.hoveredObject == gameObject ? State.Hover : State.Normal, true);
            }
            else
            {
                SetState(State.Disabled, true);
            }
        }
    }

    protected virtual void OnDisable()
    {
        if (mInitDone && mState == State.Disabled)
        {
            SetState(State.Normal, true);
        }
    }

    protected virtual void OnHover(bool isOver)
    {
        if (isEnabled)
        {
            if (!mInitDone) CacheDefaultColor();
            SetState(isOver ? State.Hover : State.Normal, false);
        }
    }

    protected virtual void OnPress(bool isPressed)
    {
        if (isEnabled)
        {
            if (!mInitDone) CacheDefaultColor();
            SetState(isPressed ? State.Pressed : (UICamera.hoveredObject == gameObject ? State.Hover : State.Normal), false);
        }
    }

    protected virtual void OnDragOver()
    {
        if (isEnabled)
        {
            if (!mInitDone) CacheDefaultColor();
            SetState(State.Pressed, false);
        }
    }

    protected virtual void OnDragOut()
    {
        if (isEnabled)
        {
            if (!mInitDone) CacheDefaultColor();
            SetState(State.Normal, false);
        }
    }

    public virtual void SetState(State state, bool instant)
    {
        if (!mInitDone)
        {
            mInitDone = true;
            CacheDefaultColor();
        }

        if (mState != state || !instant)
        {
            mState = state;
            UpdateColor(instant);
        }
    }

    public void UpdateColor(bool instant)
    {
        if (!mInitDone) CacheDefaultColor();

        Color col = mDefaultColor;
        switch (mState)
        {
            case State.Hover: col = hover; break;
            case State.Pressed: col = pressed; break;
            case State.Disabled: col = disabledColor; break;
        }

        if (tweenTarget != null)
        {
            if (duration == 0f || instant || !Application.isPlaying)
            {
                TweenColor.Begin(tweenTarget, 0f, col);
            }
            else
            {
                TweenColor.Begin(tweenTarget, duration, col);
            }
        }

        if (mOnChildTween)
        {
            UpdateChildColor(instant);
        }
    }

    private void UpdateChildColor(bool instant)
    {
        if (mChildWidgets == null)
        {
            UIWidget[] widgets = GetComponentsInChildren<UIWidget>(true);
            mChildWidgets = new ChildInfo[widgets.Length];
            for (int i = 0; i < widgets.Length; i++)
            {
                mChildWidgets[i] = new ChildInfo(widgets[i].gameObject, widgets[i].color);
            }
        }

        Color col = mDefaultColor;
        switch (mState)
        {
            case State.Hover: col = hover; break;
            case State.Pressed: col = pressed; break;
            case State.Disabled: col = disabledColor; break;
        }

        for (int i = 0; i < mChildWidgets.Length; i++)
        {
            ChildInfo info = mChildWidgets[i];
            if (info.m_object != null)
            {
                UIWidget w = info.m_object.GetComponent<UIWidget>();
                if (w != null)
                {
                    Color targetCol = new Color(
                        info.m_defColor.r * col.r,
                        info.m_defColor.g * col.g,
                        info.m_defColor.b * col.b,
                        info.m_defColor.a * col.a
                    );

                    if (duration == 0f || instant || !Application.isPlaying)
                    {
                        w.color = targetCol;
                    }
                    else
                    {
                        TweenColor.Begin(w.gameObject, duration, targetCol);
                    }
                }
            }
        }
    }
}