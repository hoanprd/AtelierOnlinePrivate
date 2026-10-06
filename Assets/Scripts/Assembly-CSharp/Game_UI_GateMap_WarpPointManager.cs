using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_WarpPointManager : MonoBehaviour
{
	private class PosInfo
	{
		public Transform trPos;

		public int iArea;

		public int iUINo;

		public Game_UI_GateMap_WarpPoint scrPoint;

		public QuestCategoryMark scrQuest;

		public GameObject goOption;

		public bool IsMatch(int iArea, int iUINo)
		{
			return false;
		}
	}

	private List<PosInfo> m_clsPosList;

	[SerializeField]
	private Transform m_trWarpPointRoot;

	[SerializeField]
	private Transform m_trOptionRoot;

	[SerializeField]
	private GameObject m_goPointBase;

	[SerializeField]
	private GameObject m_goQuestBase;

	private PosInfo GetPosInfo(int iArea, int iUINo)
	{
		return null;
	}

	private PosInfo GetAcademyPosInfo()
	{
		return null;
	}

	private PosInfo GetAcademyFrontInfo()
	{
		return null;
	}

	private PosInfo GetPosInfo(int iPortalId)
	{
		return null;
	}

	private void UpdateWarpPoint(PosInfo clsPos, GateInfo clsGateInfo)
	{
	}

	private void UpdateQuestMark(PosInfo clsPos, MasterQuestInfo clsMaster)
	{
	}

	public void Init()
	{
	}

	public void MakeObject()
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public void SetActiveName(bool bActive)
	{
	}

	public void KillChild()
	{
	}

	public void SetActiveAllWarpPoint(bool active)
	{
	}

	public void SetActiveAllHardModeWarpPoint(bool active)
	{
	}

	public void ActivateHardModeArea(int areaID)
	{
	}
}
