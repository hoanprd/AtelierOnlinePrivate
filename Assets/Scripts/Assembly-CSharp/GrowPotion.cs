using System;

[Serializable]
public class GrowPotion
{
	[Serializable]
	public class Status
	{
		public int LV;

		public int EXP;

		public int LVCAP;
	}

	[Serializable]
	public class Info
	{
		public Status LV;
	}

	public Info CH;
}
