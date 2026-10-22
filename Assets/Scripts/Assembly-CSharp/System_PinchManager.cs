using UnityEngine;

public class System_PinchManager : SingletonBase<System_PinchManager>
{
    private bool m_bPinch;

    public float m_fBeganDist { get; private set; }
    public float m_fPrevDist { get; private set; }
    public float m_fNowDist { get; private set; }

    private void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        // Giả lập Pinch trên Editor/PC bằng cách giữ phím Ctrl + Cuộn chuột (Mouse ScrollWheel)
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (Mathf.Abs(scroll) > 0.01f)
            {
                m_bPinch = true;
                if (m_fBeganDist == 0f) m_fBeganDist = 100f;
                m_fPrevDist = m_fNowDist == 0f ? 100f : m_fNowDist;
                m_fNowDist += scroll * 100f;
                if (m_fNowDist < 10f) m_fNowDist = 10f;
                return;
            }
        }
        m_bPinch = false;
        m_fBeganDist = 0f;
        m_fPrevDist = 0f;
        m_fNowDist = 0f;
#else
        // Logic chuẩn trên Mobile (2 ngón tay) khớp với Ghidra decompile
        int touchCount = Input.touchCount;
        m_bPinch = touchCount > 1;

        if (m_bPinch)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            float currentDist = Vector2.Distance(touch0.position, touch1.position);

            if (m_fBeganDist == 0f)
            {
                m_fBeganDist = currentDist;
                m_fPrevDist = currentDist;
                m_fNowDist = currentDist;
            }
            else
            {
                m_fPrevDist = m_fNowDist;
                m_fNowDist = currentDist;
            }
        }
        else
        {
            m_fBeganDist = 0f;
            m_fPrevDist = 0f;
            m_fNowDist = 0f;
        }
#endif
    }

    public bool IsPinch()
    {
        return m_bPinch;
    }

    public float GetPinchPer_Began()
    {
        if (m_fBeganDist == 0f) return 1f;
        return m_fNowDist / m_fBeganDist;
    }

    public float GetPinchPer_Prev()
    {
        if (m_fPrevDist == 0f) return 1f;
        return m_fNowDist / m_fPrevDist;
    }

    public void ResetBeganDist()
    {
        m_fBeganDist = m_fNowDist;
    }
}