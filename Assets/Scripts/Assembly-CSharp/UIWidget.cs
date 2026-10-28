using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIWidget : UIRect
{
    [DoNotObfuscateNGUI]
    public enum Pivot
    {
        TopLeft = 0,
        Top = 1,
        TopRight = 2,
        Left = 3,
        Center = 4,
        Right = 5,
        BottomLeft = 6,
        Bottom = 7,
        BottomRight = 8
    }

    public delegate void OnDimensionsChanged();

    public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols);

    [DoNotObfuscateNGUI]
    public enum AspectRatioSource
    {
        Free = 0,
        BasedOnWidth = 1,
        BasedOnHeight = 2
    }

    public delegate bool HitCheck(Vector3 worldPos);

    [HideInInspector]
    [SerializeField]
    protected Color mColor = Color.white;

    [HideInInspector]
    [SerializeField]
    protected Pivot mPivot = Pivot.Center;

    [HideInInspector]
    [SerializeField]
    protected int mWidth = 100;

    [HideInInspector]
    [SerializeField]
    protected int mHeight = 100;

    [HideInInspector]
    [SerializeField]
    protected int mDepth = 0;

    [HideInInspector]
    [SerializeField]
    protected Material mMat;

    public OnDimensionsChanged onChange;

    public OnPostFillCallback onPostFill;

    public UIDrawCall.OnRenderCallback mOnRender;

    public bool autoResizeBoxCollider = false;

    public bool hideIfOffScreen = false;

    public AspectRatioSource keepAspectRatio = AspectRatioSource.Free;

    public float aspectRatio = 1f;

    public HitCheck hitCheck;

    [NonSerialized]
    public UIPanel panel;

    [NonSerialized]
    public UIGeometry geometry = new UIGeometry();

    [NonSerialized]
    public bool fillGeometry = true;

    [NonSerialized]
    protected bool mPlayMode = false;

    [NonSerialized]
    protected Vector4 mDrawRegion = new Vector4(0f, 0f, 1f, 1f);

    [NonSerialized]
    private Matrix4x4 mLocalToPanel;

    [NonSerialized]
    private bool mIsVisibleByAlpha = true;

    [NonSerialized]
    private bool mIsVisibleByPanel = true;

    [NonSerialized]
    private bool mIsInFront = true;

    [NonSerialized]
    private float mLastAlpha = 1f;

    [NonSerialized]
    private bool mMoved = false;

    [NonSerialized]
    public UIDrawCall drawCall;

    [NonSerialized]
    protected Vector3[] mCorners = new Vector3[4];

    [NonSerialized]
    private int mAlphaFrameID = -1;

    private int mMatrixFrame = -1;

    private Vector3 mOldV0;

    private Vector3 mOldV1;

    public UIDrawCall.OnRenderCallback onRender
    {
        get { return mOnRender; }
        set { mOnRender = value; }
    }

    public Vector4 drawRegion
    {
        get { return mDrawRegion; }
        set
        {
            if (mDrawRegion != value)
            {
                mDrawRegion = value;
                MarkAsChanged();
            }
        }
    }

    public Vector2 pivotOffset
    {
        get
        {
            float x = 0f, y = 0f;
            switch (mPivot)
            {
                case Pivot.TopLeft:
                case Pivot.Left:
                case Pivot.BottomLeft:
                    x = 0f; break;
                case Pivot.Top:
                case Pivot.Center:
                case Pivot.Bottom:
                    x = 0.5f; break;
                case Pivot.TopRight:
                case Pivot.Right:
                case Pivot.BottomRight:
                    x = 1f; break;
            }
            switch (mPivot)
            {
                case Pivot.TopLeft:
                case Pivot.Top:
                case Pivot.TopRight:
                    y = 1f; break;
                case Pivot.Left:
                case Pivot.Center:
                case Pivot.Right:
                    y = 0.5f; break;
                case Pivot.BottomLeft:
                case Pivot.Bottom:
                case Pivot.BottomRight:
                    y = 0f; break;
            }
            return new Vector2(x, y);
        }
    }

    public int width
    {
        get { return mWidth; }
        set
        {
            int min = minWidth;
            if (value < min) value = min;
            if (mWidth != value)
            {
                if (keepAspectRatio == AspectRatioSource.BasedOnHeight)
                {
                    mWidth = value;
                    mHeight = Mathf.RoundToInt(value / aspectRatio);
                }
                else
                {
                    mWidth = value;
                    if (keepAspectRatio == AspectRatioSource.BasedOnWidth)
                        mHeight = Mathf.RoundToInt(value / aspectRatio);
                }
                SetDirty();
                MarkAsChanged();
                if (onChange != null) onChange();
            }
        }
    }

    public int height
    {
        get { return mHeight; }
        set
        {
            int min = minHeight;
            if (value < min) value = min;
            if (mHeight != value)
            {
                if (keepAspectRatio == AspectRatioSource.BasedOnWidth)
                {
                    mHeight = value;
                    mWidth = Mathf.RoundToInt(value * aspectRatio);
                }
                else
                {
                    mHeight = value;
                    if (keepAspectRatio == AspectRatioSource.BasedOnHeight)
                        mWidth = Mathf.RoundToInt(value * aspectRatio);
                }
                SetDirty();
                MarkAsChanged();
                if (onChange != null) onChange();
            }
        }
    }

    public Color color
    {
        get { return mColor; }
        set
        {
            if (mColor != value)
            {
                mColor = value;
                MarkAsChanged();
            }
        }
    }

    public override float alpha
    {
        get { return mColor.a; }
        set
        {
            if (mColor.a != value)
            {
                mColor.a = value;
                MarkAsChanged();
            }
        }
    }

    public bool isVisible
    {
        get
        {
            return mIsVisibleByAlpha && mIsVisibleByPanel && mIsInFront && cachedGameObject.activeInHierarchy;
        }
    }

    public bool hasVertices
    {
        get { return geometry != null && geometry.hasVertices; }
    }

    public Pivot rawPivot
    {
        get { return mPivot; }
        set
        {
            if (mPivot != value)
            {
                mPivot = value;
                MarkAsChanged();
            }
        }
    }

    public Pivot pivot
    {
        get { return mPivot; }
        set
        {
            if (mPivot != value)
            {
                mPivot = value;
                MarkAsChanged();
            }
        }
    }

    public int depth
    {
        get { return mDepth; }
        set
        {
            if (mDepth != value)
            {
                mDepth = value;
                if (panel != null) panel.sortWidgets = true;
            }
        }
    }

    public int raycastDepth
    {
        get
        {
            if (panel != null) return mDepth + panel.depth * 1000;
            return mDepth;
        }
    }

    public override Vector3[] localCorners
    {
        get
        {
            Vector2 po = pivotOffset;
            float x0 = -po.x * mWidth;
            float y0 = -po.y * mHeight;
            float x1 = x0 + mWidth;
            float y1 = y0 + mHeight;

            mCorners[0] = new Vector3(x0, y0, 0f);
            mCorners[1] = new Vector3(x0, y1, 0f);
            mCorners[2] = new Vector3(x1, y1, 0f);
            mCorners[3] = new Vector3(x1, y0, 0f);
            return mCorners;
        }
    }

    public virtual Vector2 localSize
    {
        get { return new Vector2(mWidth, mHeight); }
    }

    public Vector3 localCenter
    {
        get
        {
            Vector2 po = pivotOffset;
            float x0 = -po.x * mWidth;
            float y0 = -po.y * mHeight;
            return new Vector3(x0 + mWidth * 0.5f, y0 + mHeight * 0.5f, 0f);
        }
    }

    public override Vector3[] worldCorners
    {
        get
        {
            Vector3[] corners = localCorners;
            Transform t = cachedTransform;
            for (int i = 0; i < 4; ++i)
            {
                mCorners[i] = t.TransformPoint(corners[i]);
            }
            return mCorners;
        }
    }

    public Vector3 worldCenter
    {
        get
        {
            Transform t = cachedTransform;
            Vector3 center = localCenter;
            return t.TransformPoint(center);
        }
    }

    public virtual Vector4 drawingDimensions
    {
        get
        {
            Vector2 po = pivotOffset;
            float x0 = -po.x * mWidth;
            float y0 = -po.y * mHeight;
            float x1 = x0 + mWidth;
            float y1 = y0 + mHeight;

            return new Vector4(
                x0 * mDrawRegion.x + x1 * mDrawRegion.z,
                y0 * mDrawRegion.y + y1 * mDrawRegion.w,
                x0 * (1f - mDrawRegion.x) + x1 * mDrawRegion.z,
                y0 * (1f - mDrawRegion.y) + y1 * mDrawRegion.w
            );
        }
    }

    public virtual Material material
    {
        get { return mMat; }
        set
        {
            if (mMat != value)
            {
                mMat = value;
                MarkAsChanged();
            }
        }
    }

    public virtual Texture mainTexture
    {
        get { return null; }
        set { }
    }

    public virtual Shader shader
    {
        get
        {
            Material mat = material;
            return (mat != null) ? mat.shader : null;
        }
        set { }
    }

    [Obsolete]
    public Vector2 relativeSize
    {
        get { return new Vector2(mWidth, mHeight); }
    }

    public bool hasBoxCollider
    {
        get
        {
            BoxCollider bc = GetComponent<BoxCollider>();
            return bc != null;
        }
    }

    public virtual int minWidth
    {
        get { return 2; }
    }

    public virtual int minHeight
    {
        get { return 2; }
    }

    public virtual Vector4 border
    {
        get { return Vector4.zero; }
        set { }
    }

    public void SetColorNoAlpha(Color c)
    {
        mColor.r = c.r;
        mColor.g = c.g;
        mColor.b = c.b;
        MarkAsChanged();
    }

    public void SetDimensions(int w, int h)
    {
        if (mWidth != w || mHeight != h)
        {
            mWidth = w;
            mHeight = h;
            SetDirty();
            MarkAsChanged();
            if (onChange != null) onChange();
        }
    }

    public override Vector3[] GetSides(Transform relativeTo)
    {
        Vector3[] corners = worldCorners;
        if (relativeTo != null)
        {
            for (int i = 0; i < 4; ++i)
            {
                corners[i] = relativeTo.InverseTransformPoint(corners[i]);
            }
        }
        return corners;
    }

    public override float CalculateFinalAlpha(int frameID)
    {
        if (mAlphaFrameID != frameID)
        {
            mAlphaFrameID = frameID;
            UpdateFinalAlpha(frameID);
        }
        return finalAlpha;
    }

    protected void UpdateFinalAlpha(int frameID)
    {
        if (parent != null)
            finalAlpha = parent.CalculateFinalAlpha(frameID) * mColor.a;
        else
            finalAlpha = mColor.a;
    }

    public override void Invalidate(bool includeChildren)
    {
        mAlphaFrameID = -1;
        base.Invalidate(includeChildren);
    }

    public float CalculateCumulativeAlpha(int frameID)
    {
        return CalculateFinalAlpha(frameID);
    }

    public override void SetRect(float x, float y, float width, float height)
    {
        Vector2 po = pivotOffset;
        float targetWidth = width;
        float targetHeight = height;

        Vector3 localPos = cachedTransform.localPosition;
        localPos.x = x + po.x * targetWidth;
        localPos.y = y + po.y * targetHeight;
        cachedTransform.localPosition = localPos;

        SetDimensions(Mathf.RoundToInt(targetWidth), Mathf.RoundToInt(targetHeight));
    }

    public void ResizeCollider()
    {
        NGUITools.UpdateWidgetCollider(this);
    }

    [System.Diagnostics.DebuggerHidden]
    [System.Diagnostics.DebuggerStepThrough]
    public static int FullCompareFunc(UIWidget left, UIWidget right)
    {
        if (left.mDepth != right.mDepth)
            return left.mDepth.CompareTo(right.mDepth);
        return left.GetEntityId().CompareTo(right.GetEntityId());
    }

    [System.Diagnostics.DebuggerHidden]
    [System.Diagnostics.DebuggerStepThrough]
    public static int PanelCompareFunc(UIWidget left, UIWidget right)
    {
        if (left.panel.depth != right.panel.depth)
            return left.panel.depth.CompareTo(right.panel.depth);
        if (left.mDepth != right.mDepth)
            return left.mDepth.CompareTo(right.mDepth);
        return left.GetEntityId().CompareTo(right.GetEntityId());
    }

    public Bounds CalculateBounds()
    {
        return CalculateBounds(cachedTransform);
    }

    public Bounds CalculateBounds(Transform relativeParent)
    {
        Vector3[] corners = worldCorners;
        Bounds b = new Bounds(relativeParent.InverseTransformPoint(corners[0]), Vector3.zero);
        for (int i = 1; i < 4; ++i)
        {
            b.Encapsulate(relativeParent.InverseTransformPoint(corners[i]));
        }
        return b;
    }

    public void SetDirty()
    {
        if (panel != null)
        {
            panel.isDirty = true;
        }
    }

    public void RemoveFromPanel()
    {
        if (panel != null)
        {
            panel.widgets.Remove(this);
            panel = null;
        }
    }

    public virtual void MarkAsChanged()
    {
        if (enabled && NGUITools.GetActive(gameObject))
        {
            SetDirty();
            if (geometry != null) geometry.Clear();
        }
    }

    public UIPanel CreatePanel()
    {
        if (panel == null && enabled && NGUITools.GetActive(gameObject))
        {
            panel = UIPanel.Find(cachedTransform, true, cachedGameObject.layer);
            if (panel != null)
            {
                panel.widgets.Add(this);
                panel.sortWidgets = true;
                panel.isDirty = true;
            }
        }
        return panel;
    }

    public void CheckLayer()
    {
        if (panel != null && panel.gameObject.layer != cachedGameObject.layer)
        {
            UnityEngine.Debug.LogWarning("You can't place a widget on a layer different from its parent panel's", this);
            cachedGameObject.layer = panel.gameObject.layer;
        }
    }

    public override void ParentHasChanged()
    {
        base.ParentHasChanged();
        panel = null;
    }

    protected override void Awake()
    {
        mPlayMode = Application.isPlaying;
        base.Awake();
    }

    protected override void OnInit()
    {
        base.OnInit();
        CreatePanel();
    }

    protected virtual void UpgradeFrom265() { }

    protected override void OnStart() { }

    protected override void OnAnchor()
    {
        // Đã loại bỏ gọi base.OnAnchor() do UIRect.OnAnchor là abstract
    }

    protected override void OnUpdate()
    {
        if (panel == null) CreatePanel();
    }

    private void OnApplicationPause(bool paused)
    {
        if (!paused) MarkAsChanged();
    }

    protected override void OnDisable()
    {
        RemoveFromPanel();
        base.OnDisable();
    }

    private void OnDestroy()
    {
        RemoveFromPanel();
    }

    public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
    {
        mIsVisibleByAlpha = visibleByAlpha;
        mIsVisibleByPanel = visibleByPanel;
        return isVisible;
    }

    public bool UpdateTransform(int frame)
    {
        bool moved = cachedTransform.hasChanged;
        if (mMatrixFrame != frame)
        {
            mMatrixFrame = frame;
            if (panel != null)
            {
                mLocalToPanel = panel.worldToLocal * cachedTransform.localToWorldMatrix;
            }
        }
        return moved;
    }

    public bool UpdateGeometry(int frame)
    {
        if (panel == null) CreatePanel();
        if (geometry != null && (geometry.hasVertices == false || isVisible && panel.isDirty))
        {
            geometry.Clear();
            if (isVisible && mColor.a > 0.001f)
            {
                OnFill(geometry.verts, geometry.uvs, geometry.cols);
                if (onPostFill != null)
                    onPostFill(this, 0, geometry.verts, geometry.uvs, geometry.cols);
                if (geometry.hasVertices)
                {
                    geometry.ApplyTransform(mLocalToPanel, panel.generateNormals);
                    return true;
                }
            }
        }
        return false;
    }

    public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
    {
        if (geometry != null)
        {
            geometry.WriteToBuffers(v, u, c, n, t, u2);
        }
    }

    public virtual void MakePixelPerfect()
    {
        Vector3 pos = cachedTransform.localPosition;
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        cachedTransform.localPosition = pos;
    }

    public virtual void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }
}