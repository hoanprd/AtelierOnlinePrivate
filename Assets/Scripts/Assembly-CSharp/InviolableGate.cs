using UnityEngine;
using UnityEngine.AI;

public class InviolableGate : MonoBehaviour
{
	[SerializeField]
	private GameObject m_FirePillar;

	[SerializeField]
	private NavMeshObstacle m_NavMeshObstacle;

	[SerializeField]
	private Transform m_tfEffectRoot;

	[SerializeField]
	private Vector3 effectScale;

	[SerializeField]
	[Multiline]
	private string setumei;

	private void Start()
	{
	}

	private void CreateFireWall()
	{
	}
}
