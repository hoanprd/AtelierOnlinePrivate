using System;
using System.Collections.Generic;
using UnityEngine;

public class SpringBoneParam : ScriptableObject
{
	[Serializable]
	public class Param
	{
		public string nodeName;

		public float radius;

		public float dragForce;

		public float stiffness;

		public string[] collisionName;

		public Vector3 springForce;
	}

	public List<Param> param;
}
