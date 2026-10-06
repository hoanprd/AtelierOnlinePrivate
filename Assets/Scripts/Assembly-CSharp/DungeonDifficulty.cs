using System;

[Serializable]
public class DungeonDifficulty
{
	[Serializable]
	public class Quest
	{
		public int DF;
	}

	public int NO;

	public string NAME;

	public int ULK;

	public Quest[] QST;

	public bool IsUnlock()
	{
		return false;
	}
}
