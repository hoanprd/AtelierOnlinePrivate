using System.Collections;
using System.Diagnostics;
using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomTime : MonoBehaviour
{
	private int roomStartTimestamp;

	private const string StartTimeKey = "#rt";

	public double RoomTime
	{
		get
		{
			return 0.0;
		}
	}

	public int RoomTimestamp
	{
		get
		{
			return 0;
		}
	}

	public bool IsRoomTimeSet
	{
		get
		{
			return false;
		}
	}

	[DebuggerHidden]
	internal IEnumerator SetRoomStartTimestamp()
	{
		return null;
	}

	public void OnJoinedRoom()
	{
	}

	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
	{
	}
}
