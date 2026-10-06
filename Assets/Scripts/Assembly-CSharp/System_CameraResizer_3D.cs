using UnityEngine;

[ExecuteInEditMode]
public class System_CameraResizer_3D : System_CameraResizer_Base
{
	public enum eCameraKind
	{
		Normal = 0,
		Object = 1,
		Player = 2,
		Filter = 3,
		Light = 4,
		PaperMap = 5,
		RaderMap = 6,
		Battle = 7,
		EnumMax = 8
	}

	protected static readonly int[] sc_iDepthList;

	protected static readonly int[] sc_iLayerMaskList;

	public eCameraKind m_eCameraKind;

	private static Camera m_mainCamera_BA;

	private static Camera m_mainCamera_MA;

	private void Awake()
	{
	}

	public static Camera GetCamera()
	{
		return null;
	}

	public static Camera GetCamera_BA()
	{
		return null;
	}

	protected override void SetCameraInfo()
	{
	}
}
