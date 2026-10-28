using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class System_CameraResizer_Base : MonoBehaviour
{
	protected static readonly int sc_iLayerMask_Default = -1;

	protected static readonly int sc_iLayerMask_System = 1 << 30;

	protected static readonly float sc_fOrchoSize_Default = 1f;

	protected Vector2 m_vecTargetRate = new Vector2(960f, 640f);

	private void Start()
	{
		switch (System_Resolution_Manager.GetRatioKind())
		{
		case System_Resolution_Manager.eDisplayRatioKind.Ratio_3_2:
			m_vecTargetRate = new Vector2(960f, 640f);
			break;
		case System_Resolution_Manager.eDisplayRatioKind.Ratio_4_3:
			m_vecTargetRate = new Vector2(1280f, 960f);
			break;
		case System_Resolution_Manager.eDisplayRatioKind.Ratio_16_9:
			m_vecTargetRate = new Vector2(1600f, 900f);
			break;
		case System_Resolution_Manager.eDisplayRatioKind.Ratio_2_1:
			m_vecTargetRate = new Vector2(2000f, 1000f);
			break;
		}
		Initialize();
		SetCameraInfo();
		SetCameraRect();
	}

	protected virtual void Initialize()
	{
	}

	protected virtual void SetCameraInfo()
	{
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
