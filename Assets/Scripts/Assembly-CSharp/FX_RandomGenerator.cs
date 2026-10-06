using UnityEngine;

public class FX_RandomGenerator : MonoBehaviour
{
	public GameObject[] m_prefabObject;

	public int m_prefab_Count;

	public Vector3 m_prefab_Pos_Min;

	public Vector3 m_prefab_Pos_Max;

	public Vector3 m_prefab_Rot_Min;

	public Vector3 m_prefab_Rot_Max;

	public float m_prefab_Scale_Min;

	public float m_prefab_Scale_Max;

	private void Start()
	{
	}

	private void CreateObject_Once()
	{
	}
}
