using System;
using UnityEngine;

[Serializable]
public class SpawnPrefabData
{
	public GameObject m_goPrefab;

	public Transform m_trRoot;

	private GameObject m_goInstance;

	public void ReleaseInstance()
	{
	}

	public void Create(bool active = true)
	{
	}

	public T GetObject<T>()
	{
		return default(T);
	}
}
