using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class System_CameraResizer_Base : MonoBehaviour
{
    protected static readonly int sc_iLayerMask_Default;

    protected static readonly int sc_iLayerMask_System;

    protected static readonly float sc_fOrchoSize_Default = 1f;

    protected Vector2 m_vecTargetRate = new Vector2(1280f, 720f);

    private void Start()
    {
        Initialize();
        SetCameraInfo();
        SetCameraRect();
    }

    protected virtual void Initialize()
    {
        // Logic khởi tạo cơ sở cho camera resizer
    }

    protected virtual void SetCameraInfo()
    {
        Camera cam = GetComponent<Camera>();
        if (cam != null)
        {
            cam.orthographic = true;
            cam.orthographicSize = sc_fOrchoSize_Default;
        }
    }

    protected void SetCameraRect()
    {
        Camera cam = GetComponent<Camera>();
        if (cam != null)
        {
            cam.rect = new Rect(0f, 0f, 1f, 1f);
        }
    }
}