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
                if (autoResizeBoxCollider) ResizeCollider();
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
            if (mWidth != value && keepAspectRatio != AspectRatioSource.BasedOnHeight)
            {
                if (isAnchoredHorizontally)
                {
                    if (leftAnchor.target != null && rightAnchor.target != null)
                    {
                        if (mPivot == Pivot.BottomLeft || mPivot == Pivot.Left || mPivot == Pivot.TopLeft)
                            NGUIMath.AdjustWidget(this, 0f, 0f, value - mWidth, 0f);
                        else if (mPivot == Pivot.BottomRight || mPivot == Pivot.Right || mPivot == Pivot.TopRight)
                            NGUIMath.AdjustWidget(this, mWidth - value, 0f, 0f, 0f);
                        else
                        {
                            int diff = value - mWidth;
                            diff = diff - (diff & 1);
                            if (diff != 0) NGUIMath.AdjustWidget(this, -diff * 0.5f, 0f, diff * 0.5f, 0f);
                        }
                    }
                    else if (leftAnchor.target != null)
                        NGUIMath.AdjustWidget(this, 0f, 0f, value - mWidth, 0f);
                    else
                        NGUIMath.AdjustWidget(this, mWidth - value, 0f, 0f, 0f);
                }
                else
                {
                    SetDimensions(value, mHeight);
                }
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
            if (mHeight != value && keepAspectRatio != AspectRatioSource.BasedOnWidth)
            {
                if (isAnchoredVertically)
                {
                    if (bottomAnchor.target != null && topAnchor.target != null)
                    {
                        if (mPivot == Pivot.BottomLeft || mPivot == Pivot.Bottom || mPivot == Pivot.BottomRight)
                            NGUIMath.AdjustWidget(this, 0f, 0f, 0f, value - mHeight);
                        else if (mPivot == Pivot.TopLeft || mPivot == Pivot.Top || mPivot == Pivot.TopRight)
                            NGUIMath.AdjustWidget(this, 0f, mHeight - value, 0f, 0f);
                        else
                        {
                            int diff = value - mHeight;
                            diff = diff - (diff & 1);
                            if (diff != 0) NGUIMath.AdjustWidget(this, 0f, -diff * 0.5f, 0f, diff * 0.5f);
                        }
                    }
                    else if (bottomAnchor.target != null)
                        NGUIMath.AdjustWidget(this, 0f, 0f, 0f, value - mHeight);
                    else
                        NGUIMath.AdjustWidget(this, 0f, mHeight - value, 0f, 0f);
                }
                else
                {
                    SetDimensions(mWidth, value);
                }
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
                bool alphaChange = (mColor.a != value.a);
                mColor = value;
                Invalidate(alphaChange);
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
                Invalidate(true);
            }
        }
    }

    public bool isVisible
    {
        get
        {
            return mIsVisibleByPanel && mIsVisibleByAlpha && mIsInFront && finalAlpha > 0.001f && NGUITools.GetActive(this);
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
                if (autoResizeBoxCollider) ResizeCollider();
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
                Vector3 before = worldCorners[0];
                mPivot = value;
                mChanged = true;
                Vector3 after = worldCorners[0];
                Transform t = cachedTransform;
                Vector3 pos = t.position;
                float z = t.localPosition.z;
                pos.x += (before.x - after.x);
                pos.y += (before.y - after.y);
                cachedTransform.position = pos;
                pos = cachedTransform.localPosition;
                pos.x = Mathf.Round(pos.x);
                pos.y = Mathf.Round(pos.y);
                pos.z = z;
                cachedTransform.localPosition = pos;
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
                if (panel != null)
                {
                    panel.RemoveWidget(this);
                    mDepth = value;
                    panel.AddWidget(this);
                    if (!Application.isPlaying)
                    {
                        panel.SortWidgets();
                        panel.RebuildAllDrawCalls();
                    }
                }
                else
                {
                    mDepth = value;
                }
            }
        }
    }

    public int raycastDepth
    {
        get
        {
            if (panel == null) CreatePanel();
            return (panel != null) ? (mDepth + panel.depth * 1000) : mDepth;
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
        get
        {
            Vector3[] cr = localCorners;
            return cr[2] - cr[0];
        }
    }

    public Vector3 localCenter
    {
        get
        {
            Vector3[] cr = localCorners;
            return Vector3.Lerp(cr[0], cr[2], 0.5f);
        }
    }

    public override Vector3[] worldCorners
    {
        get
        {
            Vector2 po = pivotOffset;
            float x0 = -po.x * mWidth;
            float y0 = -po.y * mHeight;
            float x1 = x0 + mWidth;
            float y1 = y0 + mHeight;

            Transform wt = cachedTransform;
            mCorners[0] = wt.TransformPoint(x0, y0, 0f);
            mCorners[1] = wt.TransformPoint(x0, y1, 0f);
            mCorners[2] = wt.TransformPoint(x1, y1, 0f);
            mCorners[3] = wt.TransformPoint(x1, y0, 0f);
            return mCorners;
        }
    }

    public Vector3 worldCenter
    {
        get { return cachedTransform.TransformPoint(localCenter); }
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
                (mDrawRegion.x == 0f) ? x0 : Mathf.Lerp(x0, x1, mDrawRegion.x),
                (mDrawRegion.y == 0f) ? y0 : Mathf.Lerp(y0, y1, mDrawRegion.y),
                (mDrawRegion.z == 1f) ? x1 : Mathf.Lerp(x0, x1, mDrawRegion.z),
                (mDrawRegion.w == 1f) ? y1 : Mathf.Lerp(y0, y1, mDrawRegion.w)
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
                RemoveFromPanel();
                mMat = value;
                MarkAsChanged();
            }
        }
    }

    public virtual Texture mainTexture
    {
        get
        {
            Material mat = material;
            return (mat != null) ? mat.mainTexture : null;
        }
        set
        {
            throw new NotImplementedException(GetType() + " has no mainTexture setter");
        }
    }

    public virtual Shader shader
    {
        get
        {
            Material mat = material;
            return (mat != null) ? mat.shader : null;
        }
        set
        {
            throw new NotImplementedException(GetType() + " has no shader setter");
        }
    }

    [Obsolete]
    public Vector2 relativeSize
    {
        get { return Vector2.one; }
    }

    public bool hasBoxCollider
    {
        get
        {
            BoxCollider box = GetComponent<Collider>() as BoxCollider;
            if (box != null) return true;
            return GetComponent<BoxCollider2D>() != null;
        }
    }

    public virtual int minWidth { get { return 2; } }
    public virtual int minHeight { get { return 2; } }
    public virtual Vector4 border { get { return Vector4.zero; } set { } }

    public void SetColorNoAlpha(Color c)
    {
        if (mColor.r != c.r || mColor.g != c.g || mColor.b != c.b)
        {
            mColor.r = c.r;
            mColor.g = c.g;
            mColor.b = c.b;
            Invalidate(false);
        }
    }

    public void SetDimensions(int w, int h)
    {
        if (mWidth != w || mHeight != h)
        {
            mWidth = w;
            mHeight = h;
            if (keepAspectRatio == AspectRatioSource.BasedOnWidth)
                mHeight = Mathf.RoundToInt(mWidth / aspectRatio);
            else if (keepAspectRatio == AspectRatioSource.BasedOnHeight)
                mWidth = Mathf.RoundToInt(mHeight * aspectRatio);
            else if (keepAspectRatio == AspectRatioSource.Free)
                aspectRatio = mWidth / (float)mHeight;

            mMoved = true;
            if (autoResizeBoxCollider) ResizeCollider();
            MarkAsChanged();
        }
    }

    public override Vector3[] GetSides(Transform relativeTo)
    {
        Vector2 po = pivotOffset;
        float x0 = -po.x * mWidth;
        float y0 = -po.y * mHeight;
        float x1 = x0 + mWidth;
        float y1 = y0 + mHeight;
        float cx = (x0 + x1) * 0.5f;
        float cy = (y0 + y1) * 0.5f;

        Transform trans = cachedTransform;
        mSides[0] = trans.TransformPoint(x0, cy, 0f);
        mSides[1] = trans.TransformPoint(cx, y1, 0f);
        mSides[2] = trans.TransformPoint(x1, cy, 0f);
        mSides[3] = trans.TransformPoint(cx, y0, 0f);

        if (relativeTo != null)
        {
            for (int i = 0; i < 4; ++i)
                mSides[i] = relativeTo.InverseTransformPoint(mSides[i]);
        }
        return mSides;
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
        if (!mIsVisibleByAlpha || !mIsInFront)
        {
            finalAlpha = 0f;
        }
        else
        {
            UIRect pt = parent;
            finalAlpha = (pt != null) ? pt.CalculateFinalAlpha(frameID) * mColor.a : mColor.a;
        }
    }

    public override void Invalidate(bool includeChildren)
    {
        mChanged = true;
        mAlphaFrameID = -1;
        if (panel != null)
        {
            bool vis = (hideIfOffScreen || panel.hasCumulativeClipping) ? panel.IsVisible(this) : true;
            UpdateVisibility(CalculateCumulativeAlpha(Time.frameCount) > 0.001f, vis);
            UpdateFinalAlpha(Time.frameCount);
            if (includeChildren) base.Invalidate(true);
        }
    }

    public float CalculateCumulativeAlpha(int frameID)
    {
        UIRect pt = parent;
        return (pt != null) ? pt.CalculateFinalAlpha(frameID) * mColor.a : mColor.a;
    }

    public override void SetRect(float x, float y, float width, float height)
    {
        Vector2 po = pivotOffset;
        float fx = Mathf.Lerp(x, x + width, po.x);
        float fy = Mathf.Lerp(y, y + height, po.y);

        int finalWidth = Mathf.FloorToInt(width + 0.5f);
        int finalHeight = Mathf.FloorToInt(height + 0.5f);

        if (po.x == 0.5f) finalWidth = ((finalWidth >> 1) << 1);
        if (po.y == 0.5f) finalHeight = ((finalHeight >> 1) << 1);

        Transform t = cachedTransform;
        Vector3 localPos = t.localPosition;
        localPos.x = Mathf.Floor(fx + 0.5f);
        localPos.y = Mathf.Floor(fy + 0.5f);

        if (finalWidth < minWidth) finalWidth = minWidth;
        if (finalHeight < minHeight) finalHeight = minHeight;

        t.localPosition = localPos;
        this.width = finalWidth;
        this.height = finalHeight;

        if (isAnchored)
        {
            t = t.parent;
            if (leftAnchor.target) leftAnchor.SetHorizontal(t, x);
            if (rightAnchor.target) rightAnchor.SetHorizontal(t, x + width);
            if (bottomAnchor.target) bottomAnchor.SetVertical(t, y);
            if (topAnchor.target) topAnchor.SetVertical(t, y + height);
        }
    }

    public void ResizeCollider()
    {
        if (NGUITools.GetActive(this))
            NGUITools.UpdateWidgetCollider(gameObject);
    }

    [System.Diagnostics.DebuggerHidden]
    [System.Diagnostics.DebuggerStepThrough]
    public static int FullCompareFunc(UIWidget left, UIWidget right)
    {
        int val = UIPanel.CompareFunc(left.panel, right.panel);
        return (val == 0) ? PanelCompareFunc(left, right) : val;
    }

    [System.Diagnostics.DebuggerHidden]
    [System.Diagnostics.DebuggerStepThrough]
    public static int PanelCompareFunc(UIWidget left, UIWidget right)
    {
        if (left.mDepth < right.mDepth) return -1;
        if (left.mDepth > right.mDepth) return 1;

        Material leftMat = left.material;
        Material rightMat = right.material;

        if (leftMat == rightMat) return 0;
        if (leftMat != null) return -1;
        if (rightMat != null) return 1;

        return 0;
    }

    public Bounds CalculateBounds()
    {
        return CalculateBounds(null);
    }

    public Bounds CalculateBounds(Transform relativeParent)
    {
        if (relativeParent == null)
        {
            Vector3[] corners = localCorners;
            Bounds b = new Bounds(corners[0], Vector3.zero);
            for (int j = 1; j < 4; ++j) b.Encapsulate(corners[j]);
            return b;
        }
        else
        {
            Matrix4x4 toLocal = relativeParent.worldToLocalMatrix;
            Vector3[] corners = worldCorners;
            Bounds b = new Bounds(toLocal.MultiplyPoint3x4(corners[0]), Vector3.zero);
            for (int j = 1; j < 4; ++j) b.Encapsulate(toLocal.MultiplyPoint3x4(corners[j]));
            return b;
        }
    }

    public void SetDirty()
    {
        if (drawCall != null)
        {
            drawCall.isDirty = true;
        }
        else if (isVisible && hasVertices)
        {
            CreatePanel();
        }
    }

    public void RemoveFromPanel()
    {
        if (panel != null)
        {
            panel.RemoveWidget(this);
            panel = null;
        }
        drawCall = null;
    }

    public virtual void MarkAsChanged()
    {
        if (NGUITools.GetActive(this))
        {
            mChanged = true;
            if (panel != null && enabled && NGUITools.GetActive(gameObject) && !mPlayMode)
            {
                SetDirty();
                CheckLayer();
            }
        }
    }

    public UIPanel CreatePanel()
    {
        if (mStarted && panel == null && enabled && NGUITools.GetActive(gameObject))
        {
            panel = UIPanel.Find(cachedTransform, true, cachedGameObject.layer);
            if (panel != null)
            {
                mParentFound = false;
                panel.AddWidget(this);
                CheckLayer();
                Invalidate(true);
            }
        }
        return panel;
    }

    public void CheckLayer()
    {
        if (panel != null && panel.gameObject.layer != gameObject.layer)
        {
            gameObject.layer = panel.gameObject.layer;
        }
    }

    public override void ParentHasChanged()
    {
        base.ParentHasChanged();
        if (panel != null)
        {
            UIPanel p = UIPanel.Find(cachedTransform, true, cachedGameObject.layer);
            if (panel != p)
            {
                RemoveFromPanel();
                CreatePanel();
            }
        }
    }

    protected override void Awake()
    {
        base.Awake();
        mPlayMode = Application.isPlaying;
    }

    protected override void OnInit()
    {
        base.OnInit();
        RemoveFromPanel();
        mMoved = true;
        if (mWidth == 100 && mHeight == 100 && cachedTransform.localScale.magnitude > 8f)
        {
            UpgradeFrom265();
            cachedTransform.localScale = Vector3.one;
        }
        Update();
    }

    protected virtual void UpgradeFrom265()
    {
        Vector3 scale = cachedTransform.localScale;
        mWidth = Mathf.Abs(Mathf.RoundToInt(scale.x));
        mHeight = Mathf.Abs(Mathf.RoundToInt(scale.y));
        NGUITools.UpdateWidgetCollider(gameObject, true);
    }

    protected override void OnStart()
    {
        CreatePanel();
    }

    protected override void OnAnchor()
    {
        float lt, bt, rt, tt;
        Transform trans = cachedTransform;
        Transform parentTrans = trans.parent;
        Vector3 pos = trans.localPosition;
        Vector2 pvt = pivotOffset;

        if (leftAnchor.target == bottomAnchor.target &&
            leftAnchor.target == rightAnchor.target &&
            leftAnchor.target == topAnchor.target)
        {
            Vector3[] sides = leftAnchor.GetSides(parentTrans);
            if (sides != null)
            {
                lt = NGUIMath.Lerp(sides[0].x, sides[2].x, leftAnchor.relative) + leftAnchor.absolute;
                rt = NGUIMath.Lerp(sides[0].x, sides[2].x, rightAnchor.relative) + rightAnchor.absolute;
                bt = NGUIMath.Lerp(sides[3].y, sides[1].y, bottomAnchor.relative) + bottomAnchor.absolute;
                tt = NGUIMath.Lerp(sides[3].y, sides[1].y, topAnchor.relative) + topAnchor.absolute;
                mIsInFront = true;
            }
            else
            {
                Vector3 lp = GetLocalPos(leftAnchor, parentTrans);
                lt = lp.x + leftAnchor.absolute;
                bt = lp.y + bottomAnchor.absolute;
                rt = lp.x + rightAnchor.absolute;
                tt = lp.y + topAnchor.absolute;
                mIsInFront = (!hideIfOffScreen || lp.z >= 0f);
            }
        }
        else
        {
            mIsInFront = true;
            if (leftAnchor.target)
            {
                Vector3[] sides = leftAnchor.GetSides(parentTrans);
                lt = (sides != null) ? NGUIMath.Lerp(sides[0].x, sides[2].x, leftAnchor.relative) + leftAnchor.absolute : GetLocalPos(leftAnchor, parentTrans).x + leftAnchor.absolute;
            }
            else lt = pos.x - pvt.x * mWidth;

            if (rightAnchor.target)
            {
                Vector3[] sides = rightAnchor.GetSides(parentTrans);
                rt = (sides != null) ? NGUIMath.Lerp(sides[0].x, sides[2].x, rightAnchor.relative) + rightAnchor.absolute : GetLocalPos(rightAnchor, parentTrans).x + rightAnchor.absolute;
            }
            else rt = pos.x - pvt.x * mWidth + mWidth;

            if (bottomAnchor.target)
            {
                Vector3[] sides = bottomAnchor.GetSides(parentTrans);
                bt = (sides != null) ? NGUIMath.Lerp(sides[3].y, sides[1].y, bottomAnchor.relative) + bottomAnchor.absolute : GetLocalPos(bottomAnchor, parentTrans).y + bottomAnchor.absolute;
            }
            else bt = pos.y - pvt.y * mHeight;

            if (topAnchor.target)
            {
                Vector3[] sides = topAnchor.GetSides(parentTrans);
                tt = (sides != null) ? NGUIMath.Lerp(sides[3].y, sides[1].y, topAnchor.relative) + topAnchor.absolute : GetLocalPos(topAnchor, parentTrans).y + topAnchor.absolute;
            }
            else tt = pos.y - pvt.y * mHeight + mHeight;
        }

        Vector3 newPos = new Vector3(Mathf.Lerp(lt, rt, pvt.x), Mathf.Lerp(bt, tt, pvt.y), pos.z);
        newPos.x = Mathf.Floor(newPos.x + 0.5f);
        newPos.y = Mathf.Floor(newPos.y + 0.5f);

        int w = Mathf.FloorToInt(rt - lt + 0.5f);
        int h = Mathf.FloorToInt(tt - bt + 0.5f);

        if (keepAspectRatio != AspectRatioSource.Free && aspectRatio != 0f)
        {
            if (keepAspectRatio == AspectRatioSource.BasedOnHeight)
            {
                w = Mathf.RoundToInt(h * aspectRatio);
            }
            else h = Mathf.RoundToInt(w / aspectRatio);
        }

        if (w < minWidth) w = minWidth;
        if (h < minHeight) h = minHeight;

        if (Vector3.SqrMagnitude(pos - newPos) > 0.001f)
        {
            cachedTransform.localPosition = newPos;
            if (mIsInFront) mChanged = true;
        }

        if (mWidth != w || mHeight != h)
        {
            mWidth = w;
            mHeight = h;
            if (mIsInFront) mChanged = true;
            if (autoResizeBoxCollider) ResizeCollider();
        }
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
        if (mIsVisibleByAlpha != visibleByAlpha || mIsVisibleByPanel != visibleByPanel)
        {
            mChanged = true;
            mIsVisibleByAlpha = visibleByAlpha;
            mIsVisibleByPanel = visibleByPanel;
            return true;
        }
        return false;
    }

    public bool UpdateTransform(int frame)
    {
        Transform trans = cachedTransform;
        mPlayMode = Application.isPlaying;

        if (mMoved)
        {
            mMoved = true;
            mMatrixFrame = -1;
            trans.hasChanged = false;
            Vector2 po = pivotOffset;

            float x0 = -po.x * mWidth;
            float y0 = -po.y * mHeight;
            float x1 = x0 + mWidth;
            float y1 = y0 + mHeight;

            mOldV0 = panel.worldToLocal.MultiplyPoint3x4(trans.TransformPoint(x0, y0, 0f));
            mOldV1 = panel.worldToLocal.MultiplyPoint3x4(trans.TransformPoint(x1, y1, 0f));
        }
        else if (!panel.widgetsAreStatic && trans.hasChanged)
        {
            mMatrixFrame = -1;
            trans.hasChanged = false;
            Vector2 po = pivotOffset;

            float x0 = -po.x * mWidth;
            float y0 = -po.y * mHeight;
            float x1 = x0 + mWidth;
            float y1 = y0 + mHeight;

            Vector3 v0 = panel.worldToLocal.MultiplyPoint3x4(trans.TransformPoint(x0, y0, 0f));
            Vector3 v1 = panel.worldToLocal.MultiplyPoint3x4(trans.TransformPoint(x1, y1, 0f));

            if (Vector3.SqrMagnitude(mOldV0 - v0) > 0.000001f ||
                Vector3.SqrMagnitude(mOldV1 - v1) > 0.000001f)
            {
                mMoved = true;
                mOldV0 = v0;
                mOldV1 = v1;
            }
        }

        if (mMoved && onChange != null) onChange();
        return mMoved || mChanged;
    }

    public bool UpdateGeometry(int frame)
    {
        float fa = CalculateFinalAlpha(frame);
        if (mIsVisibleByAlpha && mLastAlpha != fa) mChanged = true;
        mLastAlpha = fa;

        if (mChanged)
        {
            mChanged = false;
            if (mIsVisibleByAlpha && fa > 0.001f && shader != null)
            {
                bool hadVertices = geometry.hasVertices;
                if (fillGeometry)
                {
                    geometry.Clear();
                    OnFill(geometry.verts, geometry.uvs, geometry.cols);
                }

                if (geometry.hasVertices)
                {
                    if (mMatrixFrame != frame)
                    {
                        mLocalToPanel = panel.worldToLocal * cachedTransform.localToWorldMatrix;
                        mMatrixFrame = frame;
                    }
                    geometry.ApplyTransform(mLocalToPanel, panel.generateNormals);
                    mMoved = false;
                    return true;
                }
                return hadVertices;
            }
            else if (geometry.hasVertices)
            {
                if (fillGeometry) geometry.Clear();
                mMoved = false;
                return true;
            }
        }
        else if (mMoved && geometry.hasVertices)
        {
            if (mMatrixFrame != frame)
            {
                mLocalToPanel = panel.worldToLocal * cachedTransform.localToWorldMatrix;
                mMatrixFrame = frame;
            }
            geometry.ApplyTransform(mLocalToPanel, panel.generateNormals);
            mMoved = false;
            return true;
        }
        mMoved = false;
        return false;
    }

    public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
    {
        geometry.WriteToBuffers(v, u, c, n, t, u2);
    }

    public virtual void MakePixelPerfect()
    {
        Vector3 pos = cachedTransform.localPosition;
        pos.z = Mathf.Round(pos.z);
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        cachedTransform.localPosition = pos;

        Vector3 ls = cachedTransform.localScale;
        cachedTransform.localScale = new Vector3(Mathf.Sign(ls.x), Mathf.Sign(ls.y), 1f);
    }

    public virtual void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }
}
