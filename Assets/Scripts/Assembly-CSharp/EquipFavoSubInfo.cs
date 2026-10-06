using System;
using System.Collections.Generic;

[Serializable]
public class EquipFavoSubInfo
{
	public string FAV_NAME;

	public int CHARA_DF;

	public int NO;

	public List<SubEquip> FAV_SUB;

	public EquipFavoSubInfo()
	{
	}

	public EquipFavoSubInfo(int no)
	{
	}
}
