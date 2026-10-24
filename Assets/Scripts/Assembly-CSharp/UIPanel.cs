using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Panel")]
public class UIPanel : UIRect
{
    [DoNotObfuscateNGUI]
    public enum RenderQueue
    {
        Automatic = 0,
        StartAt = 1,
        Explicit = 2
    }

    public delegate void OnGeometryUpdated();

    public delegate void OnClippingMoved(UIPanel panel);

    public delegate Material OnCreateMaterial(UIWidget widget, Material mat);

    public static List<UIPanel> list = new List<UIPanel>();

    public OnGeometryUpdated onGeometryUpdated;

    public bool showInPanelTool = true;

    public bool generateNormals = false;

    public bool generateUV2 = false;

    public UIDrawCall.ShadowMode shadowMode = UIDrawCall.ShadowMode.None;

    public bool widgetsAreStatic = false;

    public bool cullWhileDragging = false;

    public bool alwaysOnScreen = false;

    public bool anchorOffset = false;

    public bool softBorderPadding = true;

    public RenderQueue renderQueue = RenderQueue.Automatic;

    public int startingRenderQueue = 3000;

    [NonSerialized]
    public List<UIWidget> widgets = new List<UIWidget>();

    [NonSerialized]
    public List<UIDrawCall> drawCalls = new List<UIDrawCall>();

    [NonSerialized]
    public Matrix4x4 worldToLocal;

    [NonSerialized]
    public Vector4 drawCallClipRange;

    public OnClippingMoved onClipMove;

    public OnCreateMaterial onCreateMaterial;

    public UIDrawCall.OnCreateDrawCall onCreateDrawCall;

    [HideInInspector]
    [SerializeField]
    private Texture2D mClipTexture;

    [HideInInspector]
    [SerializeField]
    private float mAlpha = 1f;

    [HideInInspector]
    [SerializeField]
    private UIDrawCall.Clipping mClipping = UIDrawCall.Clipping.None;

    [HideInInspector]
    [SerializeField]
    private Vector4 mClipRange;

    [HideInInspector]
    [SerializeField]
    private Vector2 mClipSoftness = new Vector2(40f, 40f);

    [HideInInspector]
    [SerializeField]
    private int mDepth;

    [HideInInspector]
    [SerializeField]
    private int mSortingOrder;

    [HideInInspector]
    [SerializeField]
    private string mSortingLayerName;

    private bool mRebuild = true;

    private bool mResized = false;

    [SerializeField]
    private Vector2 mClipOffset;

    private int mMatrixFrame = -1;

    private int mAlphaFrameID = -1;

    private int mLayer;

    private static float[] mTemp = new float[4];

    private Vector2 mMin = new Vector2();

    private Vector2 mMax = new Vector2();

    private bool mSortWidgets = true;

    private bool mUpdateScroll;

    public bool useSortingOrder;

    private UIPanel mParentPanel;

    private static Vector3[] mCorners = new Vector3[4];

    private static int mUpdateFrame = -1;

    [NonSerialized]
    private bool mHasMoved;

    private UIDrawCall.OnRenderCallback mOnRender;

    private bool mForced;

    private float mFinalAlpha = 1f;

    public string sortingLayerName
    {
        get
        {
            return mSortingLayerName;
        }
        set
        {
            if (mSortingLayerName != value)
            {
                mSortingLayerName = value;
                SetDirty();
            }
        }
    }

    public static int nextUnusedDepth
    {
        get
        {
            int num = int.MinValue;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].mDepth > num)
                {
                    num = list[i].mDepth;
                }
            }
            return (num == int.MinValue) ? 0 : (num + 1);
        }
    }

    public override bool canBeAnchored
    {
        get
        {
            return false;
        }
    }

    public override float alpha
    {
        get
        {
            return mAlpha;
        }
        set
        {
            float clampedValue = Mathf.Clamp01(value);
            if (mAlpha != clampedValue)
            {
                mAlpha = clampedValue;
                SetDirty();
            }
        }
    }

    public int depth
    {
        get
        {
            return mDepth;
        }
        set
        {
            if (mDepth != value)
            {
                mDepth = value;
                list.Sort(CompareFunc);
            }
        }
    }

    public int sortingOrder
    {
        get
        {
            return mSortingOrder;
        }
        set
        {
            if (mSortingOrder != value)
            {
                mSortingOrder = value;
                SetDirty();
            }
        }
    }

    public float width
    {
        get
        {
            Vector3[] corners = worldCorners;
            return Vector3.Distance(corners[0], corners[3]);
        }
    }

    public float height
    {
        get
        {
            Vector3[] corners = worldCorners;
            return Vector3.Distance(corners[0], corners[1]);
        }
    }

    public bool halfPixelOffset
    {
        get
        {
            return false;
        }
    }

    public bool usedForUI
    {
        get
        {
            return true;
        }
    }

    public Vector3 drawCallOffset
    {
        get
        {
            return Vector3.zero;
        }
    }

    public UIDrawCall.Clipping clipping
    {
        get
        {
            return mClipping;
        }
        set
        {
            if (mClipping != value)
            {
                mClipping = value;
                InvalidateClipping();
            }
        }
    }

    public UIPanel parentPanel
    {
        get
        {
            return mParentPanel;
        }
    }

    public int clipCount
    {
        get
        {
            int num = 0;
            UIPanel uIPanel = this;
            while (uIPanel != null)
            {
                if (uIPanel.mClipping != UIDrawCall.Clipping.None)
                {
                    num++;
                }
                uIPanel = uIPanel.mParentPanel;
            }
            return num;
        }
    }

    public bool hasClipping
    {
        get
        {
            return mClipping != UIDrawCall.Clipping.None;
        }
    }

    public bool hasCumulativeClipping
    {
        get
        {
            return mParentPanel != null && mParentPanel.hasCumulativeClipping || mClipping != UIDrawCall.Clipping.None;
        }
    }

    [Obsolete]
    public bool clipsChildren
    {
        get
        {
            return hasClipping;
        }
    }

    public Vector2 clipOffset
    {
        get
        {
            return mClipOffset;
        }
        set
        {
            if (mClipOffset != value)
            {
                mClipOffset = value;
                InvalidateClipping();
            }
        }
    }

    public Texture2D clipTexture
    {
        get
        {
            return mClipTexture;
        }
        set
        {
            if (mClipTexture != value)
            {
                mClipTexture = value;
            }
        }
    }

    [Obsolete]
    public Vector4 clipRange
    {
        get
        {
            return baseClipRegion;
        }
        set
        {
            baseClipRegion = value;
        }
    }

    public Vector4 baseClipRegion
    {
        get
        {
            return mClipRange;
        }
        set
        {
            if (mClipRange != value)
            {
                mClipRange = value;
                InvalidateClipping();
            }
        }
    }

    public Vector4 finalClipRegion
    {
        get
        {
            if (mClipping == UIDrawCall.Clipping.None) return Vector4.zero;
            return new Vector4(mClipRange.x + mClipOffset.x, mClipRange.y + mClipOffset.y, mClipRange.z, mClipRange.w);
        }
    }

    public Vector2 clipSoftness
    {
        get
        {
            return mClipSoftness;
        }
        set
        {
            if (mClipSoftness != value)
            {
                mClipSoftness = value;
            }
        }
    }

    public override Vector3[] localCorners
    {
        get
        {
            float x0 = 0f, y0 = 0f, x1 = 0f, y1 = 0f;
            if (mClipping != UIDrawCall.Clipping.None)
            {
                x0 = mClipRange.x - 0.5f * mClipRange.z;
                y0 = mClipRange.y - 0.5f * mClipRange.w;
                x1 = x0 + mClipRange.z;
                y1 = y0 + mClipRange.w;
            }
            else
            {
                Vector2 sz = GetWindowSize();
                x0 = -0.5f * sz.x;
                y0 = -0.5f * sz.y;
                x1 = x0 + sz.x;
                y1 = y0 + sz.y;
            }

            mCorners[0] = new Vector3(x0, y0, 0f);
            mCorners[1] = new Vector3(x0, y1, 0f);
            mCorners[2] = new Vector3(x1, y1, 0f);
            mCorners[3] = new Vector3(x1, y0, 0f);
            return mCorners;
        }
    }

    public override Vector3[] worldCorners
    {
        get
        {
            float x0 = 0f, y0 = 0f, x1 = 0f, y1 = 0f;
            if (mClipping != UIDrawCall.Clipping.None)
            {
                x0 = mClipRange.x - 0.5f * mClipRange.z;
                y0 = mClipRange.y - 0.5f * mClipRange.w;
                x1 = x0 + mClipRange.z;
                y1 = y0 + mClipRange.w;
            }
            else
            {
                Vector2 sz = GetWindowSize();
                x0 = -0.5f * sz.x;
                y0 = -0.5f * sz.y;
                x1 = x0 + sz.x;
                y1 = y0 + sz.y;
            }

            Transform t = cachedTransform;
            mCorners[0] = t.TransformPoint(x0, y0, 0f);
            mCorners[1] = t.TransformPoint(x0, y1, 0f);
            mCorners[2] = t.TransformPoint(x1, y1, 0f);
            mCorners[3] = t.TransformPoint(x1, y0, 0f);
            return mCorners;
        }
    }

    public static int CompareFunc(UIPanel a, UIPanel b)
    {
        if (a.mDepth < b.mDepth) return -1;
        if (a.mDepth > b.mDepth) return 1;
        return 0;
    }

    private void InvalidateClipping()
    {
        mResized = true;
        SetDirty();
    }

    public override Vector3[] GetSides(Transform relativeTo)
    {
        Vector3[] corners = worldCorners;
        if (relativeTo != null)
        {
            for (int i = 0; i < 4; i++) corners[i] = relativeTo.InverseTransformPoint(corners[i]);
        }
        return corners;
    }

    public override void Invalidate(bool includeChildren)
    {
        SetDirty();
        base.Invalidate(includeChildren);
    }

    public override float CalculateFinalAlpha(int frameID)
    {
        if (mAlphaFrameID != frameID)
        {
            mAlphaFrameID = frameID;
            mFinalAlpha = (mParentPanel != null) ? (mParentPanel.CalculateFinalAlpha(frameID) * mAlpha) : mAlpha;
        }
        return mFinalAlpha;
    }

    public override void SetRect(float x, float y, float width, float height)
    {
        if (mClipping != UIDrawCall.Clipping.None)
        {
            Vector4 cr = mClipRange;
            cr.x = x;
            cr.y = y;
            cr.z = width;
            cr.w = height;
            baseClipRegion = cr;
        }
    }

    public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
    {
        return true;
    }

    public bool IsVisible(Vector3 worldPos)
    {
        return true;
    }

    public bool IsVisible(UIWidget w)
    {
        if (!w.enabled || mAlpha < 0.001f) return false;
        return true;
    }

    public bool Affects(UIWidget w)
    {
        return w != null && w.panel == this;
    }

    public void RebuildAllDrawCalls()
    {
        mRebuild = true;
    }

    public void SetDirty()
    {
        mRebuild = true;
    }

    protected override void Awake()
    {
        base.Awake();
        mLayer = gameObject.layer;
    }

    private void FindParent()
    {
        Transform p = cachedTransform.parent;
        mParentPanel = null;
        while (p != null)
        {
            UIPanel panel = p.GetComponent<UIPanel>();
            if (panel != null)
            {
                mParentPanel = panel;
                break;
            }
            p = p.parent;
        }
    }

    public override void ParentHasChanged()
    {
        base.ParentHasChanged();
        FindParent();
    }

    protected override void OnStart()
    {
        if (cachedGameObject != null)
        {
            mLayer = cachedGameObject.layer;
        }
        FindParent();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        list.Add(this);
        list.Sort(CompareFunc);
        mRebuild = true;
    }

    protected override void OnInit()
    {
        base.OnInit();
        FindParent();
    }

    protected override void OnDisable()
    {
        list.Remove(this);
        mParentPanel = null;
        base.OnDisable();
    }

    private void UpdateTransformMatrix()
    {
        int frame = Time.frameCount;
        if (mMatrixFrame != frame)
        {
            mMatrixFrame = frame;
            worldToLocal = cachedTransform.worldToLocalMatrix;
        }
    }

    protected override void OnAnchor()
    {
    }

    private void LateUpdate()
    {
        if (mRebuild)
        {
            mRebuild = false;
            UpdateSelf();
        }
    }

    private void UpdateSelf()
    {
        UpdateTransformMatrix();
        UpdateWidgets();
        FillAllDrawCalls();
    }

    public void SortWidgets()
    {
        widgets.Sort(UIWidget.PanelCompareFunc);
    }

    private void FillAllDrawCalls()
    {
        for (int i = 0; i < drawCalls.Count; i++)
        {
            UIDrawCall.Destroy(drawCalls[i]);
        }
        drawCalls.Clear();

        if (widgets.Count > 0)
        {
            SortWidgets();
            UIDrawCall dc = UIDrawCall.Create(this, null, null, null);
            if (dc != null)
            {
                drawCalls.Add(dc);
            }
        }
    }

    public bool FillDrawCall(UIDrawCall dc)
    {
        return FillDrawCall(dc, false);
    }

    public bool FillDrawCall(UIDrawCall dc, bool needsCulling)
    {
        return true;
    }

    private void UpdateDrawCalls(int sortOrder)
    {
    }

    private void UpdateLayers()
    {
        if (cachedGameObject.layer != mLayer)
        {
            mLayer = cachedGameObject.layer;
            for (int i = 0; i < widgets.Count; i++) widgets[i].gameObject.layer = mLayer;
        }
    }

    private void UpdateWidgets()
    {
        for (int i = widgets.Count; i > 0;)
        {
            UIWidget w = widgets[--i];
            if (w == null || !w.enabled || !w.gameObject.activeInHierarchy)
            {
                widgets.RemoveAt(i);
            }
        }
    }

    public UIDrawCall FindDrawCall(UIWidget w)
    {
        return drawCalls.Count > 0 ? drawCalls[0] : null;
    }

    public void AddWidget(UIWidget w)
    {
        if (w != null && !widgets.Contains(w))
        {
            widgets.Add(w);
            SetDirty();
        }
    }

    public void RemoveWidget(UIWidget w)
    {
        if (w != null && widgets.Remove(w))
        {
            SetDirty();
        }
    }

    public void Refresh()
    {
        SetDirty();
    }

    public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
    {
        if (mClipping == UIDrawCall.Clipping.None) return Vector3.zero;

        Vector4 cr = finalClipRegion;
        float x0 = cr.x - 0.5f * cr.z;
        float x1 = cr.x + 0.5f * cr.z;
        float y0 = cr.y - 0.5f * cr.w;
        float y1 = cr.y + 0.5f * cr.w;

        Vector3 offset = Vector3.zero;

        if (min.x < x0 && max.x > x1) return Vector3.zero;
        if (min.x < x0) offset.x += x0 - min.x;
        else if (max.x > x1) offset.x += x1 - max.x;

        if (min.y < y0 && max.y > y1) return Vector3.zero;
        if (min.y < y0) offset.y += y0 - min.y;
        else if (max.y > y1) offset.y += y1 - max.y;

        return offset;
    }

    public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
    {
        Transform t = cachedTransform;
        Vector3 min = t.InverseTransformPoint(targetBounds.min);
        Vector3 max = t.InverseTransformPoint(targetBounds.max);
        Vector3 offset = CalculateConstrainOffset(min, max);

        if (offset.sqrMagnitude > 0.001f)
        {
            if (immediate)
            {
                target.localPosition += offset;
                targetBounds.center += offset;
                SpringPosition sp = target.GetComponent<SpringPosition>();
                if (sp != null) sp.enabled = false;
            }
            else
            {
                SpringPosition.Begin(target.gameObject, target.localPosition + offset, 13f);
            }
            return true;
        }
        return false;
    }

    public bool ConstrainTargetToBounds(Transform target, bool immediate)
    {
        Bounds b = NGUIMath.CalculateRelativeWidgetBounds(cachedTransform, target);
        return ConstrainTargetToBounds(target, ref b, immediate);
    }

    public static UIPanel Find(Transform trans)
    {
        return Find(trans, false, -1);
    }

    public static UIPanel Find(Transform trans, bool createIfMissing)
    {
        return Find(trans, createIfMissing, -1);
    }

    public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
    {
        if (trans == null) return null;
        UIPanel panel = trans.GetComponent<UIPanel>();
        if (panel != null && panel.enabled) return panel;

        Transform parent = trans.parent;
        while (parent != null)
        {
            panel = parent.GetComponent<UIPanel>();
            if (panel != null && panel.enabled) return panel;
            parent = parent.parent;
        }
        return null;
    }

    public Vector2 GetWindowSize()
    {
        return new Vector2(Screen.width, Screen.height);
    }

    public Vector2 GetViewSize()
    {
        return GetWindowSize();
    }
}