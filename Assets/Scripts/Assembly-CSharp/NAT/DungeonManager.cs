using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DunGen;
using UnityEngine;
using UnityEngine.AI;

namespace NAT
{
	public class DungeonManager : MonoBehaviour
	{
		public static DungeonManager SharedInstance;

		public NavMeshSurface NavMeshRoot;

		private int m_areaId;

		private int m_stageId;

		private int m_spawnId;

		private Vector3 m_restartPos;

		private static List<DungeonDifficulty> s_difficultyList;

		private static List<DungeonWayPoint> s_wayPointList;

		private static int s_reachedMax;

		private static int s_nowDifficulty;

		private static List<DungeonWayPoint> s_ExWayPointList;

		private GameObject m_dialog;

		private RuntimeDungeon m_generator;

		private bool m_bGenerate;

		public bool IsGenerate
		{
			get
			{
				return false;
			}
		}

		public Vector3 RestartPos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public static int ReachedMax
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int NowDifficulty
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static GameObject DungeonRoot
		{
			get
			{
				return null;
			}
		}

		public static DungeonWayPoint[] ExWayPointList
		{
			get
			{
				return null;
			}
		}

		public static string GetDungeonGeneratorPath(int dungeonId, int flowId)
		{
			return null;
		}

		public static int MakeSeed(int dungeonId, int flowId, bool useDebug)
		{
			return 0;
		}

		[DebuggerHidden]
		public IEnumerator Generate(int dungeonId, int flowId, int seed = 0)
		{
			return null;
		}

		public void KillDungeon()
		{
		}

		public void Init()
		{
		}

		public void Init(int seed)
		{
		}

		public void EnterDungeon(int dungeonID, int floor = 1)
		{
		}

		public void EnterDungeon(int areaId, int stageId, int spawnId, int dungeonID, int floor)
		{
		}

		public void GoNextFloor()
		{
		}

		public void ClearedDungeon()
		{
		}

		public void ExitDungeon()
		{
		}

		public void ExitDungeon(int areaId, int stageId, int spawnId, bool dialog)
		{
		}

		private void Awake()
		{
		}

		private void OnGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
		{
		}

		public bool IsPathOK()
		{
			return false;
		}

		public Vector3 GetGoalPos(bool edge = false)
		{
			return default(Vector3);
		}

		private void CreateNextFloorDialog()
		{
		}

		private void OnFloorDialog(DungeonFloorMoveDialog.eButton result, int otherFloor)
		{
		}

		private void OnDungeonExitDialog(EButtonKind result)
		{
		}

		private void OnDungeonClearedDialog(EButtonKind result)
		{
		}

		public static void SetDifficultyInfo(DungeonDifficulty[] array)
		{
		}

		public static DungeonDifficulty GetDifficulty(int diff)
		{
			return null;
		}

		public static void SetUnlockDifficulty(DungeonUnlock[] array)
		{
		}

		public static bool IsUnlockDifficulty(int diff)
		{
			return false;
		}

		public static void SetUnlockWayPoint(DungeonWayPoint[] array)
		{
		}

		public static void SetUnlockWayPoint(DungeonWayPoint point)
		{
		}

		public static bool IsUnlockWayPoint(int floor)
		{
			return false;
		}

		public static void InitExWayPoint()
		{
		}

		public static void SetUnlockExWayPoint(DungeonWayPoint point)
		{
		}
	}
}
