using System;

[Serializable]
public class CharaSpec : ParamBase
{
	public int EXP;

	public int HP;

	public int[] GetDispParamArray()
	{
		return null;
	}

	public static CharaSpec operator -(CharaSpec z, CharaSpec w)
	{
		return null;
	}

	public static CharaSpec operator +(CharaSpec z, CharaSpec w)
	{
		return null;
	}

	public static CharaSpec operator +(CharaSpec z, EquipParam w)
	{
		return null;
	}

	public static CharaSpec operator -(CharaSpec z, EquipParam w)
	{
		return null;
	}

	public static CharaSpec operator *(CharaSpec z, EquipRate w)
	{
		return null;
	}

	public void Dump()
	{
	}
}
