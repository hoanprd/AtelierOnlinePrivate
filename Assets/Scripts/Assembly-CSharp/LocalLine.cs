using System;
using UnityEngine;

[Serializable]
public class LocalLine
{
	public Vector3 v1;

	public Vector3 v2;

	private Vector3 GetNearestPointOnLine(Transform root, Vector3 p, bool isSegment = true)
	{
		return default(Vector3);
	}

	public float Distance(Transform root, Vector3 p, bool isSegment = true)
	{
		return 0f;
	}

	public float SqrDistance(Transform root, Vector3 p, bool isSegment = true)
	{
		return 0f;
	}
}
