using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class System_CameraResizer_NGUI : System_CameraResizer_Base
{
	private static Camera g_camCameraNGUI;

	public static Camera GetCamera()
	{
		if (g_camCameraNGUI == null)
		{
			GameObject go = null;
			try
			{
				go = GameObject.FindGameObjectWithTag("NGUI");
			}
			catch
			{
				go = null;
			}
			if (go != null)
			{
				System_CameraResizer_NGUI resizer = go.GetComponent<System_CameraResizer_NGUI>();
				if (resizer != null)
				{
					g_camCameraNGUI = resizer.gameObject.GetComponent<Camera>();
				}
			}
			if (g_camCameraNGUI == null)
			{
				System_CameraResizer_NGUI fallback = Object.FindAnyObjectByType<System_CameraResizer_NGUI>();
				if (fallback != null)
				{
					g_camCameraNGUI = fallback.GetComponent<Camera>();
				}
			}
		}
		return g_camCameraNGUI;
	}
}
