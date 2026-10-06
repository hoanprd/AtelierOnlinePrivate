using System.Collections.Generic;
using UnityEngine;

public class MasterDungeonInfo : ScriptableObject
{
	public List<DungeonInfo> List;

	public DungeonInfo Find(int iDungeonId)
	{
		return null;
	}

	public FieldName GetAreaName(int iDungeonId)
	{
		return null;
	}

	public bool IsForExQuest(int iDungeonID)
	{
		return false;
	}
}
