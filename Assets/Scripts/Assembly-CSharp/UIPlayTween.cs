using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Tween")]
public class UIPlayTween : MonoBehaviour
{
    public static UIPlayTween current;

    public GameObject tweenTarget;

    public int tweenGroup;

    public Trigger trigger;

    public Direction playDirection = Direction.Forward;

    public bool resetOnPlay;

    public bool resetIfDisabled;

    public EnableCondition ifDisabledOnPlay = EnableCondition.DoNothing;

    public DisableCondition disableWhenFinished = DisableCondition.DoNotDisable;

    public bool includeChildren;

    public List<EventDelegate> onFinished = new List<EventDelegate>();

    [HideInInspector]
    [SerializeField]
    private GameObject eventReceiver;

    [HideInInspector]
    [SerializeField]
    private string callWhenFinished;

    private UITweener[] mTweens;

    private bool mStarted;

    private int mActive;

    private bool mActivated;

    private void Awake()
    {
        mStarted = false;
    }

    private void Start()
    {
        mStarted = true;
        if (mActivated)
        {
            Activate(true);
        }
        mActivated = false;
    }

    private void OnEnable()
    {
        mStarted = true;
        if (resetIfDisabled && mTweens != null)
        {
            for (int i = 0, imax = mTweens.Length; i < imax; i++)
            {
                if (mTweens[i] != null)
                {
                    mTweens[i].ResetToBeginning();
                    mTweens[i].enabled = false;
                }
            }
        }
    }

    private void OnDisable()
    {
        if (mActive > 0)
        {
            Disable();
        }
    }

    private void OnHover(bool isOver)
    {
        if (enabled && trigger == Trigger.OnHover)
        {
            Activate(isOver);
        }
    }

    private void OnPress(bool isPressed)
    {
        if (enabled && trigger == Trigger.OnPress)
        {
            Activate(isPressed);
        }
    }

    private void OnClick()
    {
        if (enabled && trigger == Trigger.OnClick)
        {
            Activate(true);
        }
    }

    private void OnDoubleClick()
    {
        if (enabled && trigger == Trigger.OnDoubleClick)
        {
            Activate(true);
        }
    }

    private void OnSelect(bool isSelected)
    {
        if (enabled && trigger == Trigger.OnSelect)
        {
            Activate(isSelected);
        }
    }

    private void Update()
    {
        if (mActive > 0)
        {
            bool isFinished = true;
            for (int i = 0, imax = mTweens.Length; i < imax; i++)
            {
                UITweener tw = mTweens[i];
                if (tw.enabled)
                {
                    isFinished = false;
                    break;
                }
            }

            if (isFinished)
            {
                mActive = 0;
                Disable();
                EventDelegate.Execute(onFinished);
                if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
                {
                    eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.DontRequireReceiver);
                }
                current = null;
            }
        }
    }

    public void Play()
    {
        Play(true);
    }

    public void Play(bool forward)
    {
        Activate(forward);
    }

    public void Activate(bool forward)
    {
        GameObject go = (tweenTarget != null) ? tweenTarget : gameObject;

        if (!go.activeInHierarchy)
        {
            if (ifDisabledOnPlay == EnableCondition.DoNothing) return;
            if (ifDisabledOnPlay == EnableCondition.EnableThenPlay)
            {
                go.SetActive(true);
            }
        }

        if (mStarted)
        {
            if (mTweens == null || mTweens.Length == 0)
            {
                mTweens = includeChildren ? go.GetComponentsInChildren<UITweener>(true) : go.GetComponents<UITweener>();
                if (mTweens.Length == 0) return;
            }

            mActive = 0;
            Direction dir = (playDirection == Direction.Toggle) ? (forward ? Direction.Forward : Direction.Reverse) : playDirection;

            for (int i = 0, imax = mTweens.Length; i < imax; i++)
            {
                UITweener tw = mTweens[i];
                if (tw.tweenGroup == tweenGroup)
                {
                    if (mActive == 0)
                    {
                        current = this;
                    }

                    mActive++;

                    if (resetOnPlay)
                    {
                        tw.ResetToBeginning();
                    }

                    tw.Play(dir == Direction.Forward);
                    tw.AddOnFinished(OnFinished);
                    tw.enabled = true;
                }
            }
        }
        else
        {
            mActivated = true;
        }
    }

    private void OnFinished()
    {
        mActive--;
        if (mActive == 0)
        {
            Disable();
            EventDelegate.Execute(onFinished);
            if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
            {
                eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.DontRequireReceiver);
            }
            current = null;
        }
    }

    private void Disable()
    {
        if (mTweens == null) return;

        if (disableWhenFinished != DisableCondition.DoNotDisable)
        {
            GameObject go = (tweenTarget != null) ? tweenTarget : gameObject;
            if (go != null)
            {
                go.SetActive(false);
            }
        }
    }
}