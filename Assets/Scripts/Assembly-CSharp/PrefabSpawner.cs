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
	}
}
