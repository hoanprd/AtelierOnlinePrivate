using System;

[Serializable]
public class StrageExpandInfo
{
	[Serializable]
	public class Info
	{
		public int CNT;

		public int MAX;

		public int NOW;

		public int NEXT;

		public int PRC;
	}

	public Info ENL;
}
