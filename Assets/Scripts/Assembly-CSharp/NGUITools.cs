using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class NGUITools
{
    public delegate void OnInitFunc<T>(T w) where T : UIWidget;

    [NonSerialized]
    private static AudioListener mListener;

    [NonSerialized]
    public static AudioSource audioSource;

    private static bool mLoaded;

    private static float mGlobalVolume = 1f;

    private static float mLastTimestamp;

    private static AudioClip mLastClip;

    private static Dictionary<Type, string> mTypeNames = new Dictionary<Type, string>();

    private static Vector3[] mSides = new Vector3[4];

    public static KeyCode[] keys = new KeyCode[]
    {
        KeyCode.Joystick1Button0, KeyCode.Joystick1Button1, KeyCode.Joystick1Button2, KeyCode.Joystick1Button3,
        KeyCode.Joystick1Button4, KeyCode.Joystick1Button5, KeyCode.Joystick1Button6, KeyCode.Joystick1Button7
    };

    private static Dictionary<string, UIWidget> mWidgets = new Dictionary<string, UIWidget>();

    private static UIPanel mRoot;

    private static GameObject mGo;

    private static ColorSpace mColorSpace = ColorSpace.Uninitialized;

    public static float soundVolume
    {
        get { return mGlobalVolume; }
        set { mGlobalVolume = Mathf.Clamp01(value); }
    }

    public static bool fileAccess
    {
        get { return true; }
    }

    public static string clipboard
    {
        get
        {
            TextEditor te = new TextEditor();
            return te.text;
        }
        set
        {
            TextEditor te = new TextEditor();
            te.text = value;
            te.SelectAll();
            te.Copy();
        }
    }

    public static Vector2 screenSize
    {
        get
        {
            return new Vector2(Screen.width, Screen.height);
        }
    }

    public static AudioSource PlaySound(AudioClip clip)
    {
        return PlaySound(clip, 1f, 1f);
    }

    public static AudioSource PlaySound(AudioClip clip, float volume)
    {
        return PlaySound(clip, volume, 1f);
    }

    public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
    {
        if (clip == null || mGlobalVolume == 0f) return null;

        mLastClip = clip;
        mLastTimestamp = Time.realtimeSinceStartup;

        if (audioSource == null)
        {
            GameObject go = new GameObject("[NGUI] Audio Source");
            UnityEngine.Object.DontDestroyOnLoad(go);
            audioSource = go.AddComponent<AudioSource>();
        }

        audioSource.pitch = pitch;
        audioSource.PlayOneShot(clip, volume * mGlobalVolume);
        return audioSource;
    }

    public static int RandomRange(int min, int max)
    {
        if (min == max) return min;
        return UnityEngine.Random.Range(min, max + 1);
    }

    public static string GetHierarchy(GameObject obj)
    {
        if (obj == null) return "";
        string name = obj.name;
        Transform parent = obj.transform.parent;
        while (parent != null)
        {
            name = parent.name + "/" + name;
            parent = parent.parent;
        }
        return name;
    }

    public static T[] FindActive<T>() where T : Component
    {
        return UnityEngine.Object.FindObjectsOfType<T>();
    }

    public static Camera FindCameraForLayer(int layer)
    {
        int mask = 1 << layer;
        Camera cam;

        for (int i = 0; i < Camera.allCamerasCount; ++i)
        {
            cam = Camera.allCameras[i];
            if (cam != null && (cam.cullingMask & mask) != 0)
            {
                return cam;
            }
        }
        return null;
    }

    public static void AddWidgetCollider(GameObject go)
    {
        AddWidgetCollider(go, false);
    }

    public static void AddWidgetCollider(GameObject go, bool considerInactive)
    {
        if (go != null)
        {
            UIWidget w = go.GetComponent<UIWidget>();
            if (w != null)
            {
                BoxCollider bc = go.GetComponent<BoxCollider>();
                if (bc == null) bc = go.AddComponent<BoxCollider>();
                UpdateWidgetCollider(w, bc);
            }
        }
    }

    public static void UpdateWidgetCollider(GameObject go)
    {
        UpdateWidgetCollider(go, false);
    }

    public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
    {
        if (go != null)
        {
            UIWidget w = go.GetComponent<UIWidget>();
            if (w != null)
            {
                BoxCollider bc = go.GetComponent<BoxCollider>();
                if (bc != null) UpdateWidgetCollider(w, bc);
            }
        }
    }

    public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
    {
        if (box != null)
        {
            UIWidget w = box.GetComponent<UIWidget>();
            if (w != null) UpdateWidgetCollider(w, box);
        }
    }

    public static void UpdateWidgetCollider(UIWidget w)
    {
        if (w != null)
        {
            BoxCollider bc = w.GetComponent<BoxCollider>();
            if (bc != null) UpdateWidgetCollider(w, bc);
        }
    }

    public static void UpdateWidgetCollider(UIWidget w, BoxCollider box)
    {
        if (w == null || box == null) return;
        Bounds b = w.CalculateBounds(w.cachedTransform);
        box.center = b.center;
        box.size = new Vector3(b.size.x, b.size.y, 0f);
    }

    public static void UpdateWidgetCollider(UIWidget w, BoxCollider2D box)
    {
        if (w == null || box == null) return;
        Bounds b = w.CalculateBounds(w.cachedTransform);
        box.offset = b.center;
        box.size = new Vector2(b.size.x, b.size.y);
    }

    public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
    {
        if (box != null)
        {
            UIWidget w = box.GetComponent<UIWidget>();
            if (w != null) UpdateWidgetCollider(w, box);
        }
    }

    public static string GetTypeName<T>()
    {
        return GetTypeName(typeof(T));
    }

    public static string GetTypeName(UnityEngine.Object obj)
    {
        if (obj == null) return "Null";
        string typeName = obj.GetType().ToString();
        int index = typeName.LastIndexOf('.');
        if (index > 0) typeName = typeName.Substring(index + 1);
        return typeName;
    }

    private static string GetTypeName(Type t)
    {
        if (t == null) return "Null";
        string name;
        if (mTypeNames.TryGetValue(t, out name)) return name;
        name = t.ToString();
        int index = name.LastIndexOf('.');
        if (index > 0) name = name.Substring(index + 1);
        mTypeNames[t] = name;
        return name;
    }

    public static void RegisterUndo(UnityEngine.Object obj, string name)
    {
#if UNITY_EDITOR
        UnityEditor.Undo.RegisterCompleteObjectUndo(obj, name);
        SetDirty(obj);
#endif
    }

    public static void SetDirty(UnityEngine.Object obj, string undoName = "last change")
    {
#if UNITY_EDITOR
        if (obj != null)
        {
            UnityEditor.EditorUtility.SetDirty(obj);
        }
#endif
    }

    public static void CheckForPrefabStage(GameObject gameObject)
    {
    }

    public static GameObject AddChild(GameObject parent)
    {
        GameObject go = new GameObject("GameObject");
        if (parent != null)
        {
            Transform t = go.transform;
            t.SetParent(parent.transform, false);
            t.localPosition = Vector3.zero;
            t.localRotation = Quaternion.identity;
            t.localScale = Vector3.one;
            go.layer = parent.layer;
        }
        return go;
    }

    public static GameObject AddChild(this GameObject parent, int layer)
    {
        GameObject go = AddChild(parent);
        go.layer = layer;
        return go;
    }

    public static GameObject AddChild(this GameObject parent, bool undo)
    {
        return AddChild(parent);
    }

    public static GameObject AddChild(this GameObject parent, bool undo, int layer)
    {
        GameObject go = AddChild(parent, layer);
        return go;
    }

    public static GameObject AddChild(this Transform parent, GameObject prefab)
    {
        return AddChild(parent != null ? parent.gameObject : null, prefab);
    }

    public static GameObject AddChild(this GameObject parent, GameObject prefab)
    {
        if (prefab == null) return AddChild(parent);
        GameObject go = UnityEngine.Object.Instantiate(prefab) as GameObject;
        if (go != null && parent != null)
        {
            Transform t = go.transform;
            t.SetParent(parent.transform, false);
            t.localPosition = Vector3.zero;
            t.localRotation = Quaternion.identity;
            t.localScale = Vector3.one;
            go.layer = parent.layer;
        }
        return go;
    }

    public static GameObject AddChild(this GameObject parent, GameObject prefab, int layer)
    {
        GameObject go = AddChild(parent, prefab);
        if (go != null) go.layer = layer;
        return go;
    }

    public static int CalculateRaycastDepth(GameObject go)
    {
        UIWidget w = go.GetComponent<UIWidget>();
        if (w != null) return w.raycastDepth;
        UIWidget[] widgets = go.GetComponentsInChildren<UIWidget>(true);
        if (widgets.Length == 0) return 0;
        int depth = int.MaxValue;
        for (int i = 0, imax = widgets.Length; i < imax; ++i)
        {
            if (widgets[i].enabled) depth = Mathf.Min(depth, widgets[i].raycastDepth);
        }
        return depth;
    }

    public static int CalculateNextDepth(GameObject go)
    {
        int depth = -1;
        UIWidget[] widgets = go.GetComponentsInChildren<UIWidget>(true);
        for (int i = 0, imax = widgets.Length; i < imax; ++i)
        {
            depth = Mathf.Max(depth, widgets[i].depth);
        }
        return depth + 1;
    }

    public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
    {
        return CalculateNextDepth(go);
    }

    public static int AdjustDepth(GameObject go, int adjustment)
    {
        UIWidget[] widgets = go.GetComponentsInChildren<UIWidget>(true);
        if (widgets.Length == 0) return 0;
        for (int i = 0, imax = widgets.Length; i < imax; ++i)
        {
            UIWidget w = widgets[i];
            w.depth += adjustment;
        }
        return widgets.Length;
    }

    public static void BringForward(GameObject go)
    {
        AdjustDepth(go, 1);
    }

    public static void PushBack(GameObject go)
    {
        AdjustDepth(go, -1);
    }

    public static void NormalizeDepths()
    {
        NormalizePanelDepths();
    }

    public static void NormalizeWidgetDepths()
    {
        UIWidget[] widgets = FindActive<UIWidget>();
        if (widgets.Length > 0)
        {
            Array.Sort(widgets, (v1, v2) => v1.depth.CompareTo(v2.depth));
            for (int i = 0, imax = widgets.Length; i < imax; ++i)
            {
                widgets[i].depth = i;
            }
        }
    }

    public static void NormalizeWidgetDepths(GameObject go)
    {
        UIWidget[] widgets = go.GetComponentsInChildren<UIWidget>(true);
        if (widgets.Length > 0)
        {
            Array.Sort(widgets, (v1, v2) => v1.depth.CompareTo(v2.depth));
            for (int i = 0, imax = widgets.Length; i < imax; ++i)
            {
                widgets[i].depth = i;
            }
        }
    }

    public static void NormalizeWidgetDepths(UIWidget[] list)
    {
        if (list.Length > 0)
        {
            Array.Sort(list, (v1, v2) => v1.depth.CompareTo(v2.depth));
            for (int i = 0, imax = list.Length; i < imax; ++i)
            {
                list[i].depth = i;
            }
        }
    }

    public static void NormalizePanelDepths()
    {
        UIPanel[] panels = FindActive<UIPanel>();
        if (panels.Length > 0)
        {
            Array.Sort(panels, (v1, v2) => v1.depth.CompareTo(v2.depth));
            for (int i = 0, imax = panels.Length; i < imax; ++i)
            {
                panels[i].depth = i;
            }
        }
    }

    public static UIPanel CreateUI(bool advanced3D)
    {
        return CreateUI(null, advanced3D, -1);
    }

    public static UIPanel CreateUI(bool advanced3D, int layer)
    {
        return CreateUI(null, advanced3D, layer);
    }

    public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
    {
        Camera cam = null;
        if (trans != null)
        {
            Camera[] cams = FindActive<Camera>();
            for (int i = 0; i < cams.Length; ++i)
            {
                if (cams[i].gameObject == trans.gameObject)
                {
                    cam = cams[i];
                    break;
                }
            }
        }

        UIPanel panel = null;
        if (cam != null)
        {
            Transform t = cam.transform;
            GameObject go = new GameObject("UI Root");
            Transform rootTrans = go.transform;
            rootTrans.parent = t;
            rootTrans.localPosition = Vector3.zero;
            rootTrans.localRotation = Quaternion.identity;
            rootTrans.localScale = Vector3.one;
            go.layer = cam.gameObject.layer;
            panel = go.AddComponent<UIPanel>();
        }
        else
        {
            UIPanel[] panels = FindActive<UIPanel>();
            for (int i = 0; i < panels.Length; ++i)
            {
                UIPanel p = panels[i];
                if (p.anchorOffset)
                {
                    panel = p;
                    break;
                }
            }

            if (panel == null)
            {
                GameObject go = new GameObject("UI Root");
                panel = go.AddComponent<UIPanel>();
            }
        }

        if (layer != -1) panel.gameObject.layer = layer;
        return panel;
    }

    public static void SetChildLayer(this Transform t, int layer)
    {
        for (int i = 0; i < t.childCount; ++i)
        {
            Transform child = t.GetChild(i);
            child.gameObject.layer = layer;
            SetChildLayer(child, layer);
        }
    }

    public static T AddChild<T>(this GameObject parent) where T : Component
    {
        GameObject go = AddChild(parent);
        return go.AddComponent<T>();
    }

    public static T AddChild<T>(this GameObject parent, bool undo) where T : Component
    {
        return AddChild<T>(parent);
    }

    public static T AddWidget<T>(this GameObject go, int depth = int.MaxValue) where T : UIWidget
    {
        T widget = AddChild<T>(go);
        widget.depth = (depth == int.MaxValue) ? CalculateNextDepth(go) : depth;
        return widget;
    }

    public static UISprite AddSprite(this GameObject go, INGUIAtlas atlas, string spriteName, int depth = int.MaxValue)
    {
        UISprite sprite = AddWidget<UISprite>(go, depth);
        sprite.atlas = atlas;
        sprite.spriteName = spriteName;
        return sprite;
    }

    public static GameObject GetRoot(GameObject go)
    {
        if (go == null) return null;
        Transform t = go.transform;
        for (; ; )
        {
            Transform parent = t.parent;
            if (parent == null) break;
            t = parent;
        }
        return t.gameObject;
    }

    public static T FindInParents<T>(GameObject go) where T : Component
    {
        if (go == null) return null;
        Transform trans = go.transform;
        while (trans != null)
        {
            T comp = trans.GetComponent<T>();
            if (comp != null) return comp;
            trans = trans.parent;
        }
        return null;
    }

    public static T FindInParents<T>(Transform trans) where T : Component
    {
        if (trans == null) return null;
        while (trans != null)
        {
            T comp = trans.GetComponent<T>();
            if (comp != null) return comp;
            trans = trans.parent;
        }
        return null;
    }

    public static void Destroy(UnityEngine.Object obj)
    {
        if (obj != null)
        {
            if (Application.isPlaying)
            {
                if (obj is GameObject) UnityEngine.Object.Destroy((GameObject)obj);
                else if (obj is Component) UnityEngine.Object.Destroy(((Component)obj).gameObject);
                else UnityEngine.Object.Destroy(obj);
            }
            else
            {
                UnityEngine.Object.DestroyImmediate(obj);
            }
        }
    }

    public static void DestroyChildren(this Transform t)
    {
        if (t != null)
        {
            for (int i = t.childCount; i > 0;)
            {
                Transform child = t.GetChild(--i);
                if (Application.isPlaying)
                {
                    child.SetParent(null);
                    Destroy(child.gameObject);
                }
                else
                {
                    DestroyImmediate(child.gameObject);
                }
            }
        }
    }

    public static void DestroyImmediate(UnityEngine.Object obj)
    {
        if (obj != null)
        {
            UnityEngine.Object.DestroyImmediate(obj);
        }
    }

    public static void Broadcast(string funcName)
    {
        GameObject[] gos = UnityEngine.Object.FindObjectsOfType<GameObject>();
        for (int i = 0, imax = gos.Length; i < imax; ++i)
        {
            gos[i].SendMessage(funcName, SendMessageOptions.DontRequireReceiver);
        }
    }

    public static void Broadcast(string funcName, object param)
    {
        GameObject[] gos = UnityEngine.Object.FindObjectsOfType<GameObject>();
        for (int i = 0, imax = gos.Length; i < imax; ++i)
        {
            gos[i].SendMessage(funcName, param, SendMessageOptions.DontRequireReceiver);
        }
    }

    public static bool IsChild(Transform parent, Transform child)
    {
        if (parent == null || child == null) return false;
        while (child != null)
        {
            if (child == parent) return true;
            child = child.parent;
        }
        return false;
    }

    private static void Activate(Transform t)
    {
        Activate(t, true);
    }

    private static void Activate(Transform t, bool compatibilityMode)
    {
        t.gameObject.SetActive(true);
    }

    private static void Deactivate(Transform t)
    {
        t.gameObject.SetActive(false);
    }

    public static void SetActive(GameObject go, bool state)
    {
        if (go != null)
        {
            if (state)
            {
                if (!go.activeSelf) go.SetActive(true);
            }
            else
            {
                if (go.activeSelf) go.SetActive(false);
            }
        }
    }

    public static void SetActive(GameObject go, bool state, bool compatibilityMode)
    {
        SetActive(go, state);
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    private static void CallCreatePanel(Transform t)
    {
    }

    public static void SetActiveChildren(GameObject go, bool state)
    {
        if (go != null)
        {
            Transform t = go.transform;
            for (int i = 0; i < t.childCount; ++i)
            {
                SetActive(t.GetChild(i).gameObject, state);
            }
        }
    }

    [Obsolete]
    public static bool IsActive(Behaviour mb)
    {
        return mb != null && mb.enabled && mb.gameObject.activeInHierarchy;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static bool GetActive(Behaviour mb)
    {
        return mb != null && mb.enabled && mb.gameObject.activeInHierarchy;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static bool GetActive(GameObject go)
    {
        return go != null && go.activeInHierarchy;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static void SetActiveSelf(GameObject go, bool state)
    {
        if (go != null) go.SetActive(state);
    }

    public static void SetLayer(GameObject go, int layer)
    {
        go.layer = layer;
        Transform t = go.transform;
        for (int i = 0; i < t.childCount; ++i)
        {
            SetLayer(t.GetChild(i).gameObject, layer);
        }
    }

    public static Vector3 Round(Vector3 v)
    {
        v.x = Mathf.Round(v.x);
        v.y = Mathf.Round(v.y);
        v.z = Mathf.Round(v.z);
        return v;
    }

    public static void MakePixelPerfect(Transform t)
    {
        UIWidget widget = t.GetComponent<UIWidget>();
        if (widget != null)
        {
            widget.MakePixelPerfect();
        }
        else
        {
            for (int i = 0; i < t.childCount; ++i)
            {
                MakePixelPerfect(t.GetChild(i));
            }
        }
    }

    public static void FitOnScreen(this Camera cam, Transform t, bool considerInactive = false, bool considerChildren = true)
    {
    }

    public static void FitOnScreen(this Camera cam, Transform transform, Vector3 pos)
    {
    }

    public static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos, bool considerInactive = false)
    {
    }

    public static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos, out Bounds bounds, bool considerInactive = false)
    {
        bounds = default(Bounds);
    }

    public static bool Save(string fileName, byte[] bytes)
    {
        return false;
    }

    public static byte[] Load(string fileName)
    {
        return null;
    }

    public static Color ApplyPMA(Color c)
    {
        if (c.a != 1f && c.a != 0f)
        {
            c.r *= c.a;
            c.g *= c.a;
            c.b *= c.a;
        }
        return c;
    }

    public static void MarkParentAsChanged(GameObject go)
    {
        UIRect[] rects = go.GetComponentsInChildren<UIRect>(true);
        for (int i = 0, imax = rects.Length; i < imax; ++i)
        {
            rects[i].ParentHasChanged();
        }
    }

    [Obsolete]
    public static string EncodeColor(Color c)
    {
        int i = Mathf.RoundToInt(c.r * 255f) << 16 | Mathf.RoundToInt(c.g * 255f) << 8 | Mathf.RoundToInt(c.b * 255f);
        return i.ToString("X6");
    }

    [Obsolete]
    public static Color ParseColor(string text, int offset)
    {
        return Color.white;
    }

    [Obsolete]
    public static string StripSymbols(string text)
    {
        return text;
    }

    public static T AddMissingComponent<T>(this GameObject go) where T : Component
    {
        if (go == null) return null;
        T comp = go.GetComponent<T>();
        if (comp == null) comp = go.AddComponent<T>();
        return comp;
    }

    public static Vector3[] GetSides(this Camera cam)
    {
        return cam.GetSides(Mathf.Lerp(cam.nearClipPlane, cam.farClipPlane, 0.5f), null);
    }

    public static Vector3[] GetSides(this Camera cam, float depth)
    {
        return cam.GetSides(depth, null);
    }

    public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
    {
        return cam.GetSides(Mathf.Lerp(cam.nearClipPlane, cam.farClipPlane, 0.5f), relativeTo);
    }

    public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
    {
        if (cam.orthographic)
        {
            float ortho = cam.orthographicSize;
            float x0 = -ortho * cam.aspect;
            float x1 = ortho * cam.aspect;
            float y0 = -ortho;
            float y1 = ortho;

            mSides[0] = new Vector3(x0, y0, depth);
            mSides[1] = new Vector3(x0, y1, depth);
            mSides[2] = new Vector3(x1, y1, depth);
            mSides[3] = new Vector3(x1, y0, depth);
        }
        else
        {
            mSides[0] = cam.ViewportToWorldPoint(new Vector3(0f, 0f, depth));
            mSides[1] = cam.ViewportToWorldPoint(new Vector3(0f, 1f, depth));
            mSides[2] = cam.ViewportToWorldPoint(new Vector3(1f, 1f, depth));
            mSides[3] = cam.ViewportToWorldPoint(new Vector3(1f, 0f, depth));
        }

        if (relativeTo != null)
        {
            for (int i = 0; i < 4; ++i)
            {
                mSides[i] = relativeTo.InverseTransformPoint(mSides[i]);
            }
        }
        return mSides;
    }

    public static Vector3[] GetWorldCorners(this Camera cam)
    {
        return cam.GetWorldCorners(Mathf.Lerp(cam.nearClipPlane, cam.farClipPlane, 0.5f), null);
    }

    public static Vector3[] GetWorldCorners(this Camera cam, float depth)
    {
        return cam.GetWorldCorners(depth, null);
    }

    public static Vector3[] GetWorldCorners(this Camera cam, Transform relativeTo)
    {
        return cam.GetWorldCorners(Mathf.Lerp(cam.nearClipPlane, cam.farClipPlane, 0.5f), relativeTo);
    }

    public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
    {
        if (cam.orthographic)
        {
            float ortho = cam.orthographicSize;
            float x0 = -ortho * cam.aspect;
            float x1 = ortho * cam.aspect;
            float y0 = -ortho;
            float y1 = ortho;

            mSides[0] = new Vector3(x0, y0, depth);
            mSides[1] = new Vector3(x0, y1, depth);
            mSides[2] = new Vector3(x1, y1, depth);
            mSides[3] = new Vector3(x1, y0, depth);
        }
        else
        {
            mSides[0] = cam.ViewportToWorldPoint(new Vector3(0f, 0f, depth));
            mSides[1] = cam.ViewportToWorldPoint(new Vector3(0f, 1f, depth));
            mSides[2] = cam.ViewportToWorldPoint(new Vector3(1f, 1f, depth));
            mSides[3] = cam.ViewportToWorldPoint(new Vector3(1f, 0f, depth));
        }

        if (relativeTo != null)
        {
            for (int i = 0; i < 4; ++i)
            {
                mSides[i] = relativeTo.InverseTransformPoint(mSides[i]);
            }
        }
        return mSides;
    }

    public static string GetFuncName(object obj, string method)
    {
        if (obj == null) return "<null>";
        string type = obj.GetType().ToString();
        int index = type.LastIndexOf('.');
        if (index > 0) type = type.Substring(index + 1);
        return type + "/" + method;
    }

    public static void Execute<T>(GameObject go, string funcName) where T : Component
    {
        T[] comps = go.GetComponentsInChildren<T>(true);
        for (int i = 0, imax = comps.Length; i < imax; ++i)
        {
            Component comp = comps[i];
            Behaviour b = comp as Behaviour;
            if (b == null || b.enabled)
            {
                comp.SendMessage(funcName, SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
    {
        T[] comps = root.GetComponentsInChildren<T>(true);
        for (int i = 0, imax = comps.Length; i < imax; ++i)
        {
            Component comp = comps[i];
            comp.SendMessage(funcName, SendMessageOptions.DontRequireReceiver);
        }
    }

    public static void ImmediatelyCreateDrawCalls(GameObject root)
    {
        UIPanel[] panels = root.GetComponentsInChildren<UIPanel>(true);
        for (int i = 0, imax = panels.Length; i < imax; ++i)
        {
            UIPanel p = panels[i];
            if (p.enabled)
            {
                p.RebuildAllDrawCalls();
            }
        }
    }

    public static string KeyToCaption(KeyCode key)
    {
        switch (key)
        {
            case KeyCode.Alpha0: return "0";
            case KeyCode.Alpha1: return "1";
            case KeyCode.Alpha2: return "2";
            case KeyCode.Alpha3: return "3";
            case KeyCode.Alpha4: return "4";
            case KeyCode.Alpha5: return "5";
            case KeyCode.Alpha6: return "6";
            case KeyCode.Alpha7: return "7";
            case KeyCode.Alpha8: return "8";
            case KeyCode.Alpha9: return "9";
            case KeyCode.UpArrow: return "Up";
            case KeyCode.DownArrow: return "Down";
            case KeyCode.RightArrow: return "Right";
            case KeyCode.LeftArrow: return "Left";
            case KeyCode.Mouse0: return "Left Click";
            case KeyCode.Mouse1: return "Right Click";
            case KeyCode.Mouse2: return "Middle Click";
            default: return key.ToString();
        }
    }

    public static KeyCode CaptionToKey(string caption)
    {
        try
        {
            return (KeyCode)Enum.Parse(typeof(KeyCode), caption, true);
        }
        catch
        {
            return KeyCode.None;
        }
    }

    public static T Draw<T>(string id, OnInitFunc<T> onInit = null) where T : UIWidget
    {
        return null;
    }

    public static Color GammaToLinearSpace(this Color c)
    {
        return new Color(Mathf.GammaToLinearSpace(c.r), Mathf.GammaToLinearSpace(c.g), Mathf.GammaToLinearSpace(c.b), c.a);
    }

    public static Color LinearToGammaSpace(this Color c)
    {
        return new Color(Mathf.LinearToGammaSpace(c.r), Mathf.LinearToGammaSpace(c.g), Mathf.LinearToGammaSpace(c.b), c.a);
    }

    public static bool CheckIfRelated(INGUIAtlas a, INGUIAtlas b)
    {
        if (a == null || b == null) return false;
        if (a == b) return true;
        return false;
    }

    public static void Replace(INGUIAtlas before, INGUIAtlas after)
    {
    }

    public static bool CheckIfRelated(INGUIFont a, INGUIFont b)
    {
        if (a == null || b == null) return false;
        if (a == b) return true;
        return false;
    }
}