using System.Collections.Generic;
using UnityEngine;

public class MasterHardModeInfo : ScriptableObject
{
	public List<OpenHardModeInfo> List;

	public bool IsOpendHardMode(DegreeInfo[] degreeInfos)
	{
		return false;
	}
}
