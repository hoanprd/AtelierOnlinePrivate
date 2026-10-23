using System.Collections.Generic;
using UnityEngine;

public class UIBackgroundManager : SingletonBase<UIBackgroundManager>
{
    private List<UIBackground> m_vBackground = new List<UIBackground>();

    protected override void Awake()
    {
        base.Awake();
        if (m_vBackground == null)
        {
            m_vBackground = new List<UIBackground>();
        }
    }

    public void Add(UIBackground obj)
    {
        if (obj != null && !m_vBackground.Contains(obj))
        {
            m_vBackground.Add(obj);
            Calc();
        }
    }

    public void Remove(UIBackground obj)
    {
        if (obj != null && m_vBackground.Contains(obj))
        {
            m_vBackground.Remove(obj);
            Calc();
        }
    }

    public void Calc()
    {
        if (m_vBackground != null)
        {
            // Sắp xếp danh sách background theo độ sâu (m_iDepth) chuẩn NGUI
            m_vBackground.Sort((a, b) => a.m_iDepth.CompareTo(b.m_iDepth));
        }
    }
}