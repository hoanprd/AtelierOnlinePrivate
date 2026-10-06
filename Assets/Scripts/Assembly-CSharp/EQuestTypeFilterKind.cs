using System;

[Flags]
public enum EQuestTypeFilterKind
{
	eNONE = 0,
	eDELIVERY = 1,
	eGET = 2,
	eSUBJUGATION = 4,
	eFREE_QUEST_ALL = eDELIVERY | eGET | eSUBJUGATION
}
