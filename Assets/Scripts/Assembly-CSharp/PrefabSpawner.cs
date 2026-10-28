using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
	public Transform m_trRoot;

	public GameObject m_goPrefab;

	public bool m_bActive;

	public bool m_bOriginalSize;

	public bool m_bOriginalPosition;

	public bool m_bChangeLayer;

	private void Awake()
	{
		if (m_goPrefab != null)
		{
			GameObject go = Util.InstantiateInChildren(m_goPrefab, m_trRoot, m_bOriginalSize, m_bOriginalPosition, m_bChangeLayer);
			if (go != null)
			{
				go.SetActive(m_bActive);
			}
		}
		Destroy(this);
	}
}
