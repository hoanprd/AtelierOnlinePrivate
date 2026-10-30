using System;
using UnityEngine;

[ExecuteInEditMode]
public abstract class UIRect : MonoBehaviour
{
    [Serializable]
    public class AnchorPoint
    {
        public Transform target;

        public float relative;

        public int absolute;

        [NonSerialized]
        public UIRect rect;

        [NonSerialized]
        public Camera targetCam;

        public AnchorPoint()
        {
        }

        public AnchorPoint(float relative)
        {
            this.relative = relative;
        }

        public void Set(float relative, float absolute)
        {
            this.relative = relative;
            this.absolute = Mathf.RoundToInt(absolute);
        }

        public void Set(Transform target, float relative, float absolute)
        {
            this.target = target;
            this.relative = relative;
            this.absolute = Mathf.RoundToInt(absolute);
        }

        public void SetToNearest(float abs0, float abs1, float abs2)
        {
            SetToNearest(0f, 0.5f, 1f, abs0, abs1, abs2);
        }

        public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
        {
            if (target == null) return;
            Transform t = target.parent;
            if (t == null) return;

            Camera cam = NGUITools.FindCameraForLayer(t.gameObject.layer);
            if (cam != null)
            {
                Vector3[] corners = cam.GetWorldCorners(t);
                float d0 = Mathf.Abs(abs0 - corners[0].x);
                float d1 = Mathf.Abs(abs1 - corners[3].x);
                float d2 = Mathf.Abs(abs2 - corners[2].x);

                if (d0 < d1 && d0 < d2)
                {
                    relative = rel0;
                    absolute = Mathf.RoundToInt(abs0 - corners[0].x);
                }
                else if (d2 < d0 && d2 < d1)
                {
                    relative = rel2;
                    absolute = Mathf.RoundToInt(abs2 - corners[2].x);
                }
                else
                {
                    relative = rel1;
                    absolute = Mathf.RoundToInt(abs1 - (corners[0].x + corners[2].x) * 0.5f);
                }
            }
        }

        public void SetHorizontal(Transform parent, float localPos)
        {
            if (target == null)
            {
                absolute = Mathf.RoundToInt(localPos);
                relative = 0.5f;
                return;
            }

            Camera cam = NGUITools.FindCameraForLayer(target.gameObject.layer);
            if (cam != null)
            {
                Vector3[] corners = cam.GetWorldCorners(target);
                float x = (corners[0].x + corners[2].x) * 0.5f;
                Vector3 p = parent.InverseTransformPoint(x, 0f, 0f);
                absolute = Mathf.RoundToInt(localPos - p.x);
                relative = 0.5f;
            }
        }

        public void SetVertical(Transform parent, float localPos)
        {
            if (target == null)
            {
                absolute = Mathf.RoundToInt(localPos);
                relative = 0.5f;
                return;
            }

            Camera cam = NGUITools.FindCameraForLayer(target.gameObject.layer);
            if (cam != null)
            {
                Vector3[] corners = cam.GetWorldCorners(target);
                float y = (corners[0].y + corners[2].y) * 0.5f;
                Vector3 p = parent.InverseTransformPoint(0f, y, 0f);
                absolute = Mathf.RoundToInt(localPos - p.y);
                relative = 0.5f;
            }
        }

        public Vector3[] GetSides(Transform relativeTo)
        {
            if (target != null)
            {
                if (rect != null)
                {
                    return rect.GetSides(relativeTo);
                }
                Camera cam = NGUITools.FindCameraForLayer(target.gameObject.layer);
                if (cam != null)
                {
                    return cam.GetWorldCorners(target);
                }
            }
            return null;
        }
    }

    [DoNotObfuscateNGUI]
    public enum AnchorUpdate
    {
        OnEnable = 0,
        OnUpdate = 1,
        OnStart = 2
    }

    public AnchorPoint leftAnchor = new AnchorPoint();
    public AnchorPoint rightAnchor = new AnchorPoint(1f);
    public AnchorPoint bottomAnchor = new AnchorPoint();
    public AnchorPoint topAnchor = new AnchorPoint(1f);

    public AnchorUpdate updateAnchors = AnchorUpdate.OnUpdate;

    [NonSerialized]
    protected GameObject mGo;

    [NonSerialized]
    protected Transform mTrans;

    [NonSerialized]
    protected BetterList<UIRect> mChildren = new BetterList<UIRect>();

    [NonSerialized]
    protected bool mChanged = true;

    [NonSerialized]
    protected bool mParentFound;

    [NonSerialized]
    private bool mUpdateAnchors = true;

    [NonSerialized]
    private int mUpdateFrame = -1;

    [NonSerialized]
    private bool mAnchorsCached;

    [NonSerialized]
    private UIRoot mRoot;

    [NonSerialized]
    private UIRect mParent;

    [NonSerialized]
    private bool mRootSet;

    [NonSerialized]
    protected Camera mCam;

    protected bool mStarted;

    [NonSerialized]
    public float finalAlpha = 1f;

    protected static Vector3[] mSides = new Vector3[4];

    public GameObject cachedGameObject
    {
        get
        {
            if (mGo == null) mGo = gameObject;
            return mGo;
        }
    }

    public Transform cachedTransform
    {
        get
        {
            if (mTrans == null) mTrans = transform;
            return mTrans;
        }
    }

    public Camera anchorCamera
    {
        get
        {
            if (!mAnchorsCached) CacheAnchors();
            return mCam;
        }
    }

    public bool isFullyAnchored
    {
        get
        {
            return leftAnchor.target != null && rightAnchor.target != null && bottomAnchor.target != null && topAnchor.target != null;
        }
    }

    public virtual bool isAnchoredHorizontally
    {
        get
        {
            return leftAnchor.target != null || rightAnchor.target != null;
        }
    }

    public virtual bool isAnchoredVertically
    {
        get
        {
            return bottomAnchor.target != null || topAnchor.target != null;
        }
    }

    public virtual bool canBeAnchored
    {
        get
        {
            return true;
        }
    }

    public UIRect parent
    {
        get
        {
            if (!mParentFound)
            {
                mParentFound = true;
                Transform t = cachedTransform.parent;
                mParent = (t != null) ? NGUITools.FindInParents<UIRect>(t) : null;
            }
            return mParent;
        }
    }

    public UIRoot root
    {
        get
        {
            if (!mRootSet)
            {
                mRootSet = true;
                mRoot = NGUITools.FindInParents<UIRoot>(cachedTransform);
            }
            return mRoot;
        }
    }

    public bool isAnchored
    {
        get
        {
            return leftAnchor.target != null || rightAnchor.target != null || bottomAnchor.target != null || topAnchor.target != null;
        }
    }

    public abstract float alpha { get; set; }

    public abstract Vector3[] localCorners { get; }

    public abstract Vector3[] worldCorners { get; }

    protected float cameraRayDistance
    {
        get
        {
            return 0f;
        }
    }

    public abstract float CalculateFinalAlpha(int frameID);

    public virtual void Invalidate(bool includeChildren)
    {
        mChanged = true;
        if (includeChildren)
        {
            for (int i = 0; i < mChildren.size; ++i)
            {
                mChildren[i].Invalidate(true);
            }
        }
    }

    public virtual Vector3[] GetSides(Transform relativeTo)
    {
        if (anchorCamera != null)
        {
            return mCam.GetWorldCorners(mCam.nearClipPlane, relativeTo);
        }
        return null;
    }

    protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
    {
        if (ac.targetCam != null && mCam != null)
        {
            Vector3 v = ac.targetCam.WorldToViewportPoint(ac.target.position);
            return mCam.ViewportToWorldPoint(v);
        }
        return ac.target.position;
    }

    protected virtual void OnEnable()
    {
        mUpdateFrame = -1;
        if (updateAnchors == AnchorUpdate.OnEnable)
        {
            mAnchorsCached = false;
            mUpdateAnchors = true;
        }
        if (mStarted)
            OnInit();
        mUpdateFrame = -1;
    }

    protected virtual void OnInit()
    {
        mParentFound = false;
        mRootSet = false;
        mParent = null;
        mRoot = null;
        mTrans = transform;
        mGo = gameObject;
        CacheAnchors();
        UIRect p = parent;
        if (p != null)
        {
            if (!p.mChildren.Contains(this))
                p.mChildren.Add(this);
        }
        if (updateAnchors == AnchorUpdate.OnStart || updateAnchors == AnchorUpdate.OnEnable)
            mUpdateAnchors = true;
    }

    protected virtual void OnDisable()
    {
        if (parent != null)
            parent.mChildren.Remove(this);
    }

    protected virtual void Awake()
    {
        mStarted = false;
        mGo = gameObject;
        mTrans = transform;
    }

    protected void Start()
    {
        ForceStart();
    }

    public void ForceStart()
    {
        mStarted = true;
        OnInit();
        OnStart();
    }

    public void Update()
    {
        if (!mStarted) return;

        int frame = Time.frameCount;
        if (mUpdateFrame != frame)
        {
            mUpdateFrame = frame;
            if (updateAnchors == AnchorUpdate.OnUpdate || mUpdateAnchors)
            {
                UpdateAnchorsInternal(frame);
            }
        }
        OnUpdate();
    }

    protected void UpdateAnchorsInternal(int frame)
    {
        mUpdateAnchors = false;
        if (!isAnchored) return;
        OnAnchor();
    }

    public void UpdateAnchors()
    {
        mUpdateAnchors = true;
        UpdateAnchorsInternal(Time.frameCount);
    }

    protected abstract void OnAnchor();

    public void SetAnchor(Transform t)
    {
        leftAnchor.target = t;
        rightAnchor.target = t;
        bottomAnchor.target = t;
        topAnchor.target = t;
        ResetAnchors();
    }

    public void SetAnchor(GameObject go)
    {
        Transform t = (go != null) ? go.transform : null;
        leftAnchor.target = t;
        rightAnchor.target = t;
        bottomAnchor.target = t;
        topAnchor.target = t;
        ResetAnchors();
    }

    public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
    {
        Transform t = (go != null) ? go.transform : null;
        leftAnchor.target = t;
        leftAnchor.relative = 0f;
        leftAnchor.absolute = left;

        rightAnchor.target = t;
        rightAnchor.relative = 1f;
        rightAnchor.absolute = right;

        bottomAnchor.target = t;
        bottomAnchor.relative = 0f;
        bottomAnchor.absolute = bottom;

        topAnchor.target = t;
        topAnchor.relative = 1f;
        topAnchor.absolute = top;

        ResetAnchors();
    }

    public void SetAnchor(GameObject go, float left, float bottom, float right, float top)
    {
        Transform t = (go != null) ? go.transform : null;
        leftAnchor.target = t;
        leftAnchor.relative = left;
        leftAnchor.absolute = 0;

        rightAnchor.target = t;
        rightAnchor.relative = right;
        rightAnchor.absolute = 0;

        bottomAnchor.target = t;
        bottomAnchor.relative = bottom;
        bottomAnchor.absolute = 0;

        topAnchor.target = t;
        topAnchor.relative = top;
        topAnchor.absolute = 0;

        ResetAnchors();
    }

    public void SetAnchor(GameObject go, float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
    {
        Transform t = (go != null) ? go.transform : null;
        leftAnchor.target = t;
        leftAnchor.relative = left;
        leftAnchor.absolute = leftOffset;

        rightAnchor.target = t;
        rightAnchor.relative = right;
        rightAnchor.absolute = rightOffset;

        bottomAnchor.target = t;
        bottomAnchor.relative = bottom;
        bottomAnchor.absolute = bottomOffset;

        topAnchor.target = t;
        topAnchor.relative = top;
        topAnchor.absolute = topOffset;

        ResetAnchors();
    }

    public void SetAnchor(float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
    {
        Transform t = cachedTransform.parent;
        leftAnchor.target = t;
        leftAnchor.relative = left;
        leftAnchor.absolute = leftOffset;

        rightAnchor.target = t;
        rightAnchor.relative = right;
        rightAnchor.absolute = rightOffset;

        bottomAnchor.target = t;
        bottomAnchor.relative = bottom;
        bottomAnchor.absolute = bottomOffset;

        topAnchor.target = t;
        topAnchor.relative = top;
        topAnchor.absolute = topOffset;

        ResetAnchors();
    }

    public void SetScreenRect(int left, int top, int width, int height) { }

    public void ResetAnchors()
    {
        mAnchorsCached = false;
        CacheAnchors();
        UpdateAnchors();
    }

    public void ResetAndUpdateAnchors()
    {
        ResetAnchors();
    }

    public abstract void SetRect(float x, float y, float width, float height);

    private void FindCameraFor(AnchorPoint ap)
    {
        if (ap.target == null)
        {
            ap.rect = null;
            ap.targetCam = null;
        }
        else
        {
            ap.rect = NGUITools.FindInParents<UIRect>(ap.target);
            ap.targetCam = NGUITools.FindCameraForLayer(ap.target.gameObject.layer);
        }
    }

    public virtual void ParentHasChanged()
    {
        mParentFound = false;
        mRootSet = false;
        mParent = null;
        mRoot = null;
        CacheAnchors();
    }

    protected void CacheAnchors()
    {
        mAnchorsCached = true;
        FindCameraFor(leftAnchor);
        FindCameraFor(rightAnchor);
        FindCameraFor(bottomAnchor);
        FindCameraFor(topAnchor);
        mCam = NGUITools.FindCameraForLayer(gameObject.layer);
    }

    protected abstract void OnStart();

    protected virtual void OnUpdate() { }
}