using System.Collections.Generic;
using UnityEngine;

public class EquipJobList : MonoBehaviour
{
	[SerializeField]
	private UISprite m_sMarkPrefab;

	[SerializeField]
	private UIGrid m_sGrid;

	private List<UISprite> m_vMarkList;

	public void Init(List<EJobKind> jobList)
	{
	}
}
