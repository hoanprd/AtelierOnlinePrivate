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

    [DoNotObfuscateNGUI]
    public enum Clipping
    {
        None = 0,
        TextureMask = 1,
        SoftClip = 3,
        ConstrainButDontClip = 4
    }

    public delegate void OnGeometryUpdated();
    public delegate void OnClippingMoved(UIPanel panel);
    public delegate Material OnCreateMaterial(UIWidget widget, Material mat);

    public static List<UIPanel> list = new List<UIPanel>();

    public OnGeometryUpdated onGeometryUpdated;
    public bool showInPanelTool = true;
    public bool generateNormals;
    public bool generateUV2;
    public UIDrawCall.ShadowMode shadowMode;
    public bool widgetsAreStatic;
    public bool cullWhileDragging;
    public bool alwaysOnScreen;
    public bool anchorOffset;
    public bool softBorderPadding = true;
    public RenderQueue renderQueue;
    public int startingRenderQueue = 3000;

    [NonSerialized]
    public List<UIWidget> widgets = new List<UIWidget>();

    [NonSerialized]
    public List<UIDrawCall> drawCalls = new List<UIDrawCall>();

    [NonSerialized]
    public Matrix4x4 worldToLocal = Matrix4x4.identity;

    [NonSerialized]
    public Vector4 drawCallClipRange = new Vector4(0f, 0f, 1f, 1f);

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
    private Clipping mClipping;

    [HideInInspector]
    [SerializeField]
    private Vector4 mClipRange = new Vector4(0f, 0f, 300f, 200f);

    [HideInInspector]
    [SerializeField]
    private Vector2 mClipSoftness = new Vector2(4f, 4f);

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
    private Vector2 mClipOffset = Vector2.zero;

    private int mMatrixFrame = -1;
    private int mAlphaFrameID = -1;
    private int mLayer = -1;

    private Vector2 mMin = Vector2.zero;
    private Vector2 mMax = Vector2.zero;

    [NonSerialized]
    public bool isDirty;
    [NonSerialized]
    public bool sortWidgets;

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
        get { return mSortingLayerName; }
        set
        {
            if (mSortingLayerName != value)
            {
                mSortingLayerName = value;
                UpdateDrawCalls(list.IndexOf(this));
            }
        }
    }

    public static int nextUnusedDepth
    {
        get
        {
            int num = int.MinValue;
            for (int i = 0; i < list.Count;)
            {
                if (list[i] == null) { list.RemoveAt(i); continue; }
                if (list[i].mDepth > num)
                {
                    num = list[i].mDepth;
                }
                i++;
            }
            return (num == int.MinValue) ? 0 : (num + 1);
        }
    }

    public override bool canBeAnchored
    {
        get { return mClipping != Clipping.None; }
    }

    public override float alpha
    {
        get { return mAlpha; }
        set
        {
            float clampedValue = Mathf.Clamp01(value);
            if (mAlpha != clampedValue)
            {
                mAlphaFrameID = -1;
                mResized = true;
                mAlpha = clampedValue;
                for (int i = 0; i < drawCalls.Count; i++)
                {
                    drawCalls[i].isDirty = true;
                }
                Invalidate(true);
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
                list.Sort(CompareFunc);
            }
        }
    }

    public int sortingOrder
    {
        get { return mSortingOrder; }
        set
        {
            if (mSortingOrder != value)
            {
                mSortingOrder = value;
                UpdateDrawCalls(list.IndexOf(this));
            }
        }
    }

    public float width
    {
        get { return GetViewSize().x; }
    }

    public float height
    {
        get { return GetViewSize().y; }
    }

    public bool halfPixelOffset
    {
        get { return false; }
    }

    public bool usedForUI
    {
        get { return anchorCamera != null && mCam.orthographic; }
    }

    public Vector3 drawCallOffset
    {
        get { return Vector3.zero; }
    }

    public Clipping clipping
    {
        get { return mClipping; }
        set
        {
            if (mClipping != value)
            {
                mResized = true;
                mClipping = value;
                mMatrixFrame = -1;
            }
        }
    }

    public UIPanel parentPanel
    {
        get { return mParentPanel; }
    }

    public int clipCount
    {
        get
        {
            int num = 0;
            UIPanel p = this;
            while (p != null)
            {
                if (p.mClipping == Clipping.SoftClip || p.mClipping == Clipping.TextureMask)
                {
                    num++;
                }
                p = p.mParentPanel;
            }
            return num;
        }
    }

    public bool hasClipping
    {
        get { return mClipping == Clipping.SoftClip || mClipping == Clipping.TextureMask; }
    }

    public bool hasCumulativeClipping
    {
        get { return clipCount != 0; }
    }

    [Obsolete]
    public bool clipsChildren
    {
        get { return hasCumulativeClipping; }
    }

    public Vector2 clipOffset
    {
        get { return mClipOffset; }
        set
        {
            if (Mathf.Abs(mClipOffset.x - value.x) > 0.001f || Mathf.Abs(mClipOffset.y - value.y) > 0.001f)
            {
                mClipOffset = value;
                InvalidateClipping();
                if (onClipMove != null) onClipMove(this);
            }
        }
    }

    public Texture2D clipTexture
    {
        get { return mClipTexture; }
        set
        {
            if (mClipTexture != value)
            {
                mClipTexture = value;
                mRebuild = true;
            }
        }
    }

    [Obsolete]
    public Vector4 clipRange
    {
        get { return baseClipRegion; }
        set { baseClipRegion = value; }
    }

    public Vector4 baseClipRegion
    {
        get { return mClipRange; }
        set
        {
            if (Mathf.Abs(mClipRange.x - value.x) > 0.001f ||
                Mathf.Abs(mClipRange.y - value.y) > 0.001f ||
                Mathf.Abs(mClipRange.z - value.z) > 0.001f ||
                Mathf.Abs(mClipRange.w - value.w) > 0.001f)
            {
                mResized = true;
                mClipRange = value;
                mMatrixFrame = -1;
                UIScrollView sv = GetComponent<UIScrollView>();
                if (sv != null) sv.UpdatePosition();
                if (onClipMove != null) onClipMove(this);
            }
        }
    }

    public Vector4 finalClipRegion
    {
        get
        {
            Vector2 size = GetViewSize();
            if (mClipping != Clipping.None)
            {
                return new Vector4(mClipRange.x + mClipOffset.x, mClipRange.y + mClipOffset.y, size.x, size.y);
            }
            return new Vector4(0f, 0f, size.x, size.y);
        }
    }

    public Vector2 clipSoftness
    {
        get { return mClipSoftness; }
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
            if (mClipping == Clipping.None)
            {
                Vector3[] corners = worldCorners;
                Transform wt = cachedTransform;
                for (int i = 0; i < 4; i++)
                {
                    corners[i] = wt.InverseTransformPoint(corners[i]);
                }
                return corners;
            }
            float x0 = mClipOffset.x + mClipRange.x - 0.5f * mClipRange.z;
            float y0 = mClipOffset.y + mClipRange.y - 0.5f * mClipRange.w;
            float x1 = x0 + mClipRange.z;
            float y1 = y0 + mClipRange.w;
            mCorners[0] = new Vector3(x0, y0);
            mCorners[1] = new Vector3(x0, y1);
            mCorners[2] = new Vector3(x1, y1);
            mCorners[3] = new Vector3(x1, y0);
            return mCorners;
        }
    }

    public override Vector3[] worldCorners
    {
        get
        {
            if (mClipping != Clipping.None)
            {
                float x0 = mClipOffset.x + mClipRange.x - 0.5f * mClipRange.z;
                float y0 = mClipOffset.y + mClipRange.y - 0.5f * mClipRange.w;
                float x1 = x0 + mClipRange.z;
                float y1 = y0 + mClipRange.w;
                Transform wt = cachedTransform;
                mCorners[0] = wt.TransformPoint(x0, y0, 0f);
                mCorners[1] = wt.TransformPoint(x0, y1, 0f);
                mCorners[2] = wt.TransformPoint(x1, y1, 0f);
                mCorners[3] = wt.TransformPoint(x1, y0, 0f);
            }
            else if (anchorCamera != null)
            {
                return mCam.GetWorldCorners(cameraRayDistance);
            }
            else
            {
                Vector2 size = GetViewSize();
                float x0 = -0.5f * size.x;
                float y0 = -0.5f * size.y;
                float x1 = x0 + size.x;
                float y1 = y0 + size.y;
                mCorners[0] = new Vector3(x0, y0);
                mCorners[1] = new Vector3(x0, y1);
                mCorners[2] = new Vector3(x1, y1);
                mCorners[3] = new Vector3(x1, y0);
                if (anchorOffset && (mCam == null || mCam.transform.parent != cachedTransform))
                {
                    Vector3 pos = cachedTransform.position;
                    for (int i = 0; i < 4; i++)
                    {
                        mCorners[i] += pos;
                    }
                }
            }
            return mCorners;
        }
    }

    public static int CompareFunc(UIPanel a, UIPanel b)
    {
        if (a == b) return 0;
        if (a == null) return -1;
        if (b == null) return 1;
        if (a.mDepth < b.mDepth) return -1;
        if (a.mDepth > b.mDepth) return 1;
        return (a.GetEntityId().CompareTo(b.GetEntityId()));
    }

    private void InvalidateClipping()
    {
        mResized = true;
        mMatrixFrame = -1;
        for (int i = 0; i < list.Count;)
        {
            if (list[i] == null) { list.RemoveAt(i); continue; }
            UIPanel p = list[i];
            if (p != this && p.parentPanel == this)
            {
                p.InvalidateClipping();
            }
            i++;
        }
    }

    public override Vector3[] GetSides(Transform relativeTo)
    {
        if (mClipping != Clipping.None)
        {
            float x0 = mClipOffset.x + mClipRange.x - 0.5f * mClipRange.z;
            float y0 = mClipOffset.y + mClipRange.y - 0.5f * mClipRange.w;
            float x1 = x0 + mClipRange.z;
            float y1 = y0 + mClipRange.w;
            float hx = (x0 + x1) * 0.5f;
            float hy = (y0 + y1) * 0.5f;
            Transform wt = cachedTransform;
            UIRect.mSides[0] = wt.TransformPoint(x0, hy, 0f);
            UIRect.mSides[1] = wt.TransformPoint(hx, y1, 0f);
            UIRect.mSides[2] = wt.TransformPoint(x1, hy, 0f);
            UIRect.mSides[3] = wt.TransformPoint(hx, y0, 0f);
            if (relativeTo != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    UIRect.mSides[i] = relativeTo.InverseTransformPoint(UIRect.mSides[i]);
                }
            }
            return UIRect.mSides;
        }
        if (anchorCamera != null && anchorOffset)
        {
            Vector3[] sides = mCam.GetSides(cameraRayDistance);
            Vector3 off = cachedTransform.position;
            for (int j = 0; j < 4; j++)
            {
                sides[j] += off;
            }
            if (relativeTo != null)
            {
                for (int k = 0; k < 4; k++)
                {
                    sides[k] = relativeTo.InverseTransformPoint(sides[k]);
                }
            }
            return sides;
        }
        return base.GetSides(relativeTo);
    }

    public override void Invalidate(bool includeChildren)
    {
        mAlphaFrameID = -1;
        base.Invalidate(includeChildren);
    }

    public override float CalculateFinalAlpha(int frameID)
    {
        if (mAlphaFrameID != frameID)
        {
            mAlphaFrameID = frameID;
            UIRect pt = parent;
            finalAlpha = ((pt != null) ? (pt.CalculateFinalAlpha(frameID) * mAlpha) : mAlpha);
        }
        return finalAlpha;
    }

    public override void SetRect(float x, float y, float width, float height)
    {
        int finalWidth = Mathf.FloorToInt(width + 0.5f);
        int finalHeight = Mathf.FloorToInt(height + 0.5f);
        finalWidth = (finalWidth >> 1) << 1;
        finalHeight = (finalHeight >> 1) << 1;
        Transform t = cachedTransform;
        Vector3 localPos = t.localPosition;
        localPos.x = Mathf.Floor(x + 0.5f);
        localPos.y = Mathf.Floor(y + 0.5f);
        if (finalWidth < 2) finalWidth = 2;
        if (finalHeight < 2) finalHeight = 2;
        baseClipRegion = new Vector4(localPos.x, localPos.y, finalWidth, finalHeight);
        if (isAnchored)
        {
            t = t.parent;
            if (leftAnchor.target) leftAnchor.SetHorizontal(t, x);
            if (rightAnchor.target) rightAnchor.SetHorizontal(t, x + width);
            if (bottomAnchor.target) bottomAnchor.SetVertical(t, y);
            if (topAnchor.target) topAnchor.SetVertical(t, y + height);
        }
    }

    public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
    {
        UpdateTransformMatrix();
        a = worldToLocal.MultiplyPoint3x4(a);
        b = worldToLocal.MultiplyPoint3x4(b);
        c = worldToLocal.MultiplyPoint3x4(c);
        d = worldToLocal.MultiplyPoint3x4(d);
        float minX = Mathf.Min(Mathf.Min(a.x, b.x), Mathf.Min(c.x, d.x));
        float maxX = Mathf.Max(Mathf.Max(a.x, b.x), Mathf.Max(c.x, d.x));
        float minY = Mathf.Min(Mathf.Min(a.y, b.y), Mathf.Min(c.y, d.y));
        float maxY = Mathf.Max(Mathf.Max(a.y, b.y), Mathf.Max(c.y, d.y));
        if (maxX < mMin.x) return false;
        if (maxY < mMin.y) return false;
        if (minX > mMax.x) return false;
        if (minY > mMax.y) return false;
        return true;
    }

    public bool IsVisible(Vector3 worldPos)
    {
        if (mAlpha < 0.001f) return false;
        if (mClipping == Clipping.None || mClipping == Clipping.ConstrainButDontClip) return true;
        UpdateTransformMatrix();
        Vector3 pos = worldToLocal.MultiplyPoint3x4(worldPos);
        if (pos.x < mMin.x) return false;
        if (pos.y < mMin.y) return false;
        if (pos.x > mMax.x) return false;
        if (pos.y > mMax.y) return false;
        return true;
    }

    public bool IsVisible(UIWidget w)
    {
        UIPanel p = this;
        Vector3[] corners = null;
        while (p != null)
        {
            if ((p.mClipping == Clipping.None || p.mClipping == Clipping.ConstrainButDontClip) && !w.hideIfOffScreen)
            {
                p = p.mParentPanel;
                continue;
            }
            if (corners == null) corners = w.worldCorners;
            if (!p.IsVisible(corners[0], corners[1], corners[2], corners[3])) return false;
            p = p.mParentPanel;
        }
        return true;
    }

    public bool Affects(UIWidget w)
    {
        if (w == null) return false;
        UIPanel expected = w.panel;
        if (expected == null) return false;
        UIPanel p = this;
        while (p != null)
        {
            if (p == expected) return true;
            if (!p.hasCumulativeClipping) return false;
            p = p.mParentPanel;
        }
        return false;
    }

    public void RebuildAllDrawCalls()
    {
        mRebuild = true;
    }

    public void ForceUpdateNow(int sortOrder = 0)
    {
        mRebuild = true;
        UpdateSelf();
        UpdateDrawCalls(sortOrder);
    }

    public void SetDirty()
    {
        isDirty = true;
        mRebuild = true;
        for (int i = 0; i < drawCalls.Count; i++)
        {
            if (drawCalls[i] != null) drawCalls[i].isDirty = true;
        }
    }

    protected override void Awake()
    {
        base.Awake();
    }

    private void FindParent()
    {
        Transform parentTrans = cachedTransform.parent;
        mParentPanel = ((parentTrans != null) ? NGUITools.FindInParents<UIPanel>(parentTrans.gameObject) : null);
    }

    public override void ParentHasChanged()
    {
        base.ParentHasChanged();
        FindParent();
    }

    protected override void OnStart()
    {
        mLayer = cachedGameObject.layer;
    }

    protected override void OnEnable()
    {
        mRebuild = true;
        mAlphaFrameID = -1;
        mMatrixFrame = -1;
        OnStart();
        base.OnEnable();
        mMatrixFrame = -1;
    }

    protected override void OnInit()
    {
        if (list.Contains(this)) return;
        base.OnInit();
        FindParent();
        if (GetComponent<Rigidbody>() == null && mParentPanel == null)
        {
            UICamera uic = (anchorCamera != null) ? mCam.GetComponent<UICamera>() : null;
            if (uic != null && (uic.eventType == UICamera.EventType.UI_3D || uic.eventType == UICamera.EventType.World_3D))
            {
                Rigidbody rb = gameObject.AddComponent<Rigidbody>();
                rb.isKinematic = true;
                rb.useGravity = false;
            }
        }
        mRebuild = true;
        mAlphaFrameID = -1;
        mMatrixFrame = -1;
        list.Add(this);
        list.Sort(CompareFunc);
    }

    protected override void OnDisable()
    {
        for (int i = 0; i < drawCalls.Count; i++)
        {
            UIDrawCall dc = drawCalls[i];
            if (dc != null) UIDrawCall.Destroy(dc);
        }
        drawCalls.Clear();
        list.Remove(this);
        mAlphaFrameID = -1;
        mMatrixFrame = -1;
        if (list.Count == 0)
        {
            UIDrawCall.ReleaseAll();
            mUpdateFrame = -1;
        }
        base.OnDisable();
    }

    protected void OnDestroy()
    {
        list.Remove(this);
    }

    private void UpdateTransformMatrix()
    {
        int fc = Time.frameCount;
        if (mHasMoved || mMatrixFrame != fc)
        {
            mMatrixFrame = fc;
            worldToLocal = cachedTransform.worldToLocalMatrix;
            Vector2 size = GetViewSize() * 0.5f;
            float x = mClipOffset.x + mClipRange.x;
            float y = mClipOffset.y + mClipRange.y;
            mMin.x = x - size.x;
            mMin.y = y - size.y;
            mMax.x = x + size.x;
            mMax.y = y + size.y;
        }
    }

    protected override void OnAnchor()
    {
        if (mClipping == Clipping.None) return;
        Transform trans = cachedTransform;
        Transform parentTrans = trans.parent;
        Vector2 size = GetViewSize();
        Vector2 offset = trans.localPosition;
        float lt, bt, rt, tt;
        if (leftAnchor.target == bottomAnchor.target && leftAnchor.target == rightAnchor.target && leftAnchor.target == topAnchor.target)
        {
            Vector3[] sides = leftAnchor.GetSides(parentTrans);
            if (sides != null)
            {
                lt = NGUIMath.Lerp(sides[0].x, sides[2].x, leftAnchor.relative) + leftAnchor.absolute;
                rt = NGUIMath.Lerp(sides[0].x, sides[2].x, rightAnchor.relative) + rightAnchor.absolute;
                bt = NGUIMath.Lerp(sides[3].y, sides[1].y, bottomAnchor.relative) + bottomAnchor.absolute;
                tt = NGUIMath.Lerp(sides[3].y, sides[1].y, topAnchor.relative) + topAnchor.absolute;
            }
            else
            {
                Vector2 lp = GetLocalPos(leftAnchor, parentTrans);
                lt = lp.x + leftAnchor.absolute;
                bt = lp.y + bottomAnchor.absolute;
                rt = lp.x + rightAnchor.absolute;
                tt = lp.y + topAnchor.absolute;
            }
        }
        else
        {
            if (leftAnchor.target)
            {
                Vector3[] sides = leftAnchor.GetSides(parentTrans);
                lt = (sides != null) ? (NGUIMath.Lerp(sides[0].x, sides[2].x, leftAnchor.relative) + leftAnchor.absolute) : (GetLocalPos(leftAnchor, parentTrans).x + leftAnchor.absolute);
            }
            else lt = mClipRange.x - 0.5f * size.x;

            if (rightAnchor.target)
            {
                Vector3[] sides = rightAnchor.GetSides(parentTrans);
                rt = (sides != null) ? (NGUIMath.Lerp(sides[0].x, sides[2].x, rightAnchor.relative) + rightAnchor.absolute) : (GetLocalPos(rightAnchor, parentTrans).x + rightAnchor.absolute);
            }
            else rt = mClipRange.x + 0.5f * size.x;

            if (bottomAnchor.target)
            {
                Vector3[] sides = bottomAnchor.GetSides(parentTrans);
                bt = (sides != null) ? (NGUIMath.Lerp(sides[3].y, sides[1].y, bottomAnchor.relative) + bottomAnchor.absolute) : (GetLocalPos(bottomAnchor, parentTrans).y + bottomAnchor.absolute);
            }
            else bt = mClipRange.y - 0.5f * size.y;

            if (topAnchor.target)
            {
                Vector3[] sides = topAnchor.GetSides(parentTrans);
                tt = (sides != null) ? (NGUIMath.Lerp(sides[3].y, sides[1].y, topAnchor.relative) + topAnchor.absolute) : (GetLocalPos(topAnchor, parentTrans).y + topAnchor.absolute);
            }
            else tt = mClipRange.y + 0.5f * size.y;
        }
        lt -= offset.x + mClipOffset.x;
        rt -= offset.x + mClipOffset.x;
        bt -= offset.y + mClipOffset.y;
        tt -= offset.y + mClipOffset.y;
        float newX = Mathf.Lerp(lt, rt, 0.5f);
        float newY = Mathf.Lerp(bt, tt, 0.5f);
        float w = rt - lt;
        float h = tt - bt;
        float minx = Mathf.Max(2f, mClipSoftness.x);
        float miny = Mathf.Max(2f, mClipSoftness.y);
        if (w < minx) w = minx;
        if (h < miny) h = miny;
        baseClipRegion = new Vector4(newX, newY, w, h);
    }

    private void LateUpdate()
    {
        if (mUpdateFrame != Time.frameCount || !Application.isPlaying)
        {
            mUpdateFrame = Time.frameCount;
            for (int i = 0; i < list.Count;)
            {
                if (list[i] == null)
                {
                    list.RemoveAt(i);
                    continue;
                }
                list[i].UpdateSelf();
                i++;
            }
            int rq = 3000;
            for (int j = 0; j < list.Count;)
            {
                if (list[j] == null)
                {
                    list.RemoveAt(j);
                    continue;
                }
                UIPanel p = list[j];
                if (p.renderQueue == RenderQueue.Automatic)
                {
                    p.startingRenderQueue = rq;
                    p.UpdateDrawCalls(j);
                    rq += p.drawCalls.Count;
                }
                else if (p.renderQueue == RenderQueue.StartAt)
                {
                    p.UpdateDrawCalls(j);
                    if (p.drawCalls.Count != 0)
                        rq = Mathf.Max(rq, p.startingRenderQueue + p.drawCalls.Count);
                }
                else
                {
                    p.UpdateDrawCalls(j);
                    if (p.drawCalls.Count != 0)
                        rq = Mathf.Max(rq, p.startingRenderQueue + 1);
                }
                j++;
            }
        }
    }

    private void UpdateSelf()
    {
        mHasMoved = cachedTransform.hasChanged;
        UpdateTransformMatrix();
        UpdateLayers();
        UpdateWidgets();
        if (mRebuild || isDirty)
        {
            mRebuild = false;
            isDirty = false;
            FillAllDrawCalls();
        }
        else
        {
            for (int i = 0; i < drawCalls.Count;)
            {
                UIDrawCall dc = drawCalls[i];
                if (dc.isDirty && !FillDrawCall(dc))
                {
                    UIDrawCall.Destroy(dc);
                    drawCalls.RemoveAt(i);
                    continue;
                }
                i++;
            }
        }
        if (mUpdateScroll)
        {
            mUpdateScroll = false;
            UIScrollView sv = GetComponent<UIScrollView>();
            if (sv != null) sv.UpdateScrollbars();
        }
        if (mHasMoved)
        {
            cachedTransform.hasChanged = false;
        }
    }

    public void SortWidgets()
    {
        sortWidgets = false;
        widgets.Sort(UIWidget.PanelCompareFunc);
    }

    private void FillAllDrawCalls()
    {
        for (int i = 0; i < drawCalls.Count; i++)
        {
            UIDrawCall.Destroy(drawCalls[i]);
        }
        drawCalls.Clear();

        Material mat = null;
        Texture tex = null;
        Shader shd = null;
        UIDrawCall dc = null;
        int count = 0;

        if (sortWidgets) SortWidgets();

        for (int j = 0; j < widgets.Count; j++)
        {
            UIWidget w = widgets[j];
            if (w != null && w.isVisible && w.hasVertices)
            {
                Material mt = w.material;
                if (onCreateMaterial != null) mt = onCreateMaterial(w, mt);
                Texture tx = w.mainTexture;
                Shader sd = w.shader;

                if (mat != mt || tex != tx || shd != sd)
                {
                    if (dc != null && dc.verts.Count != 0)
                    {
                        drawCalls.Add(dc);
                        dc.UpdateGeometry(count, true);
                        dc.onRender = mOnRender;
                        mOnRender = null;
                        count = 0;
                        dc = null;
                    }
                    mat = mt;
                    tex = tx;
                    shd = sd;
                }

                if (mat != null || shd != null || tex != null)
                {
                    if (dc == null)
                    {
                        dc = UIDrawCall.Create(this, mat, tex, shd);
                        dc.depthStart = w.depth;
                        dc.depthEnd = dc.depthStart;
                        dc.panel = this;
                        dc.onCreateDrawCall = onCreateDrawCall;
                    }
                    else
                    {
                        int rd = w.depth;
                        if (rd < dc.depthStart) dc.depthStart = rd;
                        if (rd > dc.depthEnd) dc.depthEnd = rd;
                    }
                    w.drawCall = dc;
                    count++;
                    if (generateNormals)
                        w.WriteToBuffers(dc.verts, dc.uvs, dc.cols, dc.norms, dc.tans, generateUV2 ? dc.uv2 : null);
                    else
                        w.WriteToBuffers(dc.verts, dc.uvs, dc.cols, null, null, generateUV2 ? dc.uv2 : null);
                    if (w.mOnRender != null)
                    {
                        if (mOnRender == null) mOnRender = w.mOnRender;
                        else mOnRender += w.mOnRender;
                    }
                }
            }
            else if (w != null)
            {
                w.drawCall = null;
            }
        }

        if (dc != null && dc.verts.Count != 0)
        {
            drawCalls.Add(dc);
            dc.UpdateGeometry(count, true);
            dc.onRender = mOnRender;
            mOnRender = null;
        }
    }

    public bool FillDrawCall(UIDrawCall dc)
    {
        return FillDrawCall(dc, cullWhileDragging);
    }

    public bool FillDrawCall(UIDrawCall dc, bool needsCulling)
    {
        if (dc != null)
        {
            dc.isDirty = false;
            int count = 0;
            for (int i = 0; i < widgets.Count;)
            {
                UIWidget w = widgets[i];
                if (w == null)
                {
                    widgets.RemoveAt(i);
                    continue;
                }
                if (w.drawCall == dc)
                {
                    if (w.isVisible && w.hasVertices)
                    {
                        count++;
                        if (generateNormals)
                            w.WriteToBuffers(dc.verts, dc.uvs, dc.cols, dc.norms, dc.tans, generateUV2 ? dc.uv2 : null);
                        else
                            w.WriteToBuffers(dc.verts, dc.uvs, dc.cols, null, null, generateUV2 ? dc.uv2 : null);
                        if (w.mOnRender != null)
                        {
                            if (mOnRender == null) mOnRender = w.mOnRender;
                            else mOnRender += w.mOnRender;
                        }
                    }
                    else
                    {
                        w.drawCall = null;
                    }
                }
                i++;
            }
            if (dc.verts.Count != 0)
            {
                dc.UpdateGeometry(count, true);
                dc.onRender = mOnRender;
                mOnRender = null;
                return true;
            }
        }
        return false;
    }

    private void UpdateDrawCalls(int sortOrder)
    {
        Transform trans = cachedTransform;
        bool isUI = usedForUI;
        if (clipping != Clipping.None)
        {
            drawCallClipRange = finalClipRegion;
            drawCallClipRange.z *= 0.5f;
            drawCallClipRange.w *= 0.5f;
        }
        else
        {
            drawCallClipRange = Vector4.zero;
        }

        int w = Screen.width;
        int h = Screen.height;
        if (drawCallClipRange.z == 0f) drawCallClipRange.z = (float)w * 0.5f;
        if (drawCallClipRange.w == 0f) drawCallClipRange.w = (float)h * 0.5f;

        if (halfPixelOffset)
        {
            drawCallClipRange.x -= 0.5f;
            drawCallClipRange.y += 0.5f;
        }

        Vector3 pos = isUI ? Vector3.zero : trans.position;
        if (isUI)
        {
            Transform parentTrans = cachedTransform.parent;
            pos = cachedTransform.localPosition;
            if (clipping != Clipping.None)
            {
                pos.x = Mathf.RoundToInt(pos.x);
                pos.y = Mathf.RoundToInt(pos.y);
            }
            if (parentTrans != null) pos = parentTrans.TransformPoint(pos);
            pos += drawCallOffset;
        }

        for (int i = 0; i < drawCalls.Count; i++)
        {
            UIDrawCall dc = drawCalls[i];
            Transform t = dc.cachedTransform;
            if (t.parent != trans)
            {
                t.SetParent(trans, false);
            }
            t.localPosition = Vector3.zero;
            t.localRotation = Quaternion.identity;
            t.localScale = Vector3.one;
            dc.renderQueue = ((renderQueue == RenderQueue.Explicit) ? startingRenderQueue : (startingRenderQueue + i));
            dc.alwaysOnScreen = alwaysOnScreen && (mClipping == Clipping.None || mClipping == Clipping.ConstrainButDontClip);
            dc.sortingOrder = (useSortingOrder ? ((mSortingOrder == 0 && renderQueue == RenderQueue.Automatic) ? sortOrder : mSortingOrder) : 0);
            dc.sortingLayerName = (useSortingOrder ? mSortingLayerName : null);
            dc.clipTexture = mClipTexture;
            dc.shadowMode = shadowMode;
        }
    }

    private void UpdateLayers()
    {
        if (mLayer != cachedGameObject.layer)
        {
            mLayer = cachedGameObject.layer;
            for (int i = 0; i < widgets.Count; i++)
            {
                UIWidget w = widgets[i];
                if (w != null && w.parent == this)
                {
                    w.gameObject.layer = mLayer;
                }
            }
            ResetAnchors();
            for (int j = 0; j < drawCalls.Count; j++)
            {
                drawCalls[j].gameObject.layer = mLayer;
            }
        }
    }

    private void UpdateWidgets()
    {
        bool changed = false;
        bool forceVisible = false;
        bool clipped = hasCumulativeClipping;
        if (!cullWhileDragging)
        {
            for (int i = 0; i < UIScrollView.list.size; i++)
            {
                UIScrollView sv = UIScrollView.list.buffer[i];
                if (sv != null && sv.panel == this && sv.isDragging)
                {
                    forceVisible = true;
                }
            }
        }
        if (mForced != forceVisible)
        {
            mForced = forceVisible;
            mResized = true;
        }

        int frame = Time.frameCount;
        for (int j = 0, jmax = widgets.Count; j < jmax; j++)
        {
            UIWidget w = widgets[j];
            if (w == null || w.panel != this || !w.enabled) continue;
            if (!w.gameObject.activeInHierarchy) continue;

            if (w.UpdateTransform(frame) || mResized || mHasMoved)
            {
                bool vis = forceVisible || (w.CalculateCumulativeAlpha(frame) > 0.001f);
                w.UpdateVisibility(vis, forceVisible || (!clipped && !w.hideIfOffScreen) || IsVisible(w));
            }
            if (w.UpdateGeometry(frame))
            {
                changed = true;
                if (!mRebuild)
                {
                    if (w.drawCall != null)
                        w.drawCall.isDirty = true;
                    else
                        FindDrawCall(w);
                }
            }
        }

        if (changed && onGeometryUpdated != null) onGeometryUpdated();
        mResized = false;
    }

    public UIDrawCall FindDrawCall(UIWidget w)
    {
        Material mat = w.material;
        Texture tex = w.mainTexture;
        Shader shd = w.shader;
        int depth = w.depth;
        for (int i = 0; i < drawCalls.Count; i++)
        {
            UIDrawCall dc = drawCalls[i];
            int dcStart = ((i == 0) ? int.MinValue : (drawCalls[i - 1].depthEnd + 1));
            int dcEnd = ((i + 1 == drawCalls.Count) ? int.MaxValue : (drawCalls[i + 1].depthStart - 1));
            if (dcStart <= depth && dcEnd >= depth)
            {
                if (dc.baseMaterial == mat && dc.shader == shd && dc.mainTexture == tex)
                {
                    if (w.isVisible)
                    {
                        w.drawCall = dc;
                        if (w.hasVertices) dc.isDirty = true;
                        return dc;
                    }
                }
                else
                {
                    mRebuild = true;
                }
                return null;
            }
        }
        mRebuild = true;
        return null;
    }

    public void AddWidget(UIWidget w)
    {
        mUpdateScroll = true;
        if (widgets.Count == 0)
        {
            widgets.Add(w);
        }
        else if (sortWidgets)
        {
            widgets.Add(w);
            SortWidgets();
        }
        else if (UIWidget.PanelCompareFunc(w, widgets[0]) == -1)
        {
            widgets.Insert(0, w);
        }
        else
        {
            int i = widgets.Count;
            while (i > 0)
            {
                if (UIWidget.PanelCompareFunc(w, widgets[--i]) != -1)
                {
                    widgets.Insert(i + 1, w);
                    break;
                }
            }
        }
        FindDrawCall(w);
    }

    public void RemoveWidget(UIWidget w)
    {
        if (widgets.Remove(w) && w.drawCall != null)
        {
            int depth = w.depth;
            if (depth == w.drawCall.depthStart || depth == w.drawCall.depthEnd)
                mRebuild = true;
            w.drawCall.isDirty = true;
            w.drawCall = null;
        }
    }

    public void Refresh()
    {
        mRebuild = true;
        mUpdateFrame = -1;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != null)
            {
                list[i].LateUpdate();
                break;
            }
        }
    }

    public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
    {
        Vector4 cr = finalClipRegion;
        float offsetX = cr.z * 0.5f;
        float offsetY = cr.w * 0.5f;
        Vector2 minRect = new Vector2(min.x, min.y);
        Vector2 maxRect = new Vector2(max.x, max.y);
        Vector2 minArea = new Vector2(cr.x - offsetX, cr.y - offsetY);
        Vector2 maxArea = new Vector2(cr.x + offsetX, cr.y + offsetY);
        if (softBorderPadding && clipping == Clipping.SoftClip)
        {
            minArea.x += mClipSoftness.x;
            minArea.y += mClipSoftness.y;
            maxArea.x -= mClipSoftness.x;
            maxArea.y -= mClipSoftness.y;
        }
        return NGUIMath.ConstrainRect(minRect, maxRect, minArea, maxArea);
    }

    public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
    {
        Vector3 min = targetBounds.min;
        Vector3 max = targetBounds.max;
        float ps = 1f;
        if (mClipping == Clipping.None)
        {
            UIRoot rt = root;
            if (rt != null) ps = rt.pixelSizeAdjustment;
        }
        if (ps != 1f)
        {
            min /= ps;
            max /= ps;
        }
        Vector3 offset = CalculateConstrainOffset(min, max) * ps;
        if (offset.sqrMagnitude > 0f)
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
                target.localPosition += offset;
                targetBounds.center += offset;
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
        UIPanel panel = NGUITools.FindInParents<UIPanel>(trans);
        if (panel != null) return panel;
        while (trans.parent != null) trans = trans.parent;
        return createIfMissing ? NGUITools.CreateUI(trans, false, layer) : null;
    }

    public Vector2 GetWindowSize()
    {
        UIRoot rt = root;
        Vector2 size = NGUITools.screenSize;
        if (rt != null) size *= rt.GetPixelSizeAdjustment(Mathf.RoundToInt(size.y));
        return size;
    }

    public Vector2 GetViewSize()
    {
        if (mClipping != Clipping.None)
            return new Vector2(mClipRange.z, mClipRange.w);
        return NGUITools.screenSize;
    }
}
