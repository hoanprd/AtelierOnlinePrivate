using System.Collections.Generic;
using UnityEngine;

public class MultiPlay_GimmickData : PhotonView_SyncData
{
	public bool IsCreated;

	public bool IsPerform;

	public float ExecWaitTime;

	private static readonly float ExecWaitTimeMax;

	public Game_Spawner_Prefab Spawner;

	public Game_Gimmick_Base Gimmick;

	public long Index
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public int No
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Pos
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsExec
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

	public bool IsEnable
	{
		get
		{
			return false;
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

	public int ExecCharaID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsEnableData
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

	public MultiPlay_GimmickData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_GimmickData(long index, GimmickSpot spot, SpawnerData data, int dungeonID, int floorID, int date)
	{
	}

	public void CreateGimmick()
	{
	}

	private void OnCreate(GameObject obj)
	{
	}

	public bool IsReserved()
	{
		return false;
	}

	public bool IsExistReseveChara()
	{
		return false;
	}

	public bool IsRemoveOK()
	{
		return false;
	}

	public void AddExecTime(float time)
	{
	}
}
