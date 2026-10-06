using System;
using UnityEngine;

[Serializable]
public class CameraMoveData
{
	public GameObject stalkObj;

	public Vector3 stalkOffset;

	public float targetFoV;

	public CameraMoveData(GameObject obj, Vector3 ofs, float fov = 20f)
	{
	}
}
