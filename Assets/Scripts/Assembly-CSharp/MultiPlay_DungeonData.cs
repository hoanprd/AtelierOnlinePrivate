using System.Collections.Generic;

public class MultiPlay_DungeonData : PhotonView_SyncData
{
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

	public bool IsEnableData
	{
		get
		{
			return false;
		}
	}

	public int MaxFloor
	{
		get
		{
			return 0;
		}
	}

	public string DungeonJPName
	{
		get
		{
			return null;
		}
	}

	public DungeonInfo Info { get; private set; }

	public MultiPlay_DungeonData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_DungeonData(int id)
	{
	}

	public int GetSeed(int index)
	{
		return 0;
	}

	public void SetSeed(int index, int seed)
	{
	}

	public bool IsRemoveOK()
	{
		return false;
	}

	public void UpdateInfo()
	{
	}
}
