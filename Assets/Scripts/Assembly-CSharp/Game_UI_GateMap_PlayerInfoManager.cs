using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_PlayerInfoManager : MonoBehaviour
{
	private class PlayerInfo
	{
		public Transform trPos;

		public int iArea;

		public Game_UI_GateMap_PlayerInfo scrPlayer;

		public BoxCollider2D scrColl;

		public bool IsMatch(int iArea)
		{
			return false;
		}
	}

	private List<PlayerInfo> m_clsPosList;

	[SerializeField]
	private Transform m_trPlayerInfoRoot;

	[SerializeField]
	private GameObject m_goPlayerBase;

	private PlayerInfo GetPlayerInfo(int iArea)
	{
		return null;
	}

	public void Init()
	{
	}

	public void MakeObject(ExploreRoomInfo clsRes)
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public void KillChild()
	{
	}
}
