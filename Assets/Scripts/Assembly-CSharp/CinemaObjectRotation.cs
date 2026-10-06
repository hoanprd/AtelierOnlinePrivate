using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class CinemaObjectRotation : MonoBehaviour
{
	public GameObject obj;

	public void Awake()
	{
	}

	public static CinemaObjectRotation Begin(GameObject obj)
	{
		return null;
	}

	public void RotationTo(Vector3 to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator RotationToEX(Quaternion from, Quaternion to, float time)
	{
		return null;
	}

	public void RotationToLock(GameObject to, bool isCamera = false)
	{
	}

	[DebuggerHidden]
	private IEnumerator RotationToEuler(GameObject to, bool isCamera)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator RotationToEuler(Transform to, bool isCamera)
	{
		return null;
	}

	public void RotationTo(Transform to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator RotationToEX(Quaternion from, Transform to, float time)
	{
		return null;
	}

	public void LookAt(Vector3 to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator LookAtEX(Vector3 to, float time)
	{
		return null;
	}

	public void LookAt(Transform to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator LookAtEX(Transform to, float time)
	{
		return null;
	}

	public void LookAtLock(Vector3 to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator LookAtLockEX(Vector3 to, float time)
	{
		return null;
	}

	public void LookAtLock(Transform to, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator LookAtLockEX(Transform to, float time)
	{
		return null;
	}
}
