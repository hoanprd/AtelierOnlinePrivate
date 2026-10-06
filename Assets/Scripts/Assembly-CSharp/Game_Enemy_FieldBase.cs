using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class Game_Enemy_FieldBase : Game_Enemy_Base
{
	protected NavMeshAgent m_agent;

	private bool m_rotateEnd;

	public void StartRotate(float rotY, float rotTime = 0.2f)
	{
	}

	public void StartRotate(Vector3 target, float rotTime = 0.2f)
	{
	}

	[DebuggerHidden]
	public IEnumerator Rotate(Vector3 target, float rotTime = 0.2f)
	{
		return null;
	}

	public bool IsEndRotate()
	{
		return false;
	}

	public Quaternion GetRotation(Vector3 target)
	{
		return default(Quaternion);
	}

	protected void SetAgent()
	{
	}

	public void ResetPath()
	{
	}

	public bool IsEnableAgent(bool checkOnNavMesh = true)
	{
		return false;
	}
}
