using System;

[Serializable]
public class MapInfo
{
	public int iAreaID;

	public int iStageID;

	public int iDungeonID;

	public int iDungeonFloor;

	public bool bParts;

	public string strFloorName;

	public bool IsDungeon()
	{
		return false;
	}

	public bool IsPartsDungeon()
	{
		return false;
	}

	public string GetFieldAssetPath()
	{
		return null;
	}
}
