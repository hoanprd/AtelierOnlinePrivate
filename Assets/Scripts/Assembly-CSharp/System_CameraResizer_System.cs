using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class System_CameraResizer_System : System_CameraResizer_Base
{
	private static Camera g_camCameraSystem;

	public System_CameraResizer_System()
	{
		m_vecTargetRate = new Vector2(960f, 640f);
	}

	public static Camera GetCamera()
	{
		if (g_camCameraSystem == null)
		{
			System_CameraResizer_System found = Object.FindAnyObjectByType<System_CameraResizer_System>();
			if (found != null)
			{
				g_camCameraSystem = found.gameObject.GetComponent<Camera>();
			}
		}
		return g_camCameraSystem;
	}
}
