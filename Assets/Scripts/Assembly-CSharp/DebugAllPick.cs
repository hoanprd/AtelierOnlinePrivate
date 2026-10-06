using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class DebugAllPick : MonoBehaviour
{
	private class PathData
	{
		public NavMeshPath cPath;

		public Game_Gimmick_Base sGimmick;

		public Game_Animal_ItemDrop sAnimal;

		public float fWay;

		public Vector3 vDestination
		{
			get
			{
				return default(Vector3);
			}
		}

		public PathData(NavMeshPath cPath, Game_Gimmick_Base sGimmick, Game_Animal_ItemDrop sAnimal, Vector3 vPlayerPos)
		{
		}

		public string DebugString()
		{
			return null;
		}
	}

	private Color[] m_tPathColAry;

	private static readonly float sr_fFarDist;

	private Game_Manager m_sGM;

	private Game_Chara_MA_Player m_sPL;

	private List<Game_Gimmick_Base> m_sGimmickList;

	private List<PathData> m_sPathDataList;

	private Coroutine m_cPriSearchCor;

	private List<Game_Gimmick_Base> m_sPriGimmickList;

	private bool m_bBattled;

	private bool m_bUseBomb;

	private int m_iRestNum;

	private List<NavMeshObstacle> m_sObstacleList;

	private List<Collider> m_sDisableList;

	private Action m_dEndCB;

	private PathData sNowData
	{
		get
		{
			return null;
		}
	}

	private Game_Gimmick_Base sNowDestination
	{
		get
		{
			return null;
		}
	}

	private Game_Animal_Base sNowAnimal
	{
		get
		{
			return null;
		}
	}

	private void OnDestroy()
	{
	}

	public void SetUseBomb(bool bUseBomb)
	{
	}

	public string GetDestinationName()
	{
		return null;
	}

	public int GetRestNum()
	{
		return 0;
	}

	public void Kill()
	{
	}

	public void Init(Action dEndCB = null)
	{
	}

	[DebuggerHidden]
	private IEnumerator Exec()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator GetAll()
	{
		return null;
	}

	private bool IsActionOK()
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator Action()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator CalcPath(Vector3 vPos, Action<NavMeshPath> dCb, Vector3 vStartPos = default(Vector3), float fSearchRadius = 0.2f)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator SeachNext()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator PrioritySearch()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator MakePathList(List<Game_Gimmick_Base> sGimList, Action<List<PathData>, List<Game_Gimmick_Base>> dCb, Game_Gimmick_Base sIgnore = null, Vector3 vStartPos = default(Vector3))
	{
		return null;
	}

	private void CountRestNum(bool bUseBomb)
	{
	}

	private static int DistSort(Vector3 vA, Vector3 vB)
	{
		return 0;
	}

	private static int PathSort(PathData cA, PathData cB)
	{
		return 0;
	}
}
