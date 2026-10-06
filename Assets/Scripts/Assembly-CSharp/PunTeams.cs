using System.Collections.Generic;
using UnityEngine;

public class PunTeams : MonoBehaviour
{
	public enum Team : byte
	{
		none = 0,
		red = 1,
		blue = 2
	}

	public static Dictionary<Team, List<PhotonPlayer>> PlayersPerTeam;

	public const string TeamPlayerProp = "team";

	public void Start()
	{
	}

	public void OnDisable()
	{
	}

	public void OnJoinedRoom()
	{
	}

	public void OnLeftRoom()
	{
	}

	public void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
	{
	}

	public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
	{
	}

	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
	{
	}

	public void UpdateTeams()
	{
	}
}
