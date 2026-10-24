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
            get
            {
                return Time.realtimeSinceStartup - pressTime;
            }
        }

        public bool isOverUI
        {
            get
            {
                return current != null && IsPartOfUI(current);
            }
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

    public static RemoveTouchDelegate RemoveTouch;

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

    public static int currentTouchID = -10;

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

    private static DepthEntry mHit;

    private static BetterList<DepthEntry> mHits = new BetterList<DepthEntry>();

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
            if (list == null || list.size == 0) return null;
            return list.buffer[0];
        }
    }

    public static Ray currentRay
    {
        get
        {
            if (currentCamera == null) return lastWorldRay;
            Vector2 pos = (currentTouch != null) ? currentTouch.pos : mLastPos;
            return currentCamera.ScreenPointToRay(pos);
        }
    }

    public static GameObject hoveredObject
    {
        get { return mHover; }
        set { mHover = value; }
    }

    public static GameObject selectedObject
    {
        get { return mSelected; }
        set { mSelected = value; }
    }

    public static bool isOverUI
    {
        get { return mHover != null && IsPartOfUI(mHover); }
    }

    public static bool IsPartOfUI(GameObject go)
    {
        return go != null && go.GetComponentInParent<UIPanel>() != null;
    }

    public static bool IsPressed(GameObject go)
    {
        for (int i = 0; i < 3; i++)
            if (mMouse[i].pressed == go) return true;
        for (int i = 0; i < activeTouches.Count; i++)
            if (activeTouches[i].pressed == go) return true;
        return false;
    }

    public static int CountInputSources()
    {
        int count = 0;
        if (mMouse[0].pressed != null) count++;
        if (activeTouches.Count > 0) count += activeTouches.Count;
        return count;
    }

    private static MouseOrTouch GetMouseDelegateImpl(int button)
    {
        if (button >= 0 && button < mMouse.Length) return mMouse[button];
        return mMouse[0];
    }

    private static MouseOrTouch GetTouchDelegateImpl(int id, bool createIfMissing)
    {
        return mMouse[0];
    }

    private void Awake()
    {
        mCam = GetComponent<Camera>();
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
    }

    private void Update()
    {
        if (processEventsIn == ProcessEventsIn.Update) ProcessEvents();
    }

    private void LateUpdate()
    {
        if (processEventsIn == ProcessEventsIn.LateUpdate) ProcessEvents();
    }

    private void ProcessEvents()
    {
        if (ignoreAllEvents) return;
        if (list.size == 0 || list.buffer[0] != this) return;

        if (useMouse) ProcessMouse();
        if (useTouch) ProcessTouches();
        ProcessOthers();
    }

    public void ProcessMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mMouse[0].pos = mousePos;
        mMouse[0].delta = mousePos - (Vector3)mMouse[0].lastPos;
        mMouse[0].lastPos = mousePos;
        mLastPos = mousePos;

        bool pressed = Input.GetMouseButtonDown(0);
        bool released = Input.GetMouseButtonUp(0);
        bool held = Input.GetMouseButton(0);

        currentTouch = mMouse[0];
        currentTouchID = -1;
        currentCamera = cachedCamera;

        if (pressed || released || mMouse[0].pos != mMouse[0].lastPos)
        {
            Raycast(currentTouch);
        }

        if (pressed)
        {
            currentTouch.pressStarted = true;
            currentTouch.pressed = currentTouch.current;
            currentTouch.pressTime = Time.realtimeSinceStartup;
            if (onPress != null && currentTouch.pressed != null)
            {
                onPress(currentTouch.pressed, true);
            }
        }
        else if (released)
        {
            if (currentTouch.pressed != null)
            {
                if (onPress != null) onPress(currentTouch.pressed, false);
                if (onClick != null && currentTouch.pressed == currentTouch.current) onClick(currentTouch.pressed);
            }
            currentTouch.pressed = null;
            currentTouch.dragged = null;
        }
        else if (held && currentTouch.pressed != null)
        {
            if (currentTouch.delta.sqrMagnitude > mouseDragThreshold * mouseDragThreshold)
            {
                currentTouch.dragged = currentTouch.pressed;
                if (onDrag != null && currentTouch.dragged != null)
                {
                    onDrag(currentTouch.dragged, currentTouch.delta);
                }
            }
        }

        float scroll = Input.GetAxis(scrollAxisName);
        if (scroll != 0f && currentTouch.current != null)
        {
            if (onScroll != null) onScroll(currentTouch.current, scroll);
        }
    }

    public void ProcessTouches()
    {
    }

    public void ProcessOthers()
    {
    }

    public static void Raycast(MouseOrTouch touch)
    {
        if (eventHandler == null || eventHandler.cachedCamera == null) return;
        currentCamera = eventHandler.cachedCamera;
        lastWorldRay = currentCamera.ScreenPointToRay(touch.pos);
        RaycastHit hit;
        if (Physics.Raycast(lastWorldRay, out hit, eventHandler.rangeDistance > 0f ? eventHandler.rangeDistance : 1000f, eventHandler.eventReceiverMask))
        {
            lastHit = hit;
            lastWorldPosition = hit.point;
            touch.current = hit.collider.gameObject;
        }
        else
        {
            touch.current = fallThrough;
        }
    }

    public static bool Raycast(Vector3 inPos)
    {
        if (eventHandler == null || eventHandler.cachedCamera == null) return false;
        currentCamera = eventHandler.cachedCamera;
        Ray ray = currentCamera.ScreenPointToRay(inPos);
        RaycastHit hit;
        return Physics.Raycast(ray, out hit, 1000f, eventHandler.eventReceiverMask);
    }

    public static void Notify(GameObject go, string funcName, object obj)
    {
        if (go != null && go.activeInHierarchy)
        {
            go.SendMessage(funcName, obj, SendMessageOptions.DontRequireReceiver);
        }
    }

    public static void CancelNextTooltip() { }
    public static bool ShowTooltip(GameObject go) { return false; }
    public static bool HideTooltip() { return false; }
    public static void ResetTooltip(float delay = 0.5f) { }
}