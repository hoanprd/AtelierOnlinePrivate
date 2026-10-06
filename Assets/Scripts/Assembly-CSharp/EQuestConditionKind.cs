using System;

[Flags]
public enum EQuestConditionKind
{
	eNONE = 0,
	eANYTIME = 1,
	eDAILY = 2,
	eFREE_QUEST_ALL = eANYTIME | eDAILY
}
