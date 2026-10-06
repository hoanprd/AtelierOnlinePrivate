using System;
using System.Collections.Generic;
using UnityEngine;

public class SpringColliderParam : ScriptableObject
{
	[Serializable]
	public class Param
	{
		public string nodeName;

		public float radius;
	}

	public List<Param> param;
}
