using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DungeonLocInfo
{
	public string sPrefabName;

	public Vector3 vPosition;

	public Quaternion vRotaion;

	public Vector3 vScale;

	public List<bool> vbDoor;
}
