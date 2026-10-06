using System.Collections.Generic;
using UnityEngine;

public class MasterMapInfo : ScriptableObject
{
	public List<MapInfo> List;

	public MapInfo Find(int iAreaId, int iStageID)
	{
		return null;
	}

	public List<MapInfo> Find(int iAreaId)
	{
		return null;
	}

	public List<MapInfo> FindDungeon(int iDungeonId)
	{
		return null;
	}

	public MapInfo FindDungeon(int iDungeonId, int iFloor)
	{
		return null;
	}
}
