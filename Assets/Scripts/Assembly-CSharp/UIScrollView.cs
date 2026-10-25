using System;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIPanel))]
public class UIScrollView : MonoBehaviour
{
    [DoNotObfuscateNGUI]
    public enum Movement
    {
        Horizontal = 0,
        Vertical = 1,
        Unrestricted = 2,
        Custom = 3
    }

    [DoNotObfuscateNGUI]
    public enum DragEffect
    {
        None = 0,
        Momentum = 1,
        MomentumAndSpring = 2
    }

    [DoNotObfuscateNGUI]
    public enum ShowCondition
    {
        Always = 0,
        OnlyIfNeeded = 1,
        WhenDragging = 2
    }

    public delegate void OnDragNotification();

    public static BetterList<UIScrollView> list = new BetterList<UIScrollView>();

    public Movement movement = Movement.Vertical;

    public DragEffect dragEffect = DragEffect.MomentumAndSpring;

    public bool restrictWithinPanel = true;

    public bool constrainOnDrag = false;

    public bool disableDragIfFits = false;

    public bool smoothDragStart = true;

    public bool iOSDragEmulation = true;

    public float scrollWheelFactor = 0.25f;

    public float momentumAmount = 35f;

    public float dampenStrength = 9f;

    public UIProgressBar horizontalScrollBar;

    public UIProgressBar verticalScrollBar;

    public ShowCondition showScrollBars = ShowCondition.OnlyIfNeeded;

    public Vector2 customMovement = new Vector2(1f, 0f);

    public UIWidget.Pivot contentPivot = UIWidget.Pivot.Top;

    public OnDragNotification onDragStarted;

    public OnDragNotification onDragFinished;

    public OnDragNotification onMomentumMove;

    public OnDragNotification onStoppedMoving;

    [HideInInspector]
    [SerializeField]
    private Vector3 scale = new Vector3(1f, 1f, 0f);

    [SerializeField]
    [HideInInspector]
    private Vector2 relativePositionOnReset = Vector2.zero;

    protected Transform mTrans;

    protected UIPanel mPanel;

    protected Plane mPlane;

    protected Vector3 mLastPos;

    protected bool mPressed;

    protected Vector3 mMomentum = Vector3.zero;

    protected float mScroll;

    protected Bounds mBounds;

    protected bool mCalculatedBounds = false;

    protected bool mShouldMove = false;

    protected bool mIgnoreCallbacks = false;

    protected int mDragID = -10;

    protected Vector2 mDragStartOffset = Vector2.zero;

    protected bool mDragStarted = false;

    [NonSerialized]
    private bool mStarted = false;

    [HideInInspector]
    public UICenterOnChild centerOnChild;

    public UIPanel panel
    {
        get
        {
            if (mPanel == null)
            {
                mPanel = GetComponent<UIPanel>();
            }
            return mPanel;
        }
    }

    public bool isDragging
    {
        get
        {
            return mPressed && mDragStarted;
        }
    }

    public virtual Bounds bounds
    {
        get
        {
            if (!mCalculatedBounds)
            {
                mCalculatedBounds = true;
                mBounds = NGUIMath.CalculateRelativeWidgetBounds(mTrans, mTrans);
            }
            return mBounds;
        }
    }

    public bool canMoveHorizontally
    {
        get
        {
            return movement == Movement.Horizontal || movement == Movement.Unrestricted || (movement == Movement.Custom && customMovement.x != 0f);
        }
    }

    public bool canMoveVertically
    {
        get
        {
            return movement == Movement.Vertical || movement == Movement.Unrestricted || (movement == Movement.Custom && customMovement.y != 0f);
        }
    }

    public virtual bool shouldMoveHorizontally
    {
        get
        {
            float width = bounds.size.x;
            if (mPanel != null && mPanel.clipping != UIPanel.Clipping.None)
            {
                Vector4 cr = mPanel.finalClipRegion;
                width = Mathf.Max(width, cr.z);
            }
            return width > mPanel.finalClipRegion.z;
        }
    }

    public virtual bool shouldMoveVertically
    {
        get
        {
            float height = bounds.size.y;
            if (mPanel != null && mPanel.clipping != UIPanel.Clipping.None)
            {
                Vector4 cr = mPanel.finalClipRegion;
                height = Mathf.Max(height, cr.w);
            }
            return height > mPanel.finalClipRegion.w;
        }
    }

    protected virtual bool shouldMove
    {
        get
        {
            if (!enabled || mPanel == null) return false;
            return canMoveHorizontally && shouldMoveHorizontally || canMoveVertically && shouldMoveVertically;
        }
    }

    public Vector3 currentMomentum
    {
        get
        {
            return mMomentum;
        }
        set
        {
            mMomentum = value;
            mShouldMove = true;
        }
    }

    private void Awake()
    {
        mTrans = transform;
        mPanel = GetComponent<UIPanel>();
    }

    private void OnEnable()
    {
        list.Add(this);
    }

    private void Start()
    {
        mStarted = true;
        CheckScrollbars();
    }

    private void CheckScrollbars()
    {
        if (horizontalScrollBar != null)
        {
            EventDelegate.Add(horizontalScrollBar.onChange, OnScrollBar);
        }
        if (verticalScrollBar != null)
        {
            EventDelegate.Add(verticalScrollBar.onChange, OnScrollBar);
        }
    }

    private void OnDisable()
    {
        list.Remove(this);
    }

    public bool RestrictWithinBounds(bool instant)
    {
        return RestrictWithinBounds(instant, canMoveHorizontally, canMoveVertically);
    }

    public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
    {
        if (mPanel == null) return false;
        Vector4 cr = mPanel.finalClipRegion;
        Bounds b = bounds;
        float x0 = b.min.x;
        float x1 = b.max.x;
        float y0 = b.min.y;
        float y1 = b.max.y;

        Vector3 min = new Vector3(cr.x - 0.5f * cr.z, cr.y - 0.5f * cr.w, 0f);
        Vector3 max = new Vector3(cr.x + 0.5f * cr.z, cr.y + 0.5f * cr.w, 0f);

        if (mPanel != null && mPanel.clipping != UIPanel.Clipping.None)
        {
            min.x += mPanel.clipSoftness.x;
            max.x -= mPanel.clipSoftness.x;
            min.y += mPanel.clipSoftness.y;
            max.y -= mPanel.clipSoftness.y;
        }

        float ox = 0f;
        float oy = 0f;

        if (horizontal)
        {
            if (b.size.x < cr.z)
            {
                if (contentPivot == UIWidget.Pivot.Left || contentPivot == UIWidget.Pivot.TopLeft || contentPivot == UIWidget.Pivot.BottomLeft)
                {
                    x1 = x0 + cr.z;
                }
                else if (contentPivot == UIWidget.Pivot.Right || contentPivot == UIWidget.Pivot.TopRight || contentPivot == UIWidget.Pivot.BottomRight)
                {
                    x0 = x1 - cr.z;
                }
                else
                {
                    float diff = (cr.z - b.size.x) * 0.5f;
                    x0 -= diff;
                    x1 += diff;
                }
            }

            if (x0 < min.x) ox = min.x - x0;
            else if (x1 > max.x) ox = max.x - x1;
        }

        if (vertical)
        {
            if (b.size.y < cr.w)
            {
                if (contentPivot == UIWidget.Pivot.Bottom || contentPivot == UIWidget.Pivot.BottomLeft || contentPivot == UIWidget.Pivot.BottomRight)
                {
                    y1 = y0 + cr.w;
                }
                else if (contentPivot == UIWidget.Pivot.Top || contentPivot == UIWidget.Pivot.TopLeft || contentPivot == UIWidget.Pivot.TopRight)
                {
                    y0 = y1 - cr.w;
                }
                else
                {
                    float diff = (cr.w - b.size.y) * 0.5f;
                    y0 -= diff;
                    y1 += diff;
                }
            }

            if (y0 < min.y) oy = min.y - y0;
            else if (y1 > max.y) oy = max.y - y1;
        }

        if (ox != 0f || oy != 0f)
        {
            Vector3 pos = mTrans.localPosition;
            pos.x += ox;
            pos.y += oy;

            if (instant)
            {
                Vector3 diff = pos - mTrans.localPosition;
                MoveAbsolute(diff);
                mMomentum = Vector3.zero;
                mScroll = 0f;
            }
            else
            {
                SpringPanel.Begin(mPanel.gameObject, pos, 13f);
            }
            return true;
        }
        return false;
    }

    public void DisableSpring()
    {
        SpringPanel sp = mPanel != null ? mPanel.GetComponent<SpringPanel>() : null;
        if (sp != null) sp.enabled = false;
    }

    public void UpdateScrollbars()
    {
        UpdateScrollbars(true);
    }

    public virtual void UpdateScrollbars(bool recalculateBounds)
    {
        if (mPanel == null) return;
        if (horizontalScrollBar != null || verticalScrollBar != null)
        {
            if (recalculateBounds)
            {
                mCalculatedBounds = false;
                mBounds = bounds;
            }

            Vector4 cr = mPanel.finalClipRegion;
            float viewWidth = cr.z;
            float viewHeight = cr.w;
            Bounds b = bounds;

            float contentMinX = b.min.x;
            float contentMaxX = b.max.x;
            float contentMinY = b.min.y;
            float contentMaxY = b.max.y;

            if (horizontalScrollBar != null)
            {
                UpdateScrollbars(horizontalScrollBar, contentMinX, contentMaxX, b.size.x, viewWidth, false);
            }

            if (verticalScrollBar != null)
            {
                UpdateScrollbars(verticalScrollBar, contentMinY, contentMaxY, b.size.y, viewHeight, true);
            }
        }
    }

    protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
    {
        if (slider == null) return;
        mIgnoreCallbacks = true;
        float min = contentMax - viewSize;
        float max = contentMin;
        float value = slider.value;

        if (contentSize > viewSize)
        {
            value = Mathf.Clamp01((mTrans.localPosition.x - min) / (max - min));
        }
        else
        {
            value = 0.5f;
        }

        slider.value = value;
        mIgnoreCallbacks = false;
    }

    public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
    {
        if (mPanel == null) return;
        Vector4 cr = mPanel.finalClipRegion;
        Bounds b = bounds;

        float minX = b.min.x;
        float maxX = b.max.x - cr.z;
        float minY = b.min.y;
        float maxY = b.max.y - cr.w;

        Vector3 pos = mTrans.localPosition;
        if (canMoveHorizontally) pos.x = Mathf.Lerp(maxX, minX, x);
        if (canMoveVertically) pos.y = Mathf.Lerp(maxY, minY, y);

        if (mTrans.localPosition != pos)
        {
            mTrans.localPosition = pos;
            mPanel.Refresh();
        }
    }

    public void InvalidateBounds()
    {
        mCalculatedBounds = false;
    }

    public void ResetPosition()
    {
        mCalculatedBounds = false;
        mBounds = bounds;
        Vector4 cr = mPanel.finalClipRegion;
        Vector2 pivotOffset = NGUIMath.GetPivotOffset(contentPivot);
        float x = Mathf.Lerp(mBounds.min.x, mBounds.max.x - cr.z, pivotOffset.x);
        float y = Mathf.Lerp(mBounds.min.y, mBounds.max.y - cr.w, pivotOffset.y);
        SetDragAmount(x, y, true);
    }

    public void UpdatePosition()
    {
        if (!mPressed)
        {
            mMomentum = Vector3.zero;
            mScroll = 0f;
        }
    }

    public void OnScrollBar()
    {
        if (mIgnoreCallbacks) return;
        if (horizontalScrollBar != null || verticalScrollBar != null)
        {
            float x = horizontalScrollBar != null ? horizontalScrollBar.value : 0f;
            float y = verticalScrollBar != null ? verticalScrollBar.value : 0f;
            SetDragAmount(x, y, false);
        }
    }

    public virtual void MoveRelative(Vector3 relative)
    {
        mTrans.localPosition += relative;
        Vector4 cr = mPanel.finalClipRegion;
        mPanel.clipOffset = new Vector2(mPanel.clipOffset.x - relative.x, mPanel.clipOffset.y - relative.y);
        UpdateScrollbars(false);
    }

    public void MoveAbsolute(Vector3 absolute)
    {
        Vector3 diff = mTrans.InverseTransformPoint(absolute) - mTrans.InverseTransformPoint(Vector3.zero);
        MoveRelative(diff);
    }

    public void Press(bool pressed)
    {
        mPressed = pressed;
        if (pressed)
        {
            mMomentum = Vector3.zero;
            mScroll = 0f;
            DisableSpring();
            mLastPos = UICamera.lastHit.point;
            mDragStarted = false;
        }
        else
        {
            if (centerOnChild != null)
            {
                // Dùng phương thức chuẩn của UICenterOnChild nếu có, hoặc bỏ qua gọi hàm không tồn tại
            }
            if (onDragFinished != null) onDragFinished();
        }
    }

    public void Drag()
    {
        if (enabled && gameObject.activeInHierarchy && mPressed)
        {
            if (!mDragStarted)
            {
                mDragStarted = true;
                if (onDragStarted != null) onDragStarted();
            }

            Ray ray = UICamera.currentRay;
            Plane plane = new Plane(mTrans.rotation * Vector3.back, mLastPos);
            float dist;

            if (plane.Raycast(ray, out dist))
            {
                Vector3 hitPos = ray.GetPoint(dist);
                Vector3 diff = hitPos - mLastPos;
                mLastPos = hitPos;

                if (diff.x != 0f || diff.y != 0f || diff.z != 0f)
                {
                    if (canMoveHorizontally) mMomentum.x = Mathf.Lerp(mMomentum.x, diff.x / Time.deltaTime * 0.5f, 0.65f);
                    if (canMoveVertically) mMomentum.y = Mathf.Lerp(mMomentum.y, diff.y / Time.deltaTime * 0.5f, 0.65f);

                    MoveRelative(diff);
                    if (restrictWithinPanel && dragEffect != DragEffect.MomentumAndSpring)
                    {
                        RestrictWithinBounds(true);
                    }
                }
            }
        }
    }

    public void Scroll(float delta)
    {
        if (enabled && gameObject.activeInHierarchy)
        {
            if (Mathf.Sign(mScroll) != Mathf.Sign(delta)) mScroll = 0f;
            mScroll += delta * scrollWheelFactor;
        }
    }

    private void LateUpdate()
    {
        if (!mStarted) return;
        float dt = RealTime.deltaTime;

        if (mPressed)
        {
            SpringPanel sp = mPanel.GetComponent<SpringPanel>();
            if (sp != null) sp.enabled = false;
            mMomentum = Vector3.zero;
            mScroll = 0f;
        }
        else
        {
            mMomentum += mTrans.TransformDirection(new Vector3(mScroll * momentumAmount, mScroll * momentumAmount, 0f));
            mScroll = NGUIMath.SpringLerp(mScroll, 0f, 20f, dt);

            if (mMomentum.magnitude > 0.01f)
            {
                MoveRelative(NGUIMath.SpringDampen(ref mMomentum, dampenStrength, dt));
                if (restrictWithinPanel)
                {
                    RestrictWithinBounds(false);
                }
                if (onMomentumMove != null) onMomentumMove();
            }
            else
            {
                mMomentum = Vector3.zero;
            }
        }

        UpdateScrollbars(false);
    }

    public void OnPan(Vector2 delta)
    {
        if (horizontalScrollBar != null) horizontalScrollBar.value += delta.x;
        if (verticalScrollBar != null) verticalScrollBar.value += delta.y;
    }
}