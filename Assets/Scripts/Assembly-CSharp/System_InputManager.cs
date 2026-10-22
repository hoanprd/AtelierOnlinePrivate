using System.Runtime.InteropServices;
using UnityEngine;

public class System_InputManager : MonoBehaviour
{
    public enum eTouchID
    {
        First = 0,
        Second = 1,
        Third = 2,
        Fourth = 3,
        EnumMax = 4
    }

    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public struct stFingerLogData
    {
        public bool bTouchFlag;
        public bool bIgnoreFlag;
        public int iPressCount;
        public Vector2 vecPosNow;
        public Vector2 vecPosFirst;

        public void Initialize()
        {
            bTouchFlag = false;
            bIgnoreFlag = false;
            iPressCount = 0;
            vecPosNow = Vector2.zero;
            vecPosFirst = Vector2.zero;
        }

        public Vector2 GetScreenPercent(Vector2 vecTemp)
        {
            return vecTemp;
        }

        public Vector2 GetTouchPos_Now() => vecPosNow;
        public Vector2 GetTouchPos_First() => vecPosFirst;
        public Vector2 GetTouchLength() => vecPosNow - vecPosFirst;
    }

    private static System_InputManager g_scrInst;

    private static readonly int sc_iTouchCountMax = 4;
    private static readonly float sc_fDepthCheck_Max = 100f;
    private static readonly float sc_fAspectRatio_Default = 16f / 9f;

    private static float m_fAspectRatio_Now;
    private static float m_fHeight_MarginPercent;
    private static float m_fHeight_EnablePercent = 1f;
    private static float m_fWidth_MarginPercent;
    private static float m_fWidth_EnablePercent = 1f;

    [SerializeField]
    private stFingerLogData[] m_stFingerLogData = new stFingerLogData[4];

    private int m_iTouchCountNow;
    private int m_iTouchCountLog;

    private void Awake()
    {
        if (g_scrInst != null && g_scrInst != this)
        {
            Destroy(gameObject);
            return;
        }
        g_scrInst = this;
        Initialize();
    }

    public static System_InputManager GetInst()
    {
        return g_scrInst;
    }

    public static Vector2 GetScreenPercent_SubMargin(Vector2 vecPos)
    {
        return vecPos;
    }

    public Vector2 GetScreenPercent_Enable()
    {
        return new Vector2(m_fWidth_EnablePercent, m_fHeight_EnablePercent);
    }

    public Vector2 GetScreenPercent_Margin()
    {
        return new Vector2(m_fWidth_MarginPercent, m_fHeight_MarginPercent);
    }

    public void Initialize()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        m_fAspectRatio_Now = screenHeight / screenWidth;

        if (m_fAspectRatio_Now <= sc_fAspectRatio_Default)
        {
            m_fHeight_MarginPercent = 0f;
            m_fHeight_EnablePercent = 1f;
            float ratio = (sc_fAspectRatio_Default - m_fAspectRatio_Now) / sc_fAspectRatio_Default;
            m_fWidth_MarginPercent = ratio * 0.5f;
            m_fWidth_EnablePercent = 1f - ratio;
        }
        else
        {
            m_fWidth_MarginPercent = 0f;
            m_fWidth_EnablePercent = 1f;
            float ratio = sc_fAspectRatio_Default / m_fAspectRatio_Now;
            m_fHeight_EnablePercent = ratio;
            m_fHeight_MarginPercent = (1f - ratio) * 0.5f;
        }

        if (m_stFingerLogData == null || m_stFingerLogData.Length < sc_iTouchCountMax)
        {
            m_stFingerLogData = new stFingerLogData[sc_iTouchCountMax];
        }

        for (int i = 0; i < sc_iTouchCountMax; i++)
        {
            m_stFingerLogData[i].Initialize();
        }
    }

    private void Update()
    {
        UpdateFingerData();
        UpdateTouchData();
    }

    private void UpdateFingerData()
    {
        m_iTouchCountNow = Input.touchCount;
        for (int i = 0; i < sc_iTouchCountMax; i++)
        {
            if (i < m_stFingerLogData.Length)
            {
                m_stFingerLogData[i].bTouchFlag = false;
            }
        }

#if UNITY_EDITOR || UNITY_STANDALONE
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        {
            m_iTouchCountNow = 1;
            if (m_stFingerLogData.Length > 0)
            {
                m_stFingerLogData[0].bTouchFlag = true;
                m_stFingerLogData[0].vecPosNow = Input.mousePosition;
                if (Input.GetMouseButtonDown(0))
                {
                    m_stFingerLogData[0].vecPosFirst = Input.mousePosition;
                    m_stFingerLogData[0].iPressCount = 1;
                }
            }
        }
#else
        for (int i = 0; i < Input.touchCount && i < sc_iTouchCountMax; i++)
        {
            Touch touch = Input.GetTouch(i);
            m_stFingerLogData[i].bTouchFlag = true;
            m_stFingerLogData[i].vecPosNow = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                m_stFingerLogData[i].vecPosFirst = touch.position;
                m_stFingerLogData[i].iPressCount = 1;
            }
        }
#endif
    }

    private void UpdateTouchData()
    {
        // Cập nhật logic xử lý touch bổ sung nếu cần
    }

    private void MakeTouchEffect(eEffectKind eKind, Vector2 vecPos2D) { }

    private bool IsTouchLogOK(Vector2 vecPos) => true;

    private bool IsLayer_NGUI(int layerId) => false;

    private int GetFingerID(byte iTouchID) => iTouchID;

    public int GetTouchFingerCount() => m_iTouchCountNow;

    public bool IsTouchTrigger()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        return Input.GetMouseButtonDown(0);
#else
        return m_iTouchCountNow > 0;
#endif
    }

    public bool IsTouchTrigger(eTouchID eID)
    {
        int id = (int)eID;
        if (id >= 0 && id < m_stFingerLogData.Length)
        {
            return m_stFingerLogData[id].bTouchFlag;
        }
        return false;
    }

    public bool IsTouchPress(eTouchID eID)
    {
        int id = (int)eID;
        if (id >= 0 && id < m_stFingerLogData.Length)
        {
            return m_stFingerLogData[id].bTouchFlag;
        }
        return false;
    }

    public bool IsTouchOff()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        return Input.GetMouseButtonUp(0);
#else
        return m_iTouchCountNow == 0;
#endif
    }

    private bool IsTouchPos_ReturnOK(eTouchID eID) => true;

    public Vector2 GetTouchPos_First(eTouchID eID)
    {
        int id = (int)eID;
        if (id >= 0 && id < m_stFingerLogData.Length)
        {
            return m_stFingerLogData[id].vecPosFirst;
        }
        return Vector2.zero;
    }

    public Vector2 GetTouchPos_Now(eTouchID eID)
    {
        int id = (int)eID;
        if (id >= 0 && id < m_stFingerLogData.Length)
        {
            return m_stFingerLogData[id].vecPosNow;
        }
        return Vector2.zero;
    }

    public Vector2 GetTouchPos_Moved(eTouchID eID) => Vector2.zero;

    public Vector3 GetTouchPos_3D(eTouchID eID)
    {
        Vector2 pos = GetTouchPos_Now(eID);
        return new Vector3(pos.x, pos.y, 0f);
    }

    public void SetIgnoreAllTouch() { }

    public static void SetMultiTouch(bool bEnable)
    {
        Input.multiTouchEnabled = bEnable;
    }
}