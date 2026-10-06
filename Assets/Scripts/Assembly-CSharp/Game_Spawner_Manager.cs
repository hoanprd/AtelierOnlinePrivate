using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Game_Spawner_Manager : MonoBehaviour
{
	public enum eMainStep
	{
		Wait = 0,
		LoadList_Init = 1,
		LoadList_Wait = 2,
		Spawn_Init = 3,
		Spawn = 4
	}

	public enum eSpawnerLoad
	{
		None = 0,
		Asset = 1,
		Object = 2
	}

	private static Game_Spawner_Manager m_inst;

	public static readonly int m_spawnDataPosScale;

	private eMainStep m_step;

	private eSpawnerLoad m_loadKind;

	private bool m_setServerData;

	private List<SpawnerData> m_makeSpawnerList;

	private static List<PickupSpot> m_pickupList;

	private static List<GimmickSpot> m_gimmickList;

	private static List<EnemySpot> m_enemyList;

	private static List<NPCSpot> m_npcList;

	private static List<QuestArea> m_questAreaList;

	private static List<QuestNPC> m_questNpcList;

	private int m_createdAreaId;

	private int m_createdStageId;

	private bool m_createdDungeon;

	private bool m_isRepeat;

	private GameObject m_makeSpawnerLog;

	private string m_spawnerListPath;

	private List<string> m_loadAssetPathList;

	private Coroutine m_loadCoroutine;

	public static readonly float m_respawnWaitSec;

	public static readonly float m_respawnWaitSec_Item;

	private static readonly float m_respawnLimit_Min;

	private static readonly float m_respawnLimit_Max;

	private static readonly string[] m_spawnerPrefabNameArray;

	public List<SpawnerData> SpawnerList
	{
		get
		{
			return null;
		}
	}

	public static Game_Spawner_Manager GetInst()
	{
		return null;
	}

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public GameObject GetSpawnerRoot()
	{
		return null;
	}

	public SpawnerData GetSpawnerDataFromPos(int pos, bool searchedOK = true)
	{
		return null;
	}

	public SpawnerData GetSpawnerDataFromNo(int no, eSpawnerKind kind)
	{
		return null;
	}

	public SpawnerData GetSyncGimmickDataFromNo(int no)
	{
		return null;
	}

	public void StartLoadSpawner(int areaId, int stageId)
	{
	}

	public void StartLoadSpawner(int areaId, int stageId, bool dungeon)
	{
	}

	public void SetServerData(FieldData data)
	{
	}

	public List<SpawnerData> MakeSpawnerList(string spawnerListPath)
	{
		return null;
	}

	public static List<SpawnerData> MakeSpawnerList(TextAsset allText)
	{
		return null;
	}

	private void ClearSpawner(string objName)
	{
	}

	public void SearchDungeonSpawner(GameObject root)
	{
	}

	public void LoadNeedAsset()
	{
	}

	public float GetAssetProgress()
	{
		return 0f;
	}

	public void ClearAssetPathList()
	{
	}

	public APIExploreDungeonFloorCreate.Request.PosInfo GetFloorPosInfo()
	{
		return null;
	}

	private string GetAssetPath(eSpawnerKind kind, string optionData)
	{
		return null;
	}

	public void LoadSpawnerList(string spawnerListPath)
	{
	}

	public bool IsEndMakeSpawnerList()
	{
		return false;
	}

	public bool IsEndSpawnerInit()
	{
		return false;
	}

	public bool IsLoadSpawnerList()
	{
		return false;
	}

	public bool IsLoadSpawnerList(string spawnerListPath)
	{
		return false;
	}

	private void StartCoroutine_SpawnerList()
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadSpawnerList()
	{
		return null;
	}

	private void Update()
	{
	}

	private void SetSpawnerNO()
	{
	}

	private void MakePrioritySpawn()
	{
	}

	public void AllSpawn()
	{
	}

	private void CheckSpawn(int makeCount = 1, bool checkDist = true)
	{
	}

	public static string GetSpawnerPrefabName(eSpawnerKind kind)
	{
		return null;
	}

	private void MakeSpawnerObj(SpawnerData tempData)
	{
	}

	private void UpdateSpawner_UnlockArea(SpawnerData data)
	{
	}

	public void UpdateSpawnerList_ControlFlag()
	{
	}

	public PickupSpot GetPickupSpot_Pos(int spotPos)
	{
		return null;
	}

	public PickupSpot GetPickupSpot_No(int spotNo)
	{
		return null;
	}

	public GimmickSpot GetGimmickSpot_Pos(int gimmickPos)
	{
		return null;
	}

	public GimmickSpot GetGimmickSpot_No(int spotNo)
	{
		return null;
	}

	public EnemySpot GetEnemySpot_Pos(int enemyPos)
	{
		return null;
	}

	public EnemySpot GetEnemySpot_No(int spotNo)
	{
		return null;
	}

	public QuestArea GetQuestArea(int areaPos)
	{
		return null;
	}

	public NPCSpot GetNPCSpot_Pos(int npcPos)
	{
		return null;
	}

	public NPCSpot GetNPCSpot_No(int spotNo)
	{
		return null;
	}

	public QuestNPC GetQuestNPC(int areaId, int spotPos)
	{
		return null;
	}

	public bool IsSpawnOK(int no, eSpawnerKind kind)
	{
		return false;
	}

	private void SetLatestPickupSpot(PickupSpot[] spotList)
	{
	}

	private void SetLatestGimmickSpot(GimmickSpot[] spotList)
	{
	}

	private void SetLatestEnemySpot(EnemySpot[] spotList)
	{
	}

	public void UpdateLatestQuest()
	{
	}

	private void SetLatestNPCSpot(NPCSpot[] spotList)
	{
	}

	public void AddEnemySpot(EnemySpot[] spotList)
	{
	}

	public void AddNPCSpot(NPCSpot[] spotList)
	{
	}

	public void UpdatePK(PickupSpot[] updateList)
	{
	}

	private void UpdateSpotPKTime()
	{
	}

	public void UpdatePK(BattleFinish.EnemySpot[] updateList)
	{
	}

	private void UpdateEnemyPKTime()
	{
	}

	public void UpdatePK(NPCSpot[] updateList)
	{
	}

	private void UpdateNPCPKTime()
	{
	}

	public static int GetEnemyCount()
	{
		return 0;
	}

	public static int GetNpcCount()
	{
		return 0;
	}

	public void UpdateAllSpawner(FieldData data)
	{
	}

	[DebuggerHidden]
	public IEnumerator UpdateSpawener(bool fadein = true)
	{
		return null;
	}
}
