using UnityEngine;

public class UIBackground : MonoBehaviour
{
    public int m_iDepth;
    private UIWidget m_sWidget;
    private UIPanel m_sPanel;
    private bool m_bQuitting;

    public void SetEnable(bool sw)
    {
        enabled = sw;
    }

    private void Awake()
    {
        m_sWidget = GetComponent<UIWidget>();
        m_sPanel = GetComponent<UIPanel>();
    }

    private void OnEnable()
    {
        if (UIBackgroundManager.Instance != null)
        {
            UIBackgroundManager.Instance.Add(this);
        }
    }

    private void OnDisable()
    {
        if (!m_bQuitting && UIBackgroundManager.Instance != null)
        {
            UIBackgroundManager.Instance.Remove(this);
        }
    }

    private void OnApplicationQuit()
    {
        m_bQuitting = true;
    }
}