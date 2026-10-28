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
		if (m_goInstance != null)
		{
			UnityEngine.Object.Destroy(m_goInstance);
			m_goInstance = null;
		}
	}

	public void Create(bool active = true)
	{
		if (m_goInstance == null && m_goPrefab != null)
		{
			if (m_trRoot == null && Game_UI_Common.Instance != null)
			{
				m_trRoot = Game_UI_Common.Instance.m_trCancelEnableRoot;
			}
			m_goInstance = Util.InstantiateInChildren(m_goPrefab, m_trRoot, false, false, false);
			if (m_goInstance != null)
			{
				m_goInstance.SetActive(active);
			}
		}
	}

	public T GetObject<T>()
	{
		Create(true);
		if (m_goInstance != null)
		{
			return m_goInstance.GetComponent<T>();
		}
		return default(T);
	}
}
