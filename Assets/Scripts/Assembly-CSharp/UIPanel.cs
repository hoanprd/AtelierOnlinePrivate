using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
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

    public bool showInPanelTool;

    public bool generateNormals;

    public bool generateUV2;

    public UIDrawCall.ShadowMode shadowMode;

    public bool widgetsAreStatic;

    public bool cullWhileDragging;

    public bool alwaysOnScreen;

    public bool anchorOffset;

    public bool softBorderPadding;

    public RenderQueue renderQueue;

    public int startingRenderQueue;

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
    private UIDrawCall.Clipping mClipping;

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

    private bool mRebuild;

    private bool mResized;

    [SerializeField]
    private Vector2 mClipOffset;

    private int mMatrixFrame = -1;

    private int mAlphaFrameID = -1;

    private int mLayer;

    private static float[] mTemp;

    private Vector2 mMin = new Vector2();

    private Vector2 mMax = new Vector2();

    private bool mSortWidgets;

    private bool mUpdateScroll;

    public bool useSortingOrder;

    private UIPanel mParentPanel;

    private static Vector3[] mCorners = new Vector3[4];

    private static int mUpdateFrame = -1;

    [NonSerialized]
    private bool mHasMoved;

    private UIDrawCall.OnRenderCallback mOnRender;

    private bool mForced;

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
            return 100f;
        }
    }

    public float height
    {
        get
        {
            return 100f;
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
            return Vector4.zero;
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
            return mCorners;
        }
    }

    public override Vector3[] worldCorners
    {
        get
        {
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
    }

    public override Vector3[] GetSides(Transform relativeTo)
    {
        return mCorners;
    }

    public override void Invalidate(bool includeChildren)
    {
        SetDirty();
    }

    public override float CalculateFinalAlpha(int frameID)
    {
        return mAlpha;
    }

    public override void SetRect(float x, float y, float width, float height)
    {
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
        return true;
    }

    public bool Affects(UIWidget w)
    {
        return w != null && w.panel == this;
    }

    public void RebuildAllDrawCalls()
    {
    }

    public void SetDirty()
    {
        mRebuild = true;
    }

    protected override void Awake()
    {
        base.Awake();
    }

    private void FindParent()
    {
    }

    public override void ParentHasChanged()
    {
        base.ParentHasChanged();
        FindParent();
    }

    protected override void OnStart()
    {
        // Chuẩn hóa theo Ghidra dump: UIPanel__OnStart lấy layer của cachedGameObject gán vào mLayer
        if (cachedGameObject != null)
        {
            mLayer = cachedGameObject.layer;
        }
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        list.Add(this);
        list.Sort(CompareFunc);
    }

    protected override void OnInit()
    {
        base.OnInit();
    }

    protected override void OnDisable()
    {
        list.Remove(this);
        base.OnDisable();
    }

    private void UpdateTransformMatrix()
    {
    }

    protected override void OnAnchor()
    {
    }

    private void LateUpdate()
    {
    }

    private void UpdateSelf()
    {
    }

    public void SortWidgets()
    {
    }

    private void FillAllDrawCalls()
    {
    }

    public bool FillDrawCall(UIDrawCall dc)
    {
        return false;
    }

    public bool FillDrawCall(UIDrawCall dc, bool needsCulling)
    {
        return false;
    }

    private void UpdateDrawCalls(int sortOrder)
    {
    }

    private void UpdateLayers()
    {
    }

    private void UpdateWidgets()
    {
    }

    public UIDrawCall FindDrawCall(UIWidget w)
    {
        return null;
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
        return Vector3.zero;
    }

    public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
    {
        return false;
    }

    public bool ConstrainTargetToBounds(Transform target, bool immediate)
    {
        return false;
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