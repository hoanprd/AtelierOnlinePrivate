using System;

[Serializable]
public class ExceedPrice
{
	[Serializable]
	public class LevelLimit
	{
		public int MIN_LV;

		public int MAX_LV;
	}

	public Formula EXP_COEF;

	public LevelLimit LV_LIMIT;
}
