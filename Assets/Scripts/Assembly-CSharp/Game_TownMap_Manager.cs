using System.Collections.Generic;
using Town;
using UnityEngine;

public class Game_TownMap_Manager : MonoBehaviour
{
	private enum eMainStep
	{
		Wait = 0,
		TownInfo_Init = 1,
		TownInfo_Wait = 2,
		QuestFill_Init = 3,
		QuestFill_Wait = 4,
		QuestSummary_Init = 5,
		QuestSummary_Wait = 6,
		LoadAsset_Init = 7,
		LoadAsset_Wait = 8,
		MakeTown = 9,
		QuestAchieve_Init = 10,
		QuestAchieve_Wait = 11,
		Controll_Init = 12,
		Controll_Wait = 13,
		Talk_Init = 14,
		Talk_Wait = 15,
		QuestBoard_Init = 16,
		QuestBoard_Init_Wait = 17,
		QuestBoard_Wait = 18,
		QuestBoard_TownInfo_Init = 19,
		QuestBoard_TownInfo_Wait = 20,
		QuestSummaryUpdate_Init = 21,
		QuestSummaryUpdate_Wait = 22,
		FadeO_Init = 23,
		FadeO_Wait = 24,
		UpdateNPC = 25,
		FadeI_Init = 26,
		FadeI_Wait = 27,
		Shop_Init = 28,
		Shop_Wait = 29,
		INN_Init = 30,
		INN_Wait = 31,
		GateInfo_Init = 32,
		GateInfo_Wait = 33,
		InventoryOver_Init = 34,
		InventoryOver_Wait = 35,
		Out_Init = 36,
		Out_Wait = 37,
		Last_Init = 38,
		Last_Wait = 39,
		EnumMax = 40
	}

	private static Game_TownMap_Manager s_Instance;

	private static VillageInfo m_villageInfo;

	private eMainStep m_mainStep;

	private float m_waitSec_Now;

	private float m_waitSec_In;

	private float m_waitSec_Out;

	private GameObject m_townMapObj;

	private Transform m_nguiRoot;

	private GameObject m_spotRoot;

	private List<GameObject> m_nguiMarkArray;

	private AnimationController m_inoutAnim;

	private TownInfo m_townMaster;

	private QuestWindow m_questBoard;

	private bool m_apiEnd;

	private List<Game_PaperMap_SpotData> m_spotList;

	private List<QuestDetail> m_questList;

	private List<QuestDetail> m_questList_Log;

	private Game_TownMap_Talk m_talkScr;

	private List<string> m_assetList;

	private bool m_inventoryOver;

	private bool m_dialogEnd;

	private EButtonKind m_dialogResult;

	private AreaNameText m_areaName;

	private bool m_goShopFromQuest;

	private bool m_openShop;

	public Game_UI_Town_Manager m_uiManager;

	[SerializeField]
	private SpawnPrefabData m_sShop;

	[SerializeField]
	private GameObject m_areaNamePrefab;

	private const int m_townMapId_None = -1;

	private static int m_townMapId_Req;

	private static readonly int m_clickedSpotId_None;

	private static int m_clickedSpotId_Req;

	private static eSpot m_clickedSpotKind_Req;

	private static readonly int[] m_atlasIndex;

	public static Game_TownMap_Manager Instance
	{
		get
		{
			return null;
		}
	}

	public static void SetTownId(int townMapId = -1)
	{
	}

	public static int GetTownId()
	{
		return 0;
	}

	public static void SetJumpSpotId(int spotId, eSpot spotKind)
	{
	}

	public static string GetBGAssetPath(int townId)
	{
		return null;
	}

	public static string GetSpotDataAssetPath(int townId)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public bool IsFadeInOK()
	{
		return false;
	}

	public void Init()
	{
	}

	private void Update()
	{
	}

	private void SetDrawNgui(bool flag)
	{
	}

	private void OnAPI_VillageInfo(VillageInfoResponse clsRes)
	{
	}

	private static VillageInfo GetAPIRes()
	{
		return null;
	}

	private void OnAPI_QuestFill(ResponseDataCommon res)
	{
	}

	private void OnAPI_QuestSummary(QuestSummaryResponse res)
	{
	}

	private void OnAPI_VillageInfo_QuestBoard(VillageInfoResponse clsRes)
	{
	}

	private void OnAPI_GateInfo(GateInfoResponse res)
	{
	}

	private void OnDialog_InventoryOver(EButtonKind result)
	{
	}

	private void LoadAsset_Init()
	{
	}

	private void MakeTownMap()
	{
	}

	public void ClearTownMap(bool withQuestList)
	{
	}

	private void MakeSpot(List<QuestDetail> questList)
	{
	}

	private bool UpdateQuest(List<QuestDetail> questList, List<QuestDetail> questList_Log)
	{
		return false;
	}

	private void UpdateNPC()
	{
	}

	private void InitReq()
	{
	}

	private void ADV_Init()
	{
	}

	private void QuestBoard_Init()
	{
	}

	private void OnAPI_QuestSummary_Board(QuestSummaryResponse res)
	{
	}

	private void OnCloseQuest(bool update, int presentNum, bool gotoShop)
	{
	}

	private void Last_Init()
	{
	}

	private void End()
	{
	}

	public void OnOpenShop()
	{
	}

	private void OnCloseShop(bool dispBadge)
	{
	}
}
