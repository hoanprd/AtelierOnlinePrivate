using System;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour
{
	public UnityEngine.Object[] Objects;

	private Dictionary<Type, Dictionary<string, object>> m_scripts;

	public bool IsDestroyed { get; private set; }

	private Dictionary<Type, Dictionary<string, object>> Scripts
	{
		get
		{
			return null;
		}
	}

	protected virtual void OnDestroy()
	{
	}

	public T GetComponentFromName<T>(string key) where T : Component
	{
		return null;
	}

	public void UpdateScriptList<T>() where T : Component
	{
	}

	private Dictionary<string, object> GetScriptList(Type type)
	{
		return null;
	}

	public bool RemoveItems<T>() where T : Component
	{
		return false;
	}

	public UnityEngine.Object GetObject(string name)
	{
		return null;
	}

	public T InstantiatePrefab<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	public GameObject InstantiatePrefab(GameObject parent, string name)
	{
		return null;
	}

	public static GameObject InstantiatePrefab(GameObject parent, GameObject prefab)
	{
		return null;
	}
}
