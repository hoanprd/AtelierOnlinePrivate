using System;

[Serializable]
public class APISpotPickData
{
	[Serializable]
	public class ItemInfo
	{
		public long ID;

		public int DF;

		public string NAME;

		public int QTY;

		public int RAR;

		public int GEN;

		public int TRT;
	}

	public PickupSpot[] SPT_UP;

	public void MakeTutorialData(int no)
	{
	}
}
