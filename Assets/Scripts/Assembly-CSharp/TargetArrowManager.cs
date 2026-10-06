using System.Collections.Generic;
using UnityEngine;

public class TargetArrowManager : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goPrefab;

	private List<TargetArrow> m_vObjectList;

	private void Awake()
	{
	}

	public void Add(int id, Vector3 pos, float distance = 2f)
	{
	}

	public void Add(int id, GameObject target, float angle, float distance)
	{
	}

	public void Remove(int id)
	{
	}

	public void SetActive(int id, bool active)
	{
	}
}
