using System;

[Flags]
public enum ERewardTypeKind
{
	eNONE = 0,
	eMATERIAL = 1,
	eWEAPON = 2,
	eFOOD = 4,
	eITEM = 8,
	eFREE_QUEST_ALL = eMATERIAL | eWEAPON | eFOOD | eITEM,
	eWEALTH = 0x10,
	eETHER_SHOP_ALL = eFREE_QUEST_ALL | eWEALTH
}
