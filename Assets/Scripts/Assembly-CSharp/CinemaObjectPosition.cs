using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class CinemaObjectPosition : MonoBehaviour
{
	public GameObject obj;

	private Transform m_CameraFrom;

	private Transform m_CameraTarg;

	private bool cameraFlag;

	private bool cameraLatterFlag;

	public void Awake()
	{
	}

	public static CinemaObjectPosition Begin(GameObject obj)
	{
		return null;
	}

	public void PositionLock(Vector3 to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator PositionLockEX(Vector3 to, float time)
	{
		return null;
	}

	public void CameraLock(Transform from, Transform targ)
	{
	}

	public void CameraLockLatter()
	{
	}

	private void LateUpdate()
	{
	}

	public void PositionLock(Transform to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator PositionLockEX(Transform to, float time)
	{
		return null;
	}

	public void MoveTo(Vector3 to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator MoveToEX(Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	public void MoveTo(Transform to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator MoveToEX(Vector3 from, Transform to, float time)
	{
		return null;
	}
}
