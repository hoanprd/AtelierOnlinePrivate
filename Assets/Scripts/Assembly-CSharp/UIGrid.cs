using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : UIWidgetContainer
{
    public delegate void OnReposition();

    [DoNotObfuscateNGUI]
    public enum Arrangement
    {
        Horizontal = 0,
        Vertical = 1,
        CellSnap = 2
    }

    [DoNotObfuscateNGUI]
    public enum Sorting
    {
        None = 0,
        Alphabetic = 1,
        Horizontal = 2,
        Vertical = 3,
        Custom = 4
    }

    public Arrangement arrangement = Arrangement.Horizontal;

    public Sorting sorting = Sorting.None;

    public UIWidget.Pivot pivot = UIWidget.Pivot.TopLeft;

    public int maxPerLine = 0;

    public float cellWidth = 200f;

    public float cellHeight = 200f;

    public bool animateSmoothly = false;

    public bool hideInactive = true;

    public bool keepWithinPanel = false;

    public OnReposition onReposition;

    public Comparison<Transform> onCustomSort;

    [HideInInspector]
    [SerializeField]
    private bool sorted = false;

    protected bool mReposition = true;

    protected UIPanel mPanel;

    protected bool mInitDone = false;

    public bool repositionNow
    {
        set
        {
            if (value)
            {
                mReposition = true;
                enabled = true;
            }
        }
    }

    public List<Transform> GetChildList()
    {
        Transform t = transform;
        List<Transform> list = new List<Transform>();

        for (int i = 0; i < t.childCount; i++)
        {
            Transform child = t.GetChild(i);
            if (!hideInactive || (child.gameObject && NGUITools.GetActive(child.gameObject)))
            {
                list.Add(child);
            }
        }

        Sort(list);
        return list;
    }

    public Transform GetChild(int index)
    {
        List<Transform> list = GetChildList();
        return (index < list.Count) ? list[index] : null;
    }

    public int GetIndex(Transform trans)
    {
        List<Transform> list = GetChildList();
        return list.IndexOf(trans);
    }

    [Obsolete("Use Transform.SetParent instead")]
    public void AddChild(Transform trans)
    {
        if (trans != null)
        {
            trans.SetParent(transform, false);
            mReposition = true;
        }
    }

    [Obsolete("Use Transform.SetParent instead")]
    public void AddChild(Transform trans, bool sort)
    {
        if (trans != null)
        {
            trans.SetParent(transform, false);
            mReposition = true;
        }
    }

    public bool RemoveChild(Transform t)
    {
        if (t != null && t.parent == transform)
        {
            t.SetParent(null, false);
            mReposition = true;
            return true;
        }
        return false;
    }

    protected virtual void Init()
    {
        mInitDone = true;
        mPanel = UIPanel.Find(transform, false, 0);
    }

    protected virtual void Start()
    {
        Init();
        Reposition();
        enabled = false;
    }

    protected virtual void Update()
    {
        if (mReposition)
        {
            Reposition();
        }
        enabled = false;
    }

    private void OnValidate()
    {
        mReposition = true;
    }

    public static int SortByName(Transform a, Transform b)
    {
        return string.Compare(a.name, b.name);
    }

    public static int SortHorizontal(Transform a, Transform b)
    {
        return a.localPosition.x.CompareTo(b.localPosition.x);
    }

    public static int SortVertical(Transform a, Transform b)
    {
        return b.localPosition.y.CompareTo(a.localPosition.y);
    }

    protected virtual void Sort(List<Transform> list)
    {
        if (sorting == Sorting.Alphabetic)
        {
            list.Sort(SortByName);
        }
        else if (sorting == Sorting.Horizontal)
        {
            list.Sort(SortHorizontal);
        }
        else if (sorting == Sorting.Vertical)
        {
            list.Sort(SortVertical);
        }
        else if (sorting == Sorting.Custom && onCustomSort != null)
        {
            list.Sort(onCustomSort);
        }
    }

    public virtual void Reposition()
    {
        if (!mInitDone)
        {
            Init();
        }

        List<Transform> list = GetChildList();
        ResetPosition(list);

        if (onReposition != null)
        {
            onReposition();
        }

        mReposition = false;
    }

    public void ConstrainWithinPanel()
    {
        if (mPanel != null)
        {
            mPanel.ConstrainTargetToBounds(transform, true);
        }
    }

    protected virtual void ResetPosition(List<Transform> list)
    {
        int x = 0;
        int y = 0;

        int columns = (maxPerLine > 0) ? maxPerLine : (arrangement == Arrangement.Horizontal ? int.MaxValue : 1);
        int rows = (maxPerLine > 0) ? maxPerLine : (arrangement == Arrangement.Vertical ? int.MaxValue : 1);

        int index = 0;
        for (int i = 0, imax = list.Count; i < imax; i++)
        {
            Transform t = list[i];
            Vector3 pos = t.localPosition;
            float depth = pos.z;

            if (arrangement == Arrangement.Horizontal)
            {
                x = index / rows;
                y = index % rows;
            }
            else
            {
                x = index % columns;
                y = index / columns;
            }

            Vector3 targetPos = new Vector3(x * cellWidth, -y * cellHeight, depth);

            if (animateSmoothly && Application.isPlaying)
            {
                SpringPosition.Begin(t.gameObject, targetPos, 15f);
            }
            else
            {
                t.localPosition = targetPos;
            }

            index++;
        }

        if (keepWithinPanel && mPanel != null)
        {
            mPanel.ConstrainTargetToBounds(transform, true);
        }
    }
}