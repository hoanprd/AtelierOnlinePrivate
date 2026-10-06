using System;
using MessagePack;

[Serializable]
public class SpotBase
{
	public int NO;

	public int POS;

	public int OC_00;

	public int OC_02;

	public int OC_04;

	public int OC_06;

	public int OC_08;

	public int OC_10;

	public int OC_12;

	public int OC_14;

	public int OC_16;

	public int OC_18;

	public int OC_20;

	public int OC_22;

	public int WEA_FIN;

	public int WEA_CLO;

	public int WEA_RAI;

	public int WEA_SNO;

	public int WEA_AFR;

	public int KILL;

	[IgnoreMember]
	protected DateTime pkTime;

	public bool[] GetTimeArray()
	{
		return null;
	}

	public bool[] GetWeatherArray()
	{
		return null;
	}

	public virtual void UpdatePKTime()
	{
	}

	public virtual bool IsSpawnOK()
	{
		return false;
	}
}
