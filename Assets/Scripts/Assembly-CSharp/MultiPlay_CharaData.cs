using System.Collections.Generic;
using UnityEngine;

public class MultiPlay_CharaData : PhotonView_SyncData
{
	public enum eCharaAccess
	{
		Leave = 0,
		Dungeon = 1,
		Battle = 2,
		EnumMax = 3
	}

	public bool IsUpdateInfoUI;

	public Dictionary<int, MultiPlay_CharaMemberData> MemberList;

	public bool IsDungeonReady;

	public bool IsDungeonError;

	public float DungeonReadyProgress;

	public bool[] IsAccess;

	public bool WarpFlag;

	public bool Send_WarpFlag;

	public bool WarpSwitch;

	public bool IsStop;

	public MultiPlay_BattleData TryJoinBattle;

	public int TryJoinBattleIdLog;

	public Game_Chara_MA_MultiPlay CharaMA;

	public float InvisibleTime;

	public int ID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector3 Position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float RotationY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float AnimeSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public long UserID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public int LeaderDF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AreaKind
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsOnBoat
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int AreaID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DungeonID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int FloorID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Date
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DungeonDifficulty
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MotionID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsLeaving
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsFloorRemoving
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string IgnrIDs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float BlazeArtsGauge
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int BlazeArtsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool SkillItemGaugePause
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int DegreeDf
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DegreeST
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsRemoveOK
	{
		get
		{
			return false;
		}
	}

	public int RoomIndex
	{
		get
		{
			return 0;
		}
	}

	public bool IsOwner
	{
		get
		{
			return false;
		}
	}

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public bool IsDisp
	{
		get
		{
			return false;
		}
	}

	public bool IsDungeon
	{
		get
		{
			return false;
		}
	}

	public int Level
	{
		get
		{
			return 0;
		}
	}

	public int LevelAve
	{
		get
		{
			return 0;
		}
	}

	public bool IsBattle
	{
		get
		{
			return false;
		}
	}

	public bool IsBattleOrResult
	{
		get
		{
			return false;
		}
	}

	public int BattleID
	{
		get
		{
			return 0;
		}
	}

	public MultiPlay_BattleData BattleData
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_BattleData BattleData_Result
	{
		get
		{
			return null;
		}
	}

	public bool IsAlchemy
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_AlchemyData AlchemyData
	{
		get
		{
			return null;
		}
	}

	public bool IsTryJoinBattle
	{
		get
		{
			return false;
		}
	}

	public Color32 MarkColor
	{
		get
		{
			return default(Color32);
		}
	}

	public string DispName
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_CharaData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_CharaData(int id, int date)
	{
	}

	public override bool IsUpdateSyncData()
	{
		return false;
	}

	public override int GetUpdateCount()
	{
		return 0;
	}

	public override void ClearUpdateSyncData()
	{
	}

	public override Dictionary<string, object> ToDictionary(bool isUpdate = false)
	{
		return null;
	}

	public override void UpdateFromDictionary(Dictionary<string, object> obj)
	{
	}

	public void UpdateChara_OthersOnly()
	{
	}

	public void UpdateChara()
	{
	}

	public void CreateChara(MultiPlay_CharaMemberData leader)
	{
	}

	private void EncountCheck()
	{
	}

	public bool IsUpdateSyncDataMemberList()
	{
		return false;
	}

	public byte GetUpdateCountMemberList()
	{
		return 0;
	}

	public void ClearUpdateSyncDataMemberList()
	{
	}

	public Dictionary<int, string> ToDictionaryMemberList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryMemberList(Dictionary<int, string> obj)
	{
	}

	public void SaveMemberState()
	{
	}

	public bool IsIgnore()
	{
		return false;
	}

	public bool IsSameArea(int dungeonID, int dungeonFloor)
	{
		return false;
	}

	public bool IsSameDate(int date)
	{
		return false;
	}

	public float GetHPRate()
	{
		return 0f;
	}

	public void CheckAbnormalState()
	{
	}

	public int GetLeaderDFGenderHero(int leaderDF)
	{
		return 0;
	}

	public void MakeCharaModel(MultiPlay_CharaMemberData leader)
	{
	}

	public MultiPlay_CharaMemberData GetLeaderCharaMemberData()
	{
		return null;
	}

	public MultiPlay_CharaMemberData GetCharaMemberDataFromDF(int df)
	{
		return null;
	}

	private void Init()
	{
	}
}
