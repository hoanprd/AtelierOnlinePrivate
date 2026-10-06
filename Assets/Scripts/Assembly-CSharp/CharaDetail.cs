using System;
using System.Collections.Generic;

[Serializable]
public class CharaDetail
{
	public int DF;

	public string ICON;

	public EquipData EQU;

	public List<SubEquip> SUB;

	public ElementInfo[] ELM;

	public AppearanceInfo MK;

	public CharaStatus STT;

	public EquipData CD_EQU;

	public int[] CD_V;

	public List<BlazeArtsStatus> BAL;

	public List<long> GetAllEquip4Status()
	{
		return null;
	}

	public List<long> GetAllEquip()
	{
		return null;
	}

	public long GetSubEquip(int no)
	{
		return 0L;
	}

	public bool RemoveMainEquip(long inv)
	{
		return false;
	}

	public bool RemoveVisualEquip(long inv)
	{
		return false;
	}

	public bool RemoveSubEquip(long inv)
	{
		return false;
	}

	public bool RemoveEquip(long inv)
	{
		return false;
	}

	public void SetSubEquip(int index, InventoryInfo inventory)
	{
	}

	public CharaDetail Clone()
	{
		return null;
	}

	public bool HasBlazeArts()
	{
		return false;
	}

	public bool CanUpgreadeBlazeArts()
	{
		return false;
	}
}
