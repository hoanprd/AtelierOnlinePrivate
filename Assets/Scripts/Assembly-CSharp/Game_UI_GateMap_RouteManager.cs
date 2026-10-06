using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_RouteManager : MonoBehaviour
{
	private class RouteInfo
	{
		public Transform trRoute;

		public int iArea;

		public bool IsMatch(int iArea)
		{
			return false;
		}
	}

	private List<RouteInfo> m_clsPosList;

	[SerializeField]
	private Transform m_trRouteRoot;

	private RouteInfo GetRouteInfo(int iArea)
	{
		return null;
	}

	public void Init()
	{
	}

	public void UpdateObject()
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public void SetActiveAllRoute(bool active)
	{
	}

	public void ActivateAllHardModeRoute()
	{
	}

	public void ActivateHardModeRoute(int areaID)
	{
	}
}
