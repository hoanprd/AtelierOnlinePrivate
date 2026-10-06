using System;
using System.Collections.Generic;

[Serializable]
public class TownInfo
{
	public int iTownId;

	public int iAreaNameId;

	public int iAreaId;

	public eMusicID eMusic_Day;

	public eMusicID eMusic_Night;

	public List<TownExit> clsExitList;

	public bool IsTownId(int iTownId)
	{
		return false;
	}

	public FieldName GetAreaName()
	{
		return null;
	}

	public List<string> GetMusicAssetNameList()
	{
		return null;
	}
}
