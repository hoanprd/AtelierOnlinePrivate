using System;

[Serializable]
public class QuestDeliver
{
	[Serializable]
	public class Present
	{
		public int CNT;
	}

	public QuestInfo QST;

	public Present PNT;

	public void MakeTutorialData()
	{
	}
}
