using System.Collections.Generic;

public class MultiPlay_BattleCharaData : PhotonView_SyncData
{
	public Dictionary<int, APIBattleFinish.Request.UseSkill> StealEtherList;

	public List<int> killEnemyList;

	public List<long> useItemList;

	public Dictionary<long, MultiPlay_InventoryInfo> RckList;

	private MultiPlay_CharaData m_charaData;

	public int CharaID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int BattleLogTurn
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LockOnMember
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsUseSkill
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOwner
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsBurst
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEscape
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool EscapeReserve
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int NowStrategy
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int BeforeStrategy
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

	public MultiPlay_CharaData CharaData
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_BattleCharaData(string json)
	{
	}

	public MultiPlay_BattleCharaData(int charaID)
	{
	}

	public bool IsUpdateSyncDataRckList()
	{
		return false;
	}

	public int GetUpdateCountRckList()
	{
		return 0;
	}

	public override void ClearUpdateSyncData()
	{
	}

	public Dictionary<long, string> ToDictionaryRckList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryRckList(Dictionary<long, string> obj)
	{
	}
}
