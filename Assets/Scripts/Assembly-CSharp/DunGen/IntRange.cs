using System;

namespace DunGen
{
	[Serializable]
	public class IntRange
	{
		public int Min;

		public int Max;

		public IntRange()
		{
		}

		public IntRange(int min, int max)
		{
		}

		public int GetRandom(Random random)
		{
			return 0;
		}
	}
}
