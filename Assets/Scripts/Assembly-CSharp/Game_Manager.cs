using System;
using System.Collections.Generic;
using ADV;
using UnityEngine;

public class Game_Manager : Menu_Base
{
	public enum eBattleAfter
	{
		None = 0,
		Restart_Host = 1,
		Restart_Guest = 2,
		Advent = 3
	}

	public enum eMainStep
	{
		Friend_Init = 0,
		Friend_Wait = 1,
		QuestSummary_Init = 2,
		QuestSummary_Wait = 3,
		LoadFieldAsset_Init = 4,
		LoadFieldAsset_Wait = 5,
		DownloadLoadAsset_Init = 6,
		DownloadLoadAsset_Wait = 7,
		DisconnectPhoton_Init = 8,
		DisconnectPhoton_Wait = 9,
		ConnectPhoton_Init = 10,
		ConnectPhoton_Wait = 11,
		First_Init = 12,
		First_Wait = 13,
		CreateRoom_Init = 14,
		CreateRoom_Wait = 15,
		SetRoomIndex_Init = 16,
		SetRoomIndex_Wait = 17,
		APIFieldEnter_Init = 18,
		APIFieldEnter_Wait = 19,
		MakeField_Init = 20,
		MakeField_Wait = 21,
		LoadSpawnerList_Init = 22,
		LoadSpawnerList_Wait = 23,
		LoadSpawnerAsset_Init = 24,
		LoadSpawnerAsset_Wait = 25,
		Inventory_Init = 26,
		Inventory_Wait = 27,
		AreaTitle_Init = 28,
		AreaTitle_Wait = 29,
		AreaTitle_FadeO_Init = 30,
		AreaTitle_FadeO_Wait = 31,
		FadeI_Init = 32,
		FadeI_Wait = 33,
		ControlWait_Init = 34,
		ControlWait_Wait = 35,
		FadeO_Init = 36,
		FadeO_Wait = 37,
		LeaveRoom_Init = 38,
		LeaveRoom_Wait = 39,
		ClearField_Init = 40,
		ClearField_Wait = 41,
		ChangeMenu = 42,
		SameAreaWarp_Init_Init = 43,
		QuestSummary_Town_Init = 44,
		QuestSummary_Town_Wait = 45,
		APIFieldReload_Init = 46,
		APIFieldReload_Wait = 47,
		SameAreaWarp_Init = 48,
		SameAreaWarp_Wait = 49,
		LoadSpawnerList_Warp_Init = 50,
		LoadSpawnerList_Warp_Wait = 51,
		End = 52
	}

	private enum eAreaStep
	{
		First = 0,
		FadeI_Init = 1,
		FadeI_Wait = 2,
		FadeI_B_Init = 3,
		FadeI_B_Wait = 4,
		DispAnyInfo_Init = 5,
		DispAnyInfo_Wait = 6,
		Tutorial_Init = 7,
		Tutorial_Wait = 8,
		AreaNameText_Init = 9,
		AreaNameText_Wait = 10,
		ControlWait_Init = 11,
		ControlWait_Wait = 12,
		FadeO_Init = 13,
		FadeO_Wait = 14,
		FadeO_B_Init = 15,
		FadeO_B_Wait = 16,
		Restart_Init = 17,
		Restart_Wait = 18,
		RestartTalk_Init = 19,
		RestartTalk_Wait = 20,
		ChangeDate_Init = 21,
		ChangeDate_Wait = 22,
		DateUpdate_Init = 23,
		DateUpdate_Wait = 24,
		End = 25
	}

	private enum eAreaLoadProgress
	{
		FieldAsset = 0,
		BattleAsset = 1,
		ConnectPhoton = 2,
		JoinRoom = 3,
		SetRoomIndex = 4,
		CreateField = 5,
		SpawnerList = 6,
		SpawnerAsset = 7,
		MakePlayer = 8,
		EnumMax = 9
	}

	private enum eChangeStageProgress
	{
		FieldReload = 0,
		CreateField = 1,
		SpawnerList = 2,
		SpawnerAsset = 3,
		MakePlayer = 4,
		EnumMax = 5
	}

	private static Game_Manager m_inst;

	private static readonly float[] m_areaLoadProgPer;

	private static readonly float[] m_changeStageProgPer;

	private static readonly string[,] m_LoadingTexts;

	public int m_DEBUG_initMap_WorldId;

	public int m_DEBUG_initMap_StageId;

	public GameObject FilterRoot;

	private static readonly int s_reEnterMax;

	private eMainStep m_eMainStep;

	private GameObject m_areaChangeFadeObj;

	private Material m_areaChangeFadeMaterial;

	private Vector3 m_areaChangeFadeScale;

	private eAreaKind m_areaKind_Now;

	private eAreaKind m_areaKind_Req;

	private eAreaKind m_areaKind_Log;

	private eAreaStep m_areaStep;

	private bool m_subStep_FirstFlag;

	private float m_waitSec_Now;

	private float m_waitSec_Max;

	private AssetDownloader m_assetDownloader;

	private List<GameObject> m_areaChangeDestroyList;

	private List<GameObject> m_encountEnemyObjList;

	private List<EncountEnemyData> m_encountEnemyDataList;

	private bool m_isFirstAttack;

	private bool m_mapArea_MoveOKFlag;

	private int m_recentMusicId_MapArea;

	private System_MenuManager.eSystemMenuKind m_eNextMenuKind;

	private FieldName m_areaNameReq;

	private bool m_isNetworkEnd;

	private bool m_isAPIError;

	private bool m_isEndErrorDialog;

	private bool m_isReEnter;

	private int m_reEnterCount;

	private int m_reCreateRoomCount;

	private eBattleAfter m_battleAfter;

	private bool m_isChangeDate;

	private eTutorial m_execedTutorial;

	private bool m_isEndDialog;

	private bool m_isFieldDungeon;

	private List<KeyValuePair<ETargetObj, int>> m_destroyReserveList;

	private FieldData m_fe2Response;

	private bool m_isChangeStage;

	private DateTime m_sEndTime_FairyP;

	private bool m_isPlayAreaTitle;

	private List<string> m_loadAssetPathList;

	private List<VersionData> m_loadAssetDataList;

	private bool m_isReturnAcademy;

	private bool m_isPauseStep;

	public bool m_isExqOwnerRoomCreateEnd;

	public bool IsFilter
	{
		set
		{
		}
	}

	public Game_Sunlight_FilterManager Filter
	{
		get
		{
			return null;
		}
	}

	public static int AreaID
	{
		get
		{
			return 0;
		}
	}

	public static int AreaID_Log
	{
		get
		{
			return 0;
		}
	}

	public static int StageID
	{
		get
		{
			return 0;
		}
	}

	public static int SpawnID
	{
		get
		{
			return 0;
		}
	}

	public static bool IsFairyArea
	{
		get
		{
			return false;
		}
	}

	public static bool IsCanusArea
	{
		get
		{
			return false;
		}
	}

	public static bool IsHardModeArea
	{
		get
		{
			return false;
		}
	}

	public static eMusicID NormalBattleBGM
	{
		get
		{
			return eMusicID.Title;
		}
	}

	public bool IsFairyPowder
	{
		get
		{
			return false;
		}
	}

	public DateTime EndTime_FairyP
	{
		get
		{
			return default(DateTime);
		}
	}

	public Vector3 ExGateFrontPos { get; set; }

	public float ExGateFrontRotationY { get; set; }

	public int ExGateAreaID { get; set; }

	public int ExGateStageID { get; set; }

	private bool isExtraQuest
	{
		get
		{
			return false;
		}
	}

	private string strExqRoomName
	{
		get
		{
			return null;
		}
	}

	public static Game_Manager GetInst()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public Transform GetRootTransform()
	{
		return null;
	}

	protected override void MenuUpdate()
	{
	}

	private float GetLoadProgress(eAreaLoadProgress kind, float insideProgress)
	{
		return 0f;
	}

	private float GetLoadProgress(eChangeStageProgress kind, float insideProgress)
	{
		return 0f;
	}

	private float GetLoadProgress(float prevProgressMax, float nowProgressMax, float insideProgress)
	{
		return 0f;
	}

	private void Friend_Init()
	{
	}

	private void OnAPI_FriendList(FriendInfoResponse res)
	{
	}

	private void QuestSummary_Init()
	{
	}

	private void OnAPI_QuestSummary(QuestSummaryResponse res)
	{
	}

	private void LoadFieldAsset_Init()
	{
	}

	private bool LoadFieldAsset_Wait()
	{
		return false;
	}

	private eMainStep DownloadLoadAsset_Init()
	{
		return eMainStep.Friend_Init;
	}

	private bool DownloadLoadAsset_Wait()
	{
		return false;
	}

	private eMainStep DisconnectPhoton_Init()
	{
		return eMainStep.Friend_Init;
	}

	private void OnDisconnectPhoton(bool success, string message)
	{
	}

	private void ConnectPhoton_Init()
	{
	}

	private void OnConnectPhoton(bool success, string message)
	{
	}

	private bool ConnectPhoton_Wait()
	{
		return false;
	}

	private void First_Init()
	{
	}

	private void OnJoinLobby(bool success, string message)
	{
	}

	private void OnPhotonFailedDialog(EButtonKind result)
	{
	}

	private void OnRoomEnter(bool success, string message)
	{
	}

	private void FailedRoomDialog()
	{
	}

	private bool First_Wait()
	{
		return false;
	}

	private void CreateRoom_Init()
	{
	}

	private void OnAPI_CreateRoom(ExploreRoomCreateResponse res)
	{
	}

	private bool SetRoomIndex_Wait()
	{
		return false;
	}

	private void APIFieldEnter_Init()
	{
	}

	private void OnAPI_FieldEnter(FieldEnter2Response res)
	{
	}

	private void MakeField_Init()
	{
	}

	private bool MakeField_Wait()
	{
		return false;
	}

	private void LoadSpawnerList_Init()
	{
	}

	private bool LoadSpawnerList_Wait()
	{
		return false;
	}

	private void LoadSpawnerAsset_Init()
	{
	}

	private bool LoadSpawnerAsset_Wait()
	{
		return false;
	}

	private bool Inventory_Wait()
	{
		return false;
	}

	private eMainStep AreaTitle_Init()
	{
		return eMainStep.Friend_Init;
	}

	private bool AreaTitle_Wait()
	{
		return false;
	}

	private bool AreaTitle_FadeO_Wait()
	{
		return false;
	}

	private void FadeI_Init()
	{
	}

	private bool FadeI_Wait()
	{
		return false;
	}

	private void FadeO_Init()
	{
	}

	private bool FadeO_Wait()
	{
		return false;
	}

	private void LeaveRoom_Init()
	{
	}

	private void OnAPI_RoomExit(ResponseDataCommon common)
	{
	}

	private void ClearField_Init()
	{
	}

	private bool ClearField_Wait()
	{
		return false;
	}

	private void ChangeMenu()
	{
	}

	private eMainStep SameAreaWarp_Init_Init()
	{
		return eMainStep.Friend_Init;
	}

	private void QuestSummary_Town_Init()
	{
	}

	private void APIFieldReload_Init()
	{
	}

	private void OnAPI_FieldReload(FieldReloadResponse res)
	{
	}

	private void OnAPI_FieldReload_Town(FieldReloadResponse res)
	{
	}

	private bool APIFieldReload_Wait()
	{
		return false;
	}

	private void SameAreaWarp_Init()
	{
	}

	private bool SameAreaWarp_Wait()
	{
		return false;
	}

	private void LoadSpawnerList_Warp_Init()
	{
	}

	private bool LoadSpawnerList_Warp_Wait()
	{
		return false;
	}

	public void UpdateHealItemCount()
	{
	}

	private void ResetSystemFunc(bool bgmStop = true)
	{
	}

	protected virtual void SameAreaWarp()
	{
	}

	protected virtual void MakeFirstObject(FieldData data)
	{
	}

	public void Sunlight_Init()
	{
	}

	public bool IsMoveOK()
	{
		return false;
	}

	public void SetMoveOKFlag(bool enableFlag)
	{
	}

	public bool GetMoveOKFlag()
	{
		return false;
	}

	public bool IsBattleOK(bool friendcheck = false)
	{
		return false;
	}

	public bool IsAutoPickOnOK()
	{
		return false;
	}

	public bool IsAreaTitle()
	{
		return false;
	}

	private void ControlWait_Init()
	{
	}

	private bool ControlWait_Wait()
	{
		return false;
	}

	public eAreaKind GetAreaKind()
	{
		return eAreaKind.MapArea;
	}

	public void SetAreaChangeReq(eAreaKind req)
	{
	}

	private bool IsNextSameField()
	{
		return false;
	}

	public List<EncountEnemyData> GetEncountEnemyList()
	{
		return null;
	}

	public bool IsFirstAttack()
	{
		return false;
	}

	public void SetBattleResult(bool killed)
	{
	}

	private void SetAreaChangeFade(bool forward, float percent)
	{
	}

	private void FadeOut(bool text = false)
	{
	}

	private void SetFieldBGM(bool enable)
	{
	}

	private void ClearDestroyObjList()
	{
	}

	public void AddDestroyObjList(GameObject tempObj)
	{
	}

	public void SetGameOver()
	{
	}

	public void SetGameOverJoin()
	{
	}

	public void SetAdventBattle()
	{
	}

	public eBattleAfter GetBattleAfter()
	{
		return eBattleAfter.None;
	}

	public eMainStep GetNowMainStep()
	{
		return eMainStep.Friend_Init;
	}

	public bool IsRejoinOK()
	{
		return false;
	}

	public void ForceReturnAcademy(string message = "")
	{
	}

	public void SetPauseStep(bool pause)
	{
	}

	public eAreaKind GetNowAreaKind()
	{
		return eAreaKind.MapArea;
	}

	public bool IsBattleNowOrWill()
	{
		return false;
	}

	private List<eTutorial> GetTutorialRequestList()
	{
		return null;
	}

	public void ReserveDestroyADVObj(ETargetObj kind, int targetId)
	{
	}

	public bool IsGetFriendInfo()
	{
		return false;
	}

	public bool IsMakePlayer()
	{
		return false;
	}

	public void UseFairyPowder(string endTime)
	{
	}

	public void PrintDebug()
	{
	}
}
