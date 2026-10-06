using System;

[Serializable]
public class GrowCharaData
{
	[Serializable]
	public class PowerupInfo
	{
		public int DF;
	}

	[Serializable]
	public class Info
	{
		public PowerupInfo EXC;
	}

	[Serializable]
	public class LevelLimit
	{
		public int MIN_LV;

		public int MAX_LV;
	}

	public CharaDetail CH;

	public Info INFO;

	public Formula EXP_COEF;

	public LevelLimit LV_LIMIT;
}
