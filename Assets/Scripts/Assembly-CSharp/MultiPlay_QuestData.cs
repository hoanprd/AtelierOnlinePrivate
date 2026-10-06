using System.Collections.Generic;

public class MultiPlay_QuestData : PhotonView_SyncData
{
	public Dictionary<int, MultiPlay_QuestCharaData> CharaList;

	public QuestDetail QuestDetail;

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

	public int OwnerCharaID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ProgressCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float ElapsedTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsAchievement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsCancel
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEnabled
	{
		get
		{
			return false;
		}
	}

	public bool IsOrder
	{
		get
		{
			return false;
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
	}

	public string Detail
	{
		get
		{
			return null;
		}
	}

	public int AchievementCount
	{
		get
		{
			return 0;
		}
	}

	public int TimeLimit
	{
		get
		{
			return 0;
		}
	}

	public QuestConditions QuestDetailConditions
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_QuestData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_QuestData(int df)
	{
	}

	public override bool IsUpdateSyncData()
	{
		return false;
	}

	public override Dictionary<string, object> ToDictionary(bool isUpdate = false)
	{
		return null;
	}

	public override void UpdateFromDictionary(Dictionary<string, object> obj)
	{
	}

	public bool IsUpdateSyncDataCharaList()
	{
		return false;
	}

	public Dictionary<int, string> ToDictionaryCharaList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryCharaList(Dictionary<int, string> obj)
	{
	}

	public void UpdateQuestDetail()
	{
	}

	public void Discard()
	{
	}

	private QuestDetail GetQuestDetailFromDF(int df)
	{
		return null;
	}

	private void Init()
	{
	}
}
