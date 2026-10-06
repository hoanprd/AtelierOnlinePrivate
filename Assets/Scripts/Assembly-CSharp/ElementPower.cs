using System;

[Serializable]
public class ElementPower
{
	public int FIRE;

	public int WATER;

	public int WIND;

	public int EARTH;

	public int LIGHT;

	public int DARK;

	public EElement GetMostElement()
	{
		return EElement.eNONE;
	}

	public EElement GetWeakElement()
	{
		return EElement.eNONE;
	}

	public int[] GetArray()
	{
		return null;
	}

	public bool IsEnable(EElement target)
	{
		return false;
	}

	public static ElementPower operator -(ElementPower z, ElementPower w)
	{
		return null;
	}

	public static ElementPower operator +(ElementPower z, ElementPower w)
	{
		return null;
	}

	public static ElementPower operator *(ElementPower z, ElementPowerRate w)
	{
		return null;
	}

	public static ElementPower operator /(ElementPower z, float w)
	{
		return null;
	}
}
