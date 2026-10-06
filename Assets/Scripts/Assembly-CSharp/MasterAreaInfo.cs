using System.Collections.Generic;
using UnityEngine;

public class MasterAreaInfo : ScriptableObject
{
	public List<AreaInfo> List;

	public AreaInfo Find(int iAreaId)
	{
		return null;
	}

	public AreaInfo Find_NameId(int iAreaNameId)
	{
		return null;
	}

	public FieldName GetAreaName(int iAreaId)
	{
		return null;
	}

	public bool GetIsHardMode(int iAreaId)
	{
		return false;
	}

	public int GetStartPortalID(int iAreaId)
	{
		return 0;
	}
}
