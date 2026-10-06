using System;
using MessagePack;

[Serializable]
public class QuestDetail : QuestBase
{
	public int CLR;

	public int ALT;

	public int STP;

	public string UL;

	public int CT;

	public int CC;

	public string LT;

	public string LC;

	[IgnoreMember]
	private DateTime UnlockTime;

	private void SetUnlockTime()
	{
	}

	public override bool IsUnlock()
	{
		return false;
	}

	public string GetRestTimeText()
	{
		return null;
	}

	public QuestComplete MakeReward()
	{
		return null;
	}

	public int GetDispPrio()
	{
		return 0;
	}

	public void Update(QuestDetail src)
	{
	}

	public static int Compare(QuestDetail a, QuestDetail b)
	{
		return 0;
	}

	public static int CompareAchieve(QuestDetail a, QuestDetail b)
	{
		return 0;
	}
}
