using System;

[Serializable]
public class SalonInfo
{
	[Serializable]
	public class AppearanceDatabase
	{
		public int[] GEN;

		public int[] HAI;

		public int[] HAI_C;

		public int[] SKI;

		public int[] FAC;

		public int[] EYE;
	}

	public AppearanceInfo MAKE;

	public AppearanceDatabase PARTS;
}
