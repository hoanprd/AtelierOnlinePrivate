using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_AreaNameManager : MonoBehaviour
{
	private class NameInfo
	{
		public Transform trPos;

		public int iArea;

		public Game_UI_GateMap_AreaName scrName;

		public bool IsMatch(int iArea)
		{
			return false;
		}
	}

	private List<NameInfo> m_clsPosList;

	[SerializeField]
	private Transform m_trAreaNameRoot;

	[SerializeField]
	private GameObject m_goNameBase;

	private NameInfo GetNameInfo(int iArea)
	{
		return null;
	}

	private void MakeObject(GateInfo clsGateData)
	{
	}

	public void Init()
	{
	}

	public void MakeObjectList()
	{
	}

	public Vector3 GetNamePos(int iAreaId)
	{
		return default(Vector3);
	}

	public void SetActive(bool bActive)
	{
	}

	public void SetActivePin(bool bActive)
	{
	}

	public void KillChild()
	{
	}

	public void SetActiveAllAreaName(bool active)
	{
	}

	public void SetActiveAllHardModeAreaName(bool active)
	{
	}
}
