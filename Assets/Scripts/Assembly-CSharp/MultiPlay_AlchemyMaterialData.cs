public class MultiPlay_AlchemyMaterialData : PhotonView_SyncData
{
	private MultiPlay_CharaData m_charaData;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public long InventoryID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public int ItemID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Quality
	{
		get
		{
			return 0;
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

	public MultiPlay_CharaData CharaData
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_AlchemyMaterialData(string json)
	{
	}

	public MultiPlay_AlchemyMaterialData(int index, int charaID)
	{
	}
}
