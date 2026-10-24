using System.Collections.Generic;
using UnityEngine;

public class Emoticon : MonoBehaviour
{
    private enum ETweenKind
    {
        eBRINGIN = 1,
        eDISMISS = 2
    }

    [SerializeField]
    private List<GameObject> m_vgoEmoticon = new List<GameObject>();

    private EEmoticon m_eKind = EEmoticon.eNONE;

    private bool m_bAnimEnd = true;

    public bool IsAnimEnd
    {
        get
        {
            return m_bAnimEnd;
        }
    }

    public bool IsDisp
    {
        get
        {
            return gameObject != null && gameObject.activeSelf;
        }
    }

    private void Init()
    {
        if (m_vgoEmoticon == null || m_vgoEmoticon.Count == 0)
        {
            m_vgoEmoticon = new List<GameObject>();
            Transform t = transform;
            for (int i = 0; i < t.childCount; i++)
            {
                m_vgoEmoticon.Add(t.GetChild(i).gameObject);
            }
        }
    }

    public void Play(EEmoticon kind)
    {
        Init();
        gameObject.SetActive(true);

        int index = (int)kind;
        for (int i = 0; i < m_vgoEmoticon.Count; i++)
        {
            if (m_vgoEmoticon[i] != null)
            {
                bool active = (i == index - 1);
                m_vgoEmoticon[i].SetActive(active);
                if (active)
                {
                    PlayAnim(m_vgoEmoticon[i], ETweenKind.eBRINGIN);
                }
            }
        }
        m_eKind = kind;
    }

    private void PlayAnim(GameObject target, ETweenKind tweenKind)
    {
        if (target == null) return;

        UITweenReset tweenReset = target.GetComponentInChildren<UITweenReset>();
        if (tweenReset != null)
        {
            tweenReset.ResetOnFinish();
            if (tweenKind == ETweenKind.eBRINGIN)
            {
                tweenReset.ResetTweenForward();
                EventDelegate ed = new EventDelegate(this, "OnAnimEnd");
                tweenReset.SetOnFinish(ed);
            }
            else
            {
                tweenReset.ResetTweenReverse();
                EventDelegate ed = new EventDelegate(this, "OnAnimEnd");
                tweenReset.SetOnFinish(ed);
            }
            m_bAnimEnd = false;
        }
        else
        {
            m_bAnimEnd = true;
        }
    }

    private void OnAnimEnd()
    {
        m_bAnimEnd = true;
    }
}