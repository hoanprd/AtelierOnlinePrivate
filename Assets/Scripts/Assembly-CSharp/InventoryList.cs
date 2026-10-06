using System;
using System.Collections.Generic;
using MessagePack;

[Serializable]
public class InventoryList
{
	[Serializable]
	public class Have
	{
		public int CNT;

		public int SZ;
	}

	[Serializable]
	public class Info
	{
		public Have CON;

		public Have RCK;

		public bool IsCapacityOver()
		{
			return false;
		}
	}

	public Info INFO;

	public List<InventoryInfo> CON;

	public List<InventoryInfo> RCK;

	public List<InventoryInfo> EQU;

	public List<InventoryInfo> CD_EQU;

	[IgnoreMember]
	public List<InventoryInfo> All
	{
		get
		{
			return null;
		}
	}

	[IgnoreMember]
	public List<InventoryInfo> AllAndContainer
	{
		get
		{
			return null;
		}
	}

	[IgnoreMember]
	public List<InventoryInfo> AllAndContainerConditional
	{
		get
		{
			return null;
		}
	}

	public InventoryList()
	{
	}

	public InventoryList(Dictionary<int, MultiPlay_BattleCharaData> CharaList)
	{
	}

	public void Dump()
	{
	}

	public void Init()
	{
	}

	public InventoryInfo Find(long inventoryID, bool container = false)
	{
		return null;
	}

	public List<InventoryInfo> FindAll(int df, bool isField)
	{
		return null;
	}

	public List<InventoryInfo> FindRck(int df)
	{
		return null;
	}

	public void Add(InventoryList add)
	{
	}

	public void Update(InventoryInfo target)
	{
	}

	public void Add(EStorageKind strage, List<InventoryInfo> add)
	{
	}

	public void Remove(List<InventoryInfo> remove)
	{
	}

	public void Remove(long itemID)
	{
	}

	public void Remove(List<long> itemID)
	{
	}

	public void Remove(long[] remove)
	{
	}

	private void UpdateCount()
	{
	}

	public void Clear()
	{
	}
}
