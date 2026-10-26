using System.Collections.Generic;
using UnityEngine;
using Tutorial;

public class TutorialCommandArrow : TutorialCommandBase
{
    public static List<TutorialArrow> s_scrArrowList = new List<TutorialArrow>();

    private bool m_bEnd;

    private string m_strRootName;

    private float m_fWaitTime;

    public override void Update()
    {
        if (!m_bEnd)
        {
            m_fWaitTime += Time.deltaTime;
            if (m_fWaitTime > 0.2f)
            {
                m_fWaitTime = 0f;
                m_bEnd = MakeArrow(m_strRootName);
            }
        }
    }

    private bool MakeArrow(string strRootName)
    {
        GameObject targetObj = GameObject.Find(strRootName);
        if (targetObj != null)
        {
            Object prefab = Resources.Load("Tutorial/TutorialArrow");
            if (prefab != null)
            {
                GameObject arrowObj = NGUITools.AddChild(targetObj, prefab as GameObject);
                if (arrowObj != null)
                {
                    TutorialArrow arrow = arrowObj.AddComponent<TutorialArrow>();
                    s_scrArrowList.Add(arrow);
                    return true;
                }
            }
        }
        return false;
    }

    public override void Exec(Data clsData)
    {
        m_bEnd = false;
        m_fWaitTime = 0f;

        if (clsData != null && clsData.GetParamBool(0, true))
        {
            m_strRootName = clsData.GetParam(1);
            if (MakeArrow(m_strRootName))
            {
                m_bEnd = true;
            }
            else if (string.IsNullOrEmpty(m_strRootName))
            {
                m_bEnd = true;
            }
        }
        else
        {
            AllArrowDestroy();
            m_bEnd = true;
        }
    }

    public override bool IsEnd()
    {
        return m_bEnd;
    }

 	public static void AllArrowDestroy()
    {
        for (int i = 0; i < s_scrArrowList.Count; i++)
        {
            if (s_scrArrowList[i] != null)
            {
                NGUITools.Destroy(s_scrArrowList[i].gameObject);
            }
        }
        s_scrArrowList.Clear();
    }
}