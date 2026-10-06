using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomRoundTimer : MonoBehaviour
{
	public int SecondsPerTurn;

	public double StartTime;

	public Rect TextPos;

	private bool startRoundWhenTimeIsSynced;

	private const string StartTimeKey = "st";

	private void StartRoundNow()
	{
	}

	public void OnJoinedRoom()
	{
	}

	public void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
	{
	}

	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	private void Update()
	{
	}

	public void OnGUI()
	{
	}
}
