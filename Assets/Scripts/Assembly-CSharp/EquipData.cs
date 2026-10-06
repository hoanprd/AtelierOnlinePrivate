using System;
using System.Collections.Generic;
using MessagePack;

[Serializable]
public class EquipData
{
	[Serializable]
	public class Accessory
	{
		public int NO;

		public long ID;
	}

	public long HD;

	public long WR;

	public long WL;

	public long BD;

	public List<Accessory> AC;

	public int HD_V;

	public int SD_V;

	// C# has no syntax for parameterized property 'Item'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: IgnoreMember]
	public long get_Item(int index)
	{
		return 0L;
	}

	public void set_Item(int index, long value)
	{
	}

	public EquipData Clone()
	{
		return null;
	}

	public EquipData DeepCopy()
	{
		return null;
	}

	public static Dictionary<string, object> ToDictionary(EquipData data)
	{
		return null;
	}

	public static EquipData FromDictionary(Dictionary<string, object> dic)
	{
		return null;
	}

	public void InitAccessory()
	{
	}

	public long[] GetArray()
	{
		return null;
	}

	public void SetArray(long[] ary)
	{
	}

	public bool IsEquiped(long id)
	{
		return false;
	}
}
