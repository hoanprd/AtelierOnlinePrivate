using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_FacilityManager : MonoBehaviour
{
	private class FacilityPos
	{
		public Transform trPos;

		public int iId;

		public Game_UI_GateMap_Facility sFacility;

		public int iArea;

		public bool IsMatch(int iId)
		{
			return false;
		}
	}

	private List<FacilityPos> m_cPosList;

	[SerializeField]
	private Transform m_trFacilityRoot;

	[SerializeField]
	private GameObject m_goFacilityBase;

	private FacilityPos GetFacilityPos(int iId)
	{
		return null;
	}

	private void MakeObject(MapFacility cFacilityMaster)
	{
	}

	public void Init()
	{
	}

	public void MakeObjectList()
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public void KillChild()
	{
	}

	public void SetActiveAllFacility(bool active)
	{
	}

	public void ActivateAllHardModeFacility()
	{
	}

	public void SetActiveAllHardModeFacility(bool active)
	{
	}

	public void ActivateHardModeFacility(int areaID)
	{
	}
}
