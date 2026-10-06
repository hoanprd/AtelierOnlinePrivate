using System.Collections.Generic;
using UnityEngine;

public class MultiPlay_EnemyData : PhotonView_SyncData
{
	public class EnemyMemberData
	{
		public int Level;
	}

	public bool IsStop;

	public bool IsCheckedRandom;

	public bool IsAIStop;

	public bool IsUpdateNameInfo;

	private MultiPlay_BattleData BattleDataTemp;

	private bool SearchBattleData;

	public int State;

	public Game_Enemy_MA_MultiPlay EnemyMA;

	public EnemyInfo EnemyInfo;

	public int TargetPlayerID;

	public List<EnemyMemberData> EnemyMemberList;

	public long ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public int NO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int POS
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsLocal
	{
		get
		{
			return false;
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

	public Quaternion Rotation
	{
		get
		{
			return default(Quaternion);
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

	public bool IsDraw
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsFake
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string Anime
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Level
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MoveTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MoveWeather
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int FakeKind
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsRandom
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float RandomPer
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int DF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIState
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector3 MakePosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion MakeRotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public bool IsSpawnerBoss
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int AuraSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsDead
	{
		get
		{
			return false;
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

	public int OwnerPlayer
	{
		get
		{
			return 0;
		}
		set
		{
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

	public bool IsStrike
	{
		get
		{
			return false;
		}
	}

	public bool IsBattle
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_BattleData BattleData
	{
		get
		{
			return null;
		}
	}

	public int BattleID
	{
		get
		{
			return 0;
		}
	}

	public bool IsAnyBoss
	{
		get
		{
			return false;
		}
	}

	public int BossType
	{
		get
		{
			return 0;
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_EnemyData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_EnemyData(EnemySpot spotData, SpawnerData spawnerData, int dungeonID, int floorID, int date)
	{
	}

	public bool CreateEnemy()
	{
		return false;
	}

	private void UpdateSpawnerData(SpawnerData spawnerData, bool resetPos)
	{
	}

	private void UpdateEnemyInfo(int df)
	{
	}

	public void UpdateSpotData(EnemySpot spotData)
	{
	}

	public bool IsOnlyOnline()
	{
		return false;
	}

	public void KillOnlyOnline()
	{
	}

	public bool IsSpawnOK()
	{
		return false;
	}

	public bool TryRandomEncount()
	{
		return false;
	}

	public bool IsEncount(MultiPlay_CharaData chara)
	{
		return false;
	}

	public void InitBattleDataTemp()
	{
	}

	private void Init()
	{
	}

	public void Update(MultiPlay_EnemyData newEnemy)
	{
	}
}
