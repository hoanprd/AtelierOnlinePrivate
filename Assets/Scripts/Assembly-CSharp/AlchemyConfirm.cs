using System;

[Serializable]
public class AlchemyConfirm
{
	[Serializable]
	public class CandidateSkill
	{
		public int DF;

		public int LW;

		public int EV;

		public string LWP;
	}

	[Serializable]
	public class Item
	{
		public long ID;

		public int DF;

		public int QTY;

		public CandidateSkill[] TRC;

		public ItemParam EQU;
	}

	public Item GET;
}
