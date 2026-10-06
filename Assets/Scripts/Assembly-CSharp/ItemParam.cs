using System;

[Serializable]
public class ItemParam : ParamBase
{
	public int EB;

	public virtual int[] GetDispParamArray()
	{
		return null;
	}

	public static ItemParam operator -(ItemParam z, ItemParam w)
	{
		return null;
	}

	public static ItemParam operator +(ItemParam z, ItemParam w)
	{
		return null;
	}

	public static ItemParam operator +(ItemParam z, CharaSpec w)
	{
		return null;
	}

	public static ItemParam operator -(ItemParam z, CharaSpec w)
	{
		return null;
	}

	public static ItemParam operator *(ItemParam z, EquipRate w)
	{
		return null;
	}
}
