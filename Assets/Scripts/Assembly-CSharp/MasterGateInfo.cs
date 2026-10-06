using System.Collections.Generic;
using UnityEngine;

public class MasterGateInfo : ScriptableObject
{
	public List<GateInfo> List;

	public GateInfo Find(int iAreaId, int iUINo)
	{
		return null;
	}

	public GateInfo Find(int iPortalId)
	{
		return null;
	}

	public List<GateInfo> FindArea(int iAreaId, bool bListOnly = true)
	{
		return null;
	}

	public bool IsWarpPointForAcademy(int iAreaId, int iUINo)
	{
		return false;
	}
}
