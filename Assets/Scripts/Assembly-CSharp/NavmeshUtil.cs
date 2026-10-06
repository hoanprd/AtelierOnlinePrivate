using UnityEngine;
using UnityEngine.AI;

public class NavmeshUtil
{
	private static readonly string[] sr_sAgentTypeName;

	public static string GetAgentTypeName(EAgentType eType)
	{
		return null;
	}

	public static ENavMeshArea GetNavMeshArea(int iMask)
	{
		return ENavMeshArea.Walkable;
	}

	public static int GetNavMeshMask(ENavMeshArea eArea)
	{
		return 0;
	}

	public static int GetNavmeshAgentTypeID(EAgentType type)
	{
		return 0;
	}

	public static NavMeshHit GetClosestPoint(Vector3 vOrgPos, EAgentType eType, ENavMeshArea eArea = ENavMeshArea.AllAreas)
	{
		return default(NavMeshHit);
	}

	public static NavMeshPath CalcPath(Vector3 vStart, Vector3 vGoal, EAgentType eType, ENavMeshArea eArea = ENavMeshArea.AllAreas)
	{
		return null;
	}
}
