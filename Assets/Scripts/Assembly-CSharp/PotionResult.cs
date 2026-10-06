using System;

[Serializable]
public class PotionResult
{
	[Serializable]
	public class Param
	{
		public int LV;

		public int EXP;

		public int LVCAP;

		public int THR_L;

		public int THR_H;
	}

	[Serializable]
	public class Data
	{
		public int EXP;

		public Param BF;

		public Param AF;
	}

	public Data INFO;

	public CharaDetail CH;
}
