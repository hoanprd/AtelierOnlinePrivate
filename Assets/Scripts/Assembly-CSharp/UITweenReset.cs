using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/UI Tween Reset")]
public class UITweenReset : MonoBehaviour
{
    public GameObject m_root;
    public int m_tweenGroup;
    public bool m_inChildren;
    public UITweener[] m_tween;
    public bool m_onActive;
    public List<EventDelegate> m_onFinished = new List<EventDelegate>();

    private EventDelegate m_onFinishedCallback;
    private bool m_forward = true;
    private int m_tweenCount;
    private float m_fWaitTime;
    private float m_fPassedTime;

    public bool IsForward
    {
        get
        {
            return m_forward;
        }
    }

    private EventDelegate FinishCallback
    {
        get
        {
            if (m_onFinishedCallback == null)
            {
                m_onFinishedCallback = new EventDelegate(this, "OnFinish");
            }
            return m_onFinishedCallback;
        }
    }

    public bool IsAnimEnd
    {
        get
        {
            return m_tweenCount < 1;
        }
    }

    private void Update()
    {
        if (m_tweenCount > 0)
        {
            m_fPassedTime += Time.deltaTime;
        }
    }

    public void FindTweener()
    {
        GameObject targetObj = m_root != null ? m_root : gameObject;
        if (m_inChildren)
        {
            m_tween = targetObj.GetComponentsInChildren<UITweener>(true);
        }
        else
        {
            m_tween = targetObj.GetComponents<UITweener>();
        }

        if (m_tween != null && m_tweenGroup != 0)
        {
            List<UITweener> list = new List<UITweener>();
            for (int i = 0; i < m_tween.Length; i++)
            {
                if (m_tween[i].tweenGroup == m_tweenGroup)
                {
                    list.Add(m_tween[i]);
                }
            }
            m_tween = list.ToArray();
        }
    }

    public void SetStart(bool callOnFinish = false)
    {
        if (m_tween == null) FindTweener();
        if (m_tween == null) return;

        for (int i = 0; i < m_tween.Length; i++)
        {
            UITweener tw = m_tween[i];
            if (tw != null && tw.tweenGroup == m_tweenGroup)
            {
                tw.Sample(0f, true);
                tw.enabled = false;
                if (callOnFinish && m_tweenCount > 0)
                {
                    OnFinish();
                }
            }
        }
    }

    public void SetFinish(bool callOnFinish = false)
    {
        if (m_tween == null) FindTweener();
        if (m_tween == null) return;

        for (int i = 0; i < m_tween.Length; i++)
        {
            UITweener tw = m_tween[i];
            if (tw != null && tw.tweenGroup == m_tweenGroup)
            {
                tw.Sample(1f, true);
                tw.enabled = false;
                if (callOnFinish && m_tweenCount > 0)
                {
                    OnFinish();
                }
            }
        }
    }

    public void ResetTween(bool forward = true, bool reset = true)
    {
        m_forward = forward;
        if (m_tween == null) FindTweener();
        if (m_tween == null) return;

        Clear();

        m_tweenCount = 0;
        m_fWaitTime = 0f;
        m_fPassedTime = 0f;

        for (int i = 0; i < m_tween.Length; i++)
        {
            UITweener tw = m_tween[i];
            if (tw != null && tw.tweenGroup == m_tweenGroup)
            {
                if (reset)
                {
                    tw.ResetToBeginning();
                }

                if (tw.duration > m_fWaitTime)
                {
                    m_fWaitTime = tw.duration;
                }

                tw.enabled = true;
                tw.Play(forward);
                tw.AddOnFinished(FinishCallback);
                m_tweenCount++;
            }
        }
    }

    public void Reset()
    {
        m_tweenCount = 0;
        if (m_tween == null) FindTweener();
        if (m_tween == null) return;

        for (int i = 0; i < m_tween.Length; i++)
        {
            UITweener tw = m_tween[i];
            if (tw != null && tw.tweenGroup == m_tweenGroup)
            {
                tw.ResetToBeginning();
                tw.enabled = false;
            }
        }
    }

    public void TweenReverse()
    {
        ResetTween(false, false);
    }

    public void TweenForward()
    {
        ResetTween(true, false);
    }

    public void ResetTweenReverse()
    {
        ResetTween(false, true);
    }

    public void ResetTweenForward()
    {
        ResetTween(true, true);
    }

    public void SetOnFinish(EventDelegate del)
    {
        m_onFinished.Clear();
        if (del != null)
        {
            m_onFinished.Add(del);
        }
    }

    public void AddOnFinish(EventDelegate del)
    {
        if (del != null && !m_onFinished.Contains(del))
        {
            m_onFinished.Add(del);
        }
    }

    public void RemoveOnFinish(EventDelegate del)
    {
        if (del != null)
        {
            m_onFinished.Remove(del);
        }
    }

    public void ResetOnFinish()
    {
        m_onFinished.Clear();
    }

    public void OnEnable()
    {
        if (m_onActive)
        {
            ResetTweenForward();
        }
    }

    public void Clear()
    {
        if (m_tween == null) return;
        EventDelegate cb = FinishCallback;
        for (int i = 0; i < m_tween.Length; i++)
        {
            if (m_tween[i] != null)
            {
                m_tween[i].RemoveOnFinished(cb);
            }
        }
    }

    public float GetPlayPer()
    {
        if (m_fWaitTime <= 0f) return 1f;
        return Mathf.Clamp01(m_fPassedTime / m_fWaitTime);
    }

    private void OnFinish()
    {
        m_tweenCount--;
        if (m_tweenCount <= 0)
        {
            m_tweenCount = 0;
            EventDelegate.Execute(m_onFinished);
        }
    }
}