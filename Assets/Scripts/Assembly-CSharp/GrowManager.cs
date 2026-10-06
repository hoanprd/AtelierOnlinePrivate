using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class GrowManager : MonoBehaviour
{
	public enum eDir
	{
		Climb = 0,
		Fall = 1
	}

	private static readonly float sr_fClimbEndDist;

	private float m_fGrowLength;

	private float m_fClimbDir;

	private Vector3 m_v3UpwardPos;

	private Vector3 m_v3DownwardPos;

	public GameObject m_goTopObj;

	public GameObject m_goPointObj;

	[DebuggerHidden]
	private IEnumerator Grow()
	{
		return null;
	}

	public void SetData(float fLength, float fClimbDir)
	{
	}

	public void OnExplode()
	{
	}

	public Vector3 GetCenterPos()
	{
		return default(Vector3);
	}

	public Vector3 GetUpwardPos()
	{
		return default(Vector3);
	}

	public Vector3 GetDownWardPos()
	{
		return default(Vector3);
	}

	public float GetClimbDir()
	{
		return 0f;
	}
}
