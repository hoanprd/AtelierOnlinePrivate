using System;
using System.Collections.Generic;
using MessagePack;

[Serializable]
public class InventoryInfo
{
	public long ID;

	public int DF;

	public int CATEG;

	public int QTY;

	public int QTYLM;

	public int QUA;

	public InventoryStatus STT;

	public int TRT;

	public int HLD;

	public int EC;

	public int PLC;

	public int NEW;

	public int QTEXP;

	[IgnoreMember]
	public int SUB
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public InventoryInfo Clone()
	{
		return null;
	}

	public InventoryInfo DeepCopy()
	{
		return null;
	}

	public static Dictionary<string, object> ToDictionary(InventoryInfo info)
	{
		return null;
	}

	public static InventoryInfo FromDictionary(Dictionary<string, object> dic)
	{
		return null;
	}

	public void MakeTutorialData(int no)
	{
	}

	public bool IsSubEquip()
	{
		return false;
	}

	public bool IsEquip()
	{
		return false;
	}
}
