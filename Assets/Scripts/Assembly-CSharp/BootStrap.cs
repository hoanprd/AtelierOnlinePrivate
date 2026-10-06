using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
	[SerializeField]
	private GameObject _parent;

	[SerializeField]
	private List<GameObject> _children;

	public void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator InstantiateCoroutine()
	{
		return null;
	}

	private GameObject InstantiateWithSpeedMeasurement(GameObject original, Transform parent = null)
	{
		return null;
	}
}
