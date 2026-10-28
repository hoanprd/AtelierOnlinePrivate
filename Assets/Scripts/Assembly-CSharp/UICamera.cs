using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/UI/Camera")]
public class UICamera : MonoBehaviour
{
    [DoNotObfuscateNGUI]
    public enum ControlScheme
    {
        Mouse = 0,
        Touch = 1,
        Controller = 2
    }

    [DoNotObfuscateNGUI]
    public enum ClickNotification
    {
        None = 0,
        Always = 1,
        BasedOnDelta = 2
    }

    public class MouseOrTouch
    {
        public KeyCode key = KeyCode.Mouse0;
        public Vector2 pos;
        public Vector2 lastPos;
        public Vector2 delta;
        public Vector2 totalDelta;
        public Camera pressedCam;
        public GameObject last;
        public GameObject current;
        public GameObject pressed;
        public GameObject dragged;
        public float pressTime;
        public float clickTime;
        public ClickNotification clickNotification = ClickNotification.Always;
        public bool touchBegan = true;
        public bool pressStarted;
        public bool dragStarted;
        public int ignoreDelta;

        public float deltaTime
        {
            get { return Time.unscaledTime - pressTime; }
        }

        public bool isOverUI
        {
            get { return current != null && current != fallThrough && NGUITools.FindInParents<UIRoot>(current) != null; }
        }
    }

    [DoNotObfuscateNGUI]
    public enum EventType
    {
        World_3D = 0,
        UI_3D = 1,
        World_2D = 2,
        UI_2D = 3
    }

    public delegate bool GetKeyStateFunc(KeyCode key);
    public delegate float GetAxisFunc(string name);
    public delegate bool GetAnyKeyFunc();
    public delegate MouseOrTouch GetMouseDelegate(int button);
    public delegate MouseOrTouch GetTouchDelegate(int id, bool createIfMissing);
    public delegate void RemoveTouchDelegate(int id);
    public delegate void OnScreenResize();

    [DoNotObfuscateNGUI]
    public enum ProcessEventsIn
    {
        Update = 0,
        LateUpdate = 1
    }

    public delegate void OnCustomInput();
    public delegate void OnSchemeChange();
    public delegate void MoveDelegate(Vector2 delta);
    public delegate void VoidDelegate(GameObject go);
    public delegate void BoolDelegate(GameObject go, bool state);
    public delegate void FloatDelegate(GameObject go, float delta);
    public delegate void VectorDelegate(GameObject go, Vector2 delta);
    public delegate void ObjectDelegate(GameObject go, GameObject obj);
    public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

    private struct DepthEntry
    {
        public int depth;
        public RaycastHit hit;
        public Vector3 point;
        public GameObject go;
    }

    public class Touch
    {
        public int fingerId;
        public TouchPhase phase;
        public Vector2 position;
        public int tapCount;
    }

    public delegate int GetTouchCountCallback();
    public delegate Touch GetTouchCallback(int index);

    public static BetterList<UICamera> list = new BetterList<UICamera>();

    public static GetKeyStateFunc GetKeyDown = Input.GetKeyDown;
    public static GetKeyStateFunc GetKeyUp = Input.GetKeyUp;
    public static GetKeyStateFunc GetKey = Input.GetKey;
    public static GetAxisFunc GetAxis = Input.GetAxis;
    public static GetAnyKeyFunc GetAnyKeyDown = () => Input.anyKeyDown;
    public static GetMouseDelegate GetMouse = GetMouseDelegateImpl;
    public static GetTouchDelegate GetTouch = GetTouchDelegateImpl;
    public static RemoveTouchDelegate RemoveTouch = RemoveTouchDelegateImpl;
    public static OnScreenResize onScreenResize;

    public EventType eventType = EventType.UI_3D;
    public bool eventsGoToColliders = false;
    public LayerMask eventReceiverMask = -1;
    public ProcessEventsIn processEventsIn = ProcessEventsIn.Update;
    public bool debug = false;
    public bool useMouse = true;
    public bool useTouch = true;
    public bool allowMultiTouch = true;
    public bool useKeyboard = true;
    public bool useController = true;
    public bool stickyTooltip = true;
    public float tooltipDelay = 1f;
    public bool longPressTooltip = false;
    public float mouseDragThreshold = 4f;
    public float mouseClickThreshold = 10f;
    public float touchDragThreshold = 40f;
    public float touchClickThreshold = 40f;
    public float rangeDistance = -1f;
    public string horizontalAxisName = "Horizontal";
    public string verticalAxisName = "Vertical";
    public string horizontalPanAxisName = "";
    public string verticalPanAxisName = "";
    public string scrollAxisName = "Mouse ScrollWheel";
    public bool commandClick = true;
    public KeyCode submitKey0 = KeyCode.Return;
    public KeyCode submitKey1 = KeyCode.JoystickButton0;
    public KeyCode cancelKey0 = KeyCode.Escape;
    public KeyCode cancelKey1 = KeyCode.JoystickButton1;
    public bool autoHideCursor = true;

    public static OnCustomInput onCustomInput;
    public static bool showTooltips = true;
    public static bool ignoreAllEvents = false;
    public static bool ignoreControllerInput = false;
    private static bool mDisableController = false;
    private static Vector2 mLastPos = Vector2.zero;
    public static Vector3 lastWorldPosition = Vector3.zero;
    public static Ray lastWorldRay;
    public static RaycastHit lastHit;
    public static UICamera current;
    public static Camera currentCamera;
    public static OnSchemeChange onSchemeChange;
    private static ControlScheme mLastScheme = ControlScheme.Mouse;
    public static int currentTouchID = -100;
    private static KeyCode mCurrentKey = KeyCode.None;
    public static MouseOrTouch currentTouch;
    private static bool mInputFocus = false;
    private static GameObject mGenericHandler;
    public static GameObject fallThrough;

    public static VoidDelegate onClick;
    public static VoidDelegate onDoubleClick;
    public static BoolDelegate onHover;
    public static BoolDelegate onPress;
    public static BoolDelegate onSelect;
    public static FloatDelegate onScroll;
    public static VectorDelegate onDrag;
    public static VoidDelegate onDragStart;
    public static ObjectDelegate onDragOver;
    public static ObjectDelegate onDragOut;
    public static VoidDelegate onDragEnd;
    public static ObjectDelegate onDrop;
    public static KeyCodeDelegate onKey;
    public static KeyCodeDelegate onNavigate;
    public static VectorDelegate onPan;
    public static BoolDelegate onTooltip;
    public static MoveDelegate onMouseMove;

    private static MouseOrTouch[] mMouse = new MouseOrTouch[]
    {
        new MouseOrTouch() { key = KeyCode.Mouse0 },
        new MouseOrTouch() { key = KeyCode.Mouse1 },
        new MouseOrTouch() { key = KeyCode.Mouse2 }
    };

    public static MouseOrTouch controller = new MouseOrTouch();
    public static List<MouseOrTouch> activeTouches = new List<MouseOrTouch>();
    private static List<int> mTouchIDs = new List<int>();
    private static int mWidth = 0;
    private static int mHeight = 0;
    private static GameObject mTooltip;
    private Camera mCam;
    private static float mTooltipTime = 0f;
    private float mNextRaycast = 0f;
    public static bool isDragging = false;
    private static GameObject mHover;
    private static GameObject mSelected;
    private static DepthEntry mHit = default(DepthEntry);
    private static BetterList<DepthEntry> mHits = new BetterList<DepthEntry>();
    private static Plane m2DPlane = new Plane(Vector3.back, 0f);

    public Camera cachedCamera
    {
        get
        {
            if (mCam == null) mCam = GetComponent<Camera>();
            return mCam;
        }
    }

    public static UICamera eventHandler
    {
        get
        {
            for (int i = 0; i < list.size; i++)
            {
                UICamera cam = list.buffer[i];
                if (cam != null && cam.enabled && NGUITools.GetActive(cam.gameObject))
                    return cam;
            }
            return null;
        }
    }

    public static ControlScheme currentScheme
    {
        get { return mLastScheme; }
        set { mLastScheme = value; }
    }

    public static Ray currentRay
    {
        get
        {
            return (currentCamera != null && currentTouch != null) ? currentCamera.ScreenPointToRay(currentTouch.pos) : default(Ray);
        }
    }

    public static GameObject hoveredObject
    {
        get
        {
            if (currentTouch != null && currentTouch.dragStarted) return currentTouch.current;
            if (mHover != null && mHover.activeInHierarchy) return mHover;
            mHover = null;
            return null;
        }
        set
        {
            if (mHover == value) return;
            if (mHover != null)
            {
                Notify(mHover, "OnHover", false);
                if (onHover != null) onHover(mHover, false);
            }
            mHover = value;
            if (mHover != null)
            {
                Notify(mHover, "OnHover", true);
                if (onHover != null) onHover(mHover, true);
            }
        }
    }

    public static GameObject selectedObject
    {
        get
        {
            if (mSelected != null && mSelected.activeInHierarchy) return mSelected;
            mSelected = null;
            return null;
        }
        set
        {
            if (mSelected == value) return;
            if (mSelected != null)
            {
                Notify(mSelected, "OnSelect", false);
                if (onSelect != null) onSelect(mSelected, false);
            }
            mSelected = value;
            if (mSelected != null)
            {
                Notify(mSelected, "OnSelect", true);
                if (onSelect != null) onSelect(mSelected, true);
            }
        }
    }

    public static bool isOverUI
    {
        get
        {
            if (currentTouch != null) return currentTouch.isOverUI;
            return mHover != null && mHover != fallThrough && NGUITools.FindInParents<UIRoot>(mHover) != null;
        }
    }

    public static bool IsHighlighted(GameObject go)
    {
        return hoveredObject == go;
    }

    public static bool IsPartOfUI(GameObject go)
    {
        return go != null && go != fallThrough && NGUITools.FindInParents<UIRoot>(go) != null;
    }

    public static bool IsPressed(GameObject go)
    {
        for (int i = 0; i < 3; i++)
            if (mMouse[i].pressed == go) return true;
        for (int i = 0; i < activeTouches.Count; i++)
            if (activeTouches[i].pressed == go) return true;
        if (controller.pressed == go) return true;
        return false;
    }

    public static int CountInputSources()
    {
        int count = 0;
        for (int i = 0; i < 3; i++)
            if (mMouse[i].pressed != null) count++;
        for (int i = 0; i < activeTouches.Count; i++)
            if (activeTouches[i].pressed != null) count++;
        return count;
    }

    private static MouseOrTouch GetMouseDelegateImpl(int button)
    {
        if (button >= 0 && button < mMouse.Length) return mMouse[button];
        return mMouse[0];
    }

    private static MouseOrTouch GetTouchDelegateImpl(int id, bool createIfMissing)
    {
        if (id < 0) return GetMouse(-id - 1);
        for (int i = 0; i < mTouchIDs.Count; i++)
        {
            if (mTouchIDs[i] == id) return activeTouches[i];
        }
        if (createIfMissing)
        {
            MouseOrTouch touch = new MouseOrTouch();
            touch.pressTime = Time.unscaledTime;
            touch.touchBegan = true;
            activeTouches.Add(touch);
            mTouchIDs.Add(id);
            return touch;
        }
        return null;
    }

    private static void RemoveTouchDelegateImpl(int id)
    {
        for (int i = 0; i < mTouchIDs.Count; i++)
        {
            if (mTouchIDs[i] == id)
            {
                mTouchIDs.RemoveAt(i);
                activeTouches.RemoveAt(i);
                return;
            }
        }
    }

    private void Awake()
    {
        mWidth = Screen.width;
        mHeight = Screen.height;
        mCam = GetComponent<Camera>();
        mMouse[0].pos = Input.mousePosition;
        for (int i = 1; i < 3; i++)
        {
            mMouse[i].pos = mMouse[0].pos;
            mMouse[i].lastPos = mMouse[0].pos;
        }
        mLastPos = mMouse[0].pos;
    }

    private void OnEnable()
    {
        list.Add(this);
        list.Sort(CompareFunc);
    }

    private void OnDisable()
    {
        list.Remove(this);
    }

    private static int CompareFunc(UICamera a, UICamera b)
    {
        if (a.cachedCamera.depth < b.cachedCamera.depth) return 1;
        if (a.cachedCamera.depth > b.cachedCamera.depth) return -1;
        return 0;
    }

    private void Start()
    {
        if (eventType != EventType.World_3D && cachedCamera.transparencySortMode != TransparencySortMode.Orthographic)
            cachedCamera.transparencySortMode = TransparencySortMode.Orthographic;
        if (Application.isPlaying)
        {
            if (fallThrough == null)
            {
                UIRoot root = NGUITools.FindInParents<UIRoot>(gameObject);
                fallThrough = ((root != null) ? root.gameObject : gameObject);
            }
            cachedCamera.eventMask = 0;
        }
    }

    private void Update()
    {
        if (!Application.isPlaying) return;
        if (list.size == 0 || eventHandler != this) return;

        int w = Screen.width;
        int h = Screen.height;
        if (w != mWidth || h != mHeight)
        {
            mWidth = w;
            mHeight = h;
            UIRoot.Broadcast("UpdateAnchors");
            if (onScreenResize != null) onScreenResize();
        }

        if (processEventsIn == ProcessEventsIn.Update) ProcessEvents();
    }

    private void LateUpdate()
    {
        if (!Application.isPlaying) return;
        if (list.size == 0 || eventHandler != this) return;
        if (processEventsIn == ProcessEventsIn.LateUpdate) ProcessEvents();
    }

    private void ProcessEvents()
    {
        current = this;
        NGUIDebug_Update();
        if (useTouch) ProcessTouches();
        else if (useMouse) ProcessMouse();
        if (onCustomInput != null) onCustomInput();
        if (useKeyboard || useController) ProcessOthers();
        if (useMouse && mHover != null)
        {
            float scroll = GetAxis(scrollAxisName);
            if (scroll != 0f)
            {
                if (onScroll != null) onScroll(mHover, scroll);
                Notify(mHover, "OnScroll", scroll);
            }
        }
        current = null;
        currentTouchID = -100;
    }

    private void NGUIDebug_Update()
    {
    }

    public void ProcessMouse()
    {
        bool isPressed = false;
        bool justPressed = false;
        for (int i = 0; i < 3; i++)
        {
            if (Input.GetMouseButtonDown(i))
            {
                currentKey = (KeyCode)(323 + i);
                justPressed = true;
                isPressed = true;
            }
            else if (Input.GetMouseButton(i))
            {
                currentKey = (KeyCode)(323 + i);
                isPressed = true;
            }
        }

        if (currentScheme == ControlScheme.Touch && activeTouches.Count > 0) return;

        Vector2 pos = Input.mousePosition;
        mMouse[0].delta = pos - mMouse[0].pos;
        bool posChanged = (mMouse[0].pos != pos);
        mMouse[0].pos = pos;
        mLastPos = pos;

        for (int j = 1; j < 3; j++)
        {
            mMouse[j].pos = pos;
            mMouse[j].delta = mMouse[0].delta;
        }

        if (isPressed || posChanged || mNextRaycast < Time.unscaledTime)
        {
            mNextRaycast = Time.unscaledTime + 0.02f;
            Raycast(mMouse[0]);
            for (int k = 0; k < 3; k++) mMouse[k].current = mMouse[0].current;
        }

        bool highlightChanged = (mMouse[0].last != mMouse[0].current);
        if (highlightChanged) currentKey = KeyCode.Mouse0;

        if (!isPressed && posChanged && (!stickyTooltip || highlightChanged))
        {
            if (onMouseMove != null)
            {
                currentTouch = mMouse[0];
                onMouseMove(currentTouch.delta);
                currentTouch = null;
            }
        }

        if (justPressed || !isPressed)
        {
            hoveredObject = mMouse[0].current;
        }

        for (int b = 0; b < 3; b++)
        {
            bool pressed = Input.GetMouseButtonDown(b);
            bool unpressed = Input.GetMouseButtonUp(b);
            if (pressed || unpressed) currentKey = (KeyCode)(323 + b);
            currentTouch = mMouse[b];
            currentTouchID = -1 - b;
            currentKey = (KeyCode)(323 + b);

            if (pressed)
            {
                currentTouch.pressedCam = currentCamera;
                currentTouch.pressTime = Time.unscaledTime;
            }
            else if (currentTouch.pressed != null)
            {
                currentCamera = currentTouch.pressedCam;
            }

            ProcessTouch(pressed, unpressed);
            currentTouch.last = currentTouch.current;
        }
        currentTouch = null;
        mMouse[0].lastPos = pos;
    }

    public static KeyCode currentKey
    {
        get { return mCurrentKey; }
        set { mCurrentKey = value; }
    }

    public void ProcessTouches()
    {
        int count = Input.touchCount;
        for (int i = 0; i < count; i++)
        {
            UnityEngine.Touch touch = Input.GetTouch(i);
            int fingerId = allowMultiTouch ? touch.fingerId : 1;
            currentTouchID = fingerId;
            currentTouch = GetTouch(currentTouchID, true);

            bool pressed = (touch.phase == TouchPhase.Began) || currentTouch.touchBegan;
            bool unpressed = (touch.phase == TouchPhase.Canceled) || (touch.phase == TouchPhase.Ended);
            currentTouch.touchBegan = false;
            currentTouch.delta = touch.position - currentTouch.pos;
            currentTouch.pos = touch.position;
            currentKey = KeyCode.None;

            Raycast(currentTouch);
            if (pressed) currentTouch.pressedCam = currentCamera;
            else if (currentTouch.pressed != null) currentCamera = currentTouch.pressedCam;

            if (touch.tapCount > 1) currentTouch.clickTime = Time.unscaledTime;
            ProcessTouch(pressed, unpressed);
            if (unpressed) RemoveTouch(currentTouchID);
            currentTouch.last = null;
            currentTouch = null;
            if (!allowMultiTouch) break;
        }

        if (count == 0)
        {
            if (useMouse) ProcessMouse();
        }
    }

    public void ProcessOthers()
    {
        currentTouchID = -100;
        currentTouch = controller;
        bool submitKeyDown = false;
        bool submitKeyUp = false;
        if (submitKey0 != KeyCode.None && GetKeyDown(submitKey0))
        {
            currentKey = submitKey0;
            submitKeyDown = true;
        }
        else if (submitKey1 != KeyCode.None && GetKeyDown(submitKey1))
        {
            currentKey = submitKey1;
            submitKeyDown = true;
        }
        if (submitKey0 != KeyCode.None && GetKeyUp(submitKey0))
        {
            currentKey = submitKey0;
            submitKeyUp = true;
        }
        else if (submitKey1 != KeyCode.None && GetKeyUp(submitKey1))
        {
            currentKey = submitKey1;
            submitKeyUp = true;
        }
        if (submitKeyDown || submitKeyUp)
        {
            currentTouch.current = mSelected;
            ProcessTouch(submitKeyDown, submitKeyUp);
            currentTouch.last = currentTouch.current;
        }
        currentTouch = null;
    }

    public void ProcessTouch(bool pressed, bool released)
    {
        if (currentTouch == null) return;
        bool isMouse = (currentScheme == ControlScheme.Mouse);
        float drag = isMouse ? mouseDragThreshold : touchDragThreshold;
        float click = isMouse ? mouseClickThreshold : touchClickThreshold;
        drag *= drag;
        click *= click;

        if (currentTouch.pressed != null)
        {
            if (released) ProcessRelease(isMouse, drag);
            ProcessPress(pressed, click, drag);
        }
        else if (isMouse || pressed || released)
        {
            ProcessPress(pressed, click, drag);
            if (released) ProcessRelease(isMouse, drag);
        }
    }

    private void ProcessPress(bool pressed, float click, float drag)
    {
        if (pressed)
        {
            mTooltipTime = Time.unscaledTime + tooltipDelay;
            currentTouch.pressStarted = true;
            if (onPress != null && currentTouch.pressed != null)
                onPress(currentTouch.pressed, false);
            Notify(currentTouch.pressed, "OnPress", false);

            currentTouch.pressed = currentTouch.current;
            currentTouch.dragged = currentTouch.current;
            currentTouch.clickNotification = ClickNotification.BasedOnDelta;
            currentTouch.totalDelta = Vector2.zero;
            currentTouch.dragStarted = false;

            if (onPress != null && currentTouch.pressed != null)
                onPress(currentTouch.pressed, true);
            Notify(currentTouch.pressed, "OnPress", true);

            if (mSelected != currentTouch.pressed)
            {
                selectedObject = currentTouch.pressed;
            }
        }
        else if (currentTouch.pressed != null && (currentTouch.delta.sqrMagnitude != 0f || currentTouch.current != currentTouch.last))
        {
            currentTouch.totalDelta += currentTouch.delta;
            float mag = currentTouch.totalDelta.sqrMagnitude;
            bool justStarted = false;

            if (!currentTouch.dragStarted && currentTouch.last != currentTouch.current)
            {
                currentTouch.dragStarted = true;
                currentTouch.delta = currentTouch.totalDelta;
                isDragging = true;
                if (onDragStart != null) onDragStart(currentTouch.dragged);
                Notify(currentTouch.dragged, "OnDragStart", null);
                if (onDragOver != null) onDragOver(currentTouch.last, currentTouch.dragged);
                Notify(currentTouch.last, "OnDragOver", currentTouch.dragged);
                isDragging = false;
            }
            else if (!currentTouch.dragStarted && drag < mag)
            {
                justStarted = true;
                currentTouch.dragStarted = true;
                currentTouch.delta = currentTouch.totalDelta;
            }

            if (currentTouch.dragStarted)
            {
                isDragging = true;
                if (justStarted)
                {
                    if (onDragStart != null) onDragStart(currentTouch.dragged);
                    Notify(currentTouch.dragged, "OnDragStart", null);
                    if (onDragOver != null) onDragOver(currentTouch.last, currentTouch.dragged);
                    Notify(currentTouch.current, "OnDragOver", currentTouch.dragged);
                }
                else if (currentTouch.last != currentTouch.current)
                {
                    if (onDragOut != null) onDragOut(currentTouch.last, currentTouch.dragged);
                    Notify(currentTouch.last, "OnDragOut", currentTouch.dragged);
                    if (onDragOver != null) onDragOver(currentTouch.current, currentTouch.dragged);
                    Notify(currentTouch.current, "OnDragOver", currentTouch.dragged);
                }

                if (onDrag != null) onDrag(currentTouch.dragged, currentTouch.delta);
                Notify(currentTouch.dragged, "OnDrag", currentTouch.delta);
                currentTouch.last = currentTouch.current;
                isDragging = false;

                if (currentTouch.clickNotification == ClickNotification.BasedOnDelta && click < mag)
                {
                    currentTouch.clickNotification = ClickNotification.None;
                }
            }
        }
    }

    private void ProcessRelease(bool isMouse, float drag)
    {
        if (currentTouch == null) return;
        currentTouch.pressStarted = false;
        if (currentTouch.pressed != null)
        {
            if (currentTouch.dragStarted)
            {
                if (onDragOut != null) onDragOut(currentTouch.last, currentTouch.dragged);
                Notify(currentTouch.last, "OnDragOut", currentTouch.dragged);
                if (onDragEnd != null) onDragEnd(currentTouch.dragged);
                Notify(currentTouch.dragged, "OnDragEnd", null);
            }

            if (onPress != null) onPress(currentTouch.pressed, false);
            Notify(currentTouch.pressed, "OnPress", false);

            if (isMouse && mHover == currentTouch.pressed)
            {
                if (onHover != null) onHover(currentTouch.current, true);
                Notify(currentTouch.current, "OnHover", true);
            }

            if (currentTouch.dragged == currentTouch.current || (currentScheme != ControlScheme.Controller && currentTouch.clickNotification != ClickNotification.None && currentTouch.totalDelta.sqrMagnitude < drag))
            {
                if (currentTouch.clickNotification != ClickNotification.None && currentTouch.pressed == currentTouch.current)
                {
                    float time = Time.unscaledTime;
                    if (onClick != null) onClick(currentTouch.pressed);
                    Notify(currentTouch.pressed, "OnClick", null);

                    if (currentTouch.clickTime + 0.35f > time)
                    {
                        if (onDoubleClick != null) onDoubleClick(currentTouch.pressed);
                        Notify(currentTouch.pressed, "OnDoubleClick", null);
                    }
                    currentTouch.clickTime = time;
                }
            }
            else if (currentTouch.dragStarted)
            {
                if (onDrop != null) onDrop(currentTouch.current, currentTouch.dragged);
                Notify(currentTouch.current, "OnDrop", currentTouch.dragged);
            }
        }
        currentTouch.dragStarted = false;
        currentTouch.pressed = null;
        currentTouch.dragged = null;
    }

    public static void Raycast(MouseOrTouch touch)
    {
        if (!Raycast(touch.pos))
            mHit.go = fallThrough;
        if (mHit.go == null)
            mHit.go = mGenericHandler;
        touch.last = touch.current;
        touch.current = mHit.go;
        mLastPos = touch.pos;
    }

    public static bool Raycast(Vector3 inPos)
    {
        if (ignoreAllEvents) return false;
        for (int i = 0; i < list.size; i++)
        {
            UICamera cam = list.buffer[i];
            if (cam == null || !cam.enabled || !NGUITools.GetActive(cam.gameObject)) continue;

            currentCamera = cam.cachedCamera;
            if (currentCamera == null || currentCamera.cullingMask == 0) continue;

            Vector3 pos = currentCamera.ScreenToViewportPoint(inPos);
            if (float.IsNaN(pos.x) || float.IsNaN(pos.y)) continue;
            if (pos.x < 0f || pos.x > 1f || pos.y < 0f || pos.y > 1f) continue;

            Ray ray = currentCamera.ScreenPointToRay(inPos);
            int mask = currentCamera.cullingMask & (int)cam.eventReceiverMask;
            float dist = ((cam.rangeDistance > 0f) ? cam.rangeDistance : (currentCamera.farClipPlane - currentCamera.nearClipPlane));

            if (cam.eventType == EventType.World_3D)
            {
                if (Physics.Raycast(ray, out lastHit, dist, mask))
                {
                    lastWorldPosition = lastHit.point;
                    mHit.go = lastHit.collider.gameObject;
                    if (!cam.eventsGoToColliders)
                    {
                        Rigidbody rb = FindRootRigidbody(mHit.go.transform);
                        if (rb != null) mHit.go = rb.gameObject;
                    }
                    return true;
                }
            }
            else if (cam.eventType == EventType.UI_3D)
            {
                RaycastHit[] hits = Physics.RaycastAll(ray, dist, mask);
                if (hits.Length > 1)
                {
                    mHits.Clear();
                    for (int h = 0; h < hits.Length; h++)
                    {
                        GameObject go = hits[h].collider.gameObject;
                        UIWidget w = go.GetComponent<UIWidget>();
                        if (w != null)
                        {
                            if (!w.isVisible) continue;
                            if (w.hitCheck != null && !w.hitCheck(hits[h].point)) continue;
                        }
                        else
                        {
                            UIRect rect = NGUITools.FindInParents<UIRect>(go);
                            if (rect != null && rect.finalAlpha < 0.001f) continue;
                        }
                        mHit.depth = NGUITools.CalculateRaycastDepth(go);
                        if (mHit.depth != int.MaxValue)
                        {
                            mHit.hit = hits[h];
                            mHit.point = hits[h].point;
                            mHit.go = hits[h].collider.gameObject;
                            mHits.Add(mHit);
                        }
                    }
                    mHits.Sort((DepthEntry r1, DepthEntry r2) => r2.depth.CompareTo(r1.depth));
                    for (int b = 0; b < mHits.size; b++)
                    {
                        if (IsVisible(ref mHits.buffer[b]))
                        {
                            lastHit = mHits.buffer[b].hit;
                            mHit = mHits.buffer[b];
                            lastWorldPosition = mHits.buffer[b].point;
                            mHits.Clear();
                            return true;
                        }
                    }
                    mHits.Clear();
                }
                else if (hits.Length == 1)
                {
                    GameObject go2 = hits[0].collider.gameObject;
                    UIWidget w2 = go2.GetComponent<UIWidget>();
                    if (w2 != null)
                    {
                        if (!w2.isVisible) continue;
                        if (w2.hitCheck != null && !w2.hitCheck(hits[0].point)) continue;
                    }
                    else
                    {
                        UIRect rect2 = NGUITools.FindInParents<UIRect>(go2);
                        if (rect2 != null && rect2.finalAlpha < 0.001f) continue;
                    }
                    if (IsVisible(hits[0].point, hits[0].collider.gameObject))
                    {
                        lastHit = hits[0];
                        lastWorldPosition = hits[0].point;
                        mHit.go = lastHit.collider.gameObject;
                        return true;
                    }
                }
            }
            else if (cam.eventType == EventType.World_2D)
            {
                if (m2DPlane.Raycast(ray, out dist))
                {
                    Vector3 point = ray.GetPoint(dist);
                    Collider2D c2d = Physics2D.OverlapPoint(point, mask);
                    if (c2d != null)
                    {
                        lastWorldPosition = point;
                        mHit.go = c2d.gameObject;
                        if (!cam.eventsGoToColliders)
                        {
                            Rigidbody2D rb2 = FindRootRigidbody2D(mHit.go.transform);
                            if (rb2 != null) mHit.go = rb2.gameObject;
                        }
                        return true;
                    }
                }
            }
            else if (cam.eventType == EventType.UI_2D)
            {
                if (m2DPlane.Raycast(ray, out dist))
                {
                    lastWorldPosition = ray.GetPoint(dist);
                    Collider2D[] hits2d = Physics2D.OverlapPointAll(lastWorldPosition, mask);
                    if (hits2d.Length > 1)
                    {
                        mHits.Clear();
                        for (int c = 0; c < hits2d.Length; c++)
                        {
                            GameObject go3 = hits2d[c].gameObject;
                            UIWidget w3 = go3.GetComponent<UIWidget>();
                            if (w3 != null)
                            {
                                if (!w3.isVisible) continue;
                                if (w3.hitCheck != null && !w3.hitCheck(lastWorldPosition)) continue;
                            }
                            else
                            {
                                UIRect rect3 = NGUITools.FindInParents<UIRect>(go3);
                                if (rect3 != null && rect3.finalAlpha < 0.001f) continue;
                            }
                            mHit.depth = NGUITools.CalculateRaycastDepth(go3);
                            if (mHit.depth != int.MaxValue)
                            {
                                mHit.go = go3;
                                mHit.point = lastWorldPosition;
                                mHits.Add(mHit);
                            }
                        }
                        mHits.Sort((DepthEntry r1, DepthEntry r2) => r2.depth.CompareTo(r1.depth));
                        for (int d = 0; d < mHits.size; d++)
                        {
                            if (IsVisible(ref mHits.buffer[d]))
                            {
                                mHit = mHits.buffer[d];
                                mHits.Clear();
                                return true;
                            }
                        }
                        mHits.Clear();
                    }
                    else if (hits2d.Length == 1)
                    {
                        GameObject go4 = hits2d[0].gameObject;
                        UIWidget w4 = go4.GetComponent<UIWidget>();
                        if (w4 != null)
                        {
                            if (!w4.isVisible) continue;
                            if (w4.hitCheck != null && !w4.hitCheck(lastWorldPosition)) continue;
                        }
                        else
                        {
                            UIRect rect4 = NGUITools.FindInParents<UIRect>(go4);
                            if (rect4 != null && rect4.finalAlpha < 0.001f) continue;
                        }
                        if (IsVisible(lastWorldPosition, go4))
                        {
                            mHit.go = go4;
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    private static bool IsVisible(Vector3 worldPoint, GameObject go)
    {
        UIPanel panel = NGUITools.FindInParents<UIPanel>(go);
        while (panel != null)
        {
            if (!panel.IsVisible(worldPoint)) return false;
            panel = panel.parentPanel;
        }
        return true;
    }

    private static bool IsVisible(ref DepthEntry de)
    {
        UIPanel panel = NGUITools.FindInParents<UIPanel>(de.go);
        while (panel != null)
        {
            if (!panel.IsVisible(de.point)) return false;
            panel = panel.parentPanel;
        }
        return true;
    }

    private static Rigidbody FindRootRigidbody(Transform trans)
    {
        while (trans != null)
        {
            if (trans.GetComponent<UIPanel>() != null) return null;
            Rigidbody rb = trans.GetComponent<Rigidbody>();
            if (rb != null) return rb;
            trans = trans.parent;
        }
        return null;
    }

    private static Rigidbody2D FindRootRigidbody2D(Transform trans)
    {
        while (trans != null)
        {
            if (trans.GetComponent<UIPanel>() != null) return null;
            Rigidbody2D rb = trans.GetComponent<Rigidbody2D>();
            if (rb != null) return rb;
            trans = trans.parent;
        }
        return null;
    }

    public static void Notify(GameObject go, string funcName, object obj)
    {
        if (go != null && NGUITools.GetActive(go))
        {
            go.SendMessage(funcName, obj, SendMessageOptions.DontRequireReceiver);
            if (mGenericHandler != null && mGenericHandler != go)
            {
                mGenericHandler.SendMessage(funcName, obj, SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    public static void CancelNextTooltip() { mTooltipTime = 0f; }
    public static bool ShowTooltip(GameObject go) { return false; }
    public static bool HideTooltip() { return false; }
    public static void ResetTooltip(float delay = 0.5f) { }
}
