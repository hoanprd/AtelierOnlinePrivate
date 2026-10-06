using System;

[Serializable]
public class QuestBase : ResponseDetailBase
{
	public int STT;

	public string TL;

	public string CHA_ICON;

	public string QUEST_NO;

	public int CATEG;

	public int TYPE;

	public long INT_VAL;

	public int LAST_ON;

	public CostInfo CST;

	public QuestConditions[] ENM;

	public QuestConditions[] BTL;

	public QuestConditions[] MIX;

	public QuestConditions[] SKL;

	public QuestConditions[] ACTSKL;

	public QuestConditions[] DLV;

	public QuestConditions[] GET;

	public QuestConditions[] PIC;

	public QuestConditions[] REG;

	public QuestConditions[] ARA;

	public QuestConditions[] VIL;

	public QuestConditions[] DUN;

	public QuestConditions[] ARR;

	public QuestConditions[] SPE;

	public QuestConditions[] TALK;

	public bool IsNeedCost()
	{
		return false;
	}

	public bool IsRetryOK()
	{
		return false;
	}

	protected QuestConditions[] RequestList()
	{
		return null;
	}

	public EQuestType GetQuestType()
	{
		return (EQuestType)0;
	}

	public EQuestCategory GetQuestCategory()
	{
		return EQuestCategory.None;
	}

	public bool IsQuestType(EQuestType type)
	{
		return false;
	}

	public bool IsOrder()
	{
		return false;
	}

	public bool IsEnableOrder()
	{
		return false;
	}

	public bool IsComplete()
	{
		return false;
	}

	public int GetNowCount(bool isMaxBorder = false)
	{
		return 0;
	}

	public int GetBorder()
	{
		return 0;
	}

	public bool IsNormal()
	{
		return false;
	}

	public virtual bool IsUnlock()
	{
		return false;
	}
}
