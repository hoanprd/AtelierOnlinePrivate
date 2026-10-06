using UnityEngine;

[ExecuteInEditMode]
public class System_CameraResizer_Base : MonoBehaviour
{
	protected static readonly int sc_iLayerMask_Default;

	protected static readonly int sc_iLayerMask_System;

	protected static readonly float sc_fOrchoSize_Default;

	protected Vector2 m_vecTargetRate;

	private void Start()
	{
	}

	protected virtual void Initialize()
	{
	}

	protected virtual void SetCameraInfo()
	{
	}

	protected void SetCameraRect()
	{
	}
}
