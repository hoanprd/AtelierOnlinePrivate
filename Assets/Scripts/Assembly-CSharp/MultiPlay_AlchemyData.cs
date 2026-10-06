using System.Collections.Generic;

public class MultiPlay_AlchemyData : PhotonView_SyncData
{
	public Dictionary<int, MultiPlay_AlchemyMaterialData> MaterialList;

	public Dictionary<int, MultiPlay_AlchemyResultData> ResultList;

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

	public int Keyword01
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Keyword02
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Keyword03
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsResult
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

	public MultiPlay_AlchemyData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_AlchemyData(int charaID)
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

	public bool IsUpdateSyncDataMaterialList()
	{
		return false;
	}

	public Dictionary<int, string> ToDictionaryMaterialList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryMaterialList(Dictionary<int, string> obj)
	{
	}

	public bool IsUpdateSyncDataResultList()
	{
		return false;
	}

	public Dictionary<int, string> ToDictionaryResultList(bool isUpdate = false)
	{
		return null;
	}

	public void UpdateFromDictionaryResultList(Dictionary<int, string> obj)
	{
	}

	public MultiPlay_AlchemyMaterialData GetAlchemyMaterialDataFromIndex(int index)
	{
		return null;
	}

	private void Init()
	{
	}
}
