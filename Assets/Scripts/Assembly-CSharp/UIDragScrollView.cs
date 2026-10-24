using System;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag Scroll View")]
public class UIDragScrollView : MonoBehaviour
{
    public UIScrollView scrollView;

    [HideInInspector]
    [SerializeField]
    private UIScrollView draggablePanel;

    private Transform mTrans;

    private UIScrollView mScroll;

    private bool mAutoFind;

    private bool mStarted;

    [NonSerialized]
    private bool mPressed;

    private void OnEnable()
    {
        mTrans = transform;
        if (scrollView == null && draggablePanel != null)
        {
            scrollView = draggablePanel;
            draggablePanel = null;
        }
        FindScrollView();
    }

    private void Start()
    {
        mStarted = true;
        FindScrollView();
    }

    private void FindScrollView()
    {
        if (scrollView == null)
        {
            Transform t = mTrans;
            while (t != null && mScroll == null)
            {
                mScroll = t.GetComponent<UIScrollView>();
                t = t.parent;
            }
            scrollView = mScroll;
        }
        else
        {
            mScroll = scrollView;
        }
    }

    private void OnDisable()
    {
        if (mScroll != null && mPressed)
        {
            mScroll.Press(false);
            mPressed = false;
        }
    }

    private void OnPress(bool pressed)
    {
        if (mStarted && enabled && NGUITools.GetActive(gameObject))
        {
            if (scrollView == null && !mAutoFind)
            {
                mAutoFind = true;
                FindScrollView();
            }

            if (scrollView != null)
            {
                mPressed = pressed;
                scrollView.Press(pressed);
                if (!pressed)
                {
                    FindScrollView();
                }
            }
        }
    }

    private void OnDrag(Vector2 delta)
    {
        if (mStarted && enabled && NGUITools.GetActive(gameObject) && scrollView != null)
        {
            scrollView.Drag();
        }
    }

    private void OnScroll(float delta)
    {
        if (mStarted && enabled && NGUITools.GetActive(gameObject) && scrollView != null)
        {
            scrollView.Scroll(delta);
        }
    }

    public void OnPan(Vector2 delta)
    {
        if (mStarted && enabled && NGUITools.GetActive(gameObject) && scrollView != null)
        {
            scrollView.OnPan(delta);
        }
    }
}