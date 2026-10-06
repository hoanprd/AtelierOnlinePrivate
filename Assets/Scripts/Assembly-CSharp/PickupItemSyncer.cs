using System;
using Photon;

public class PickupItemSyncer : MonoBehaviour
{
	public bool IsWaitingForPickupInit;

	private const float TimeDeltaToIgnore = 0.2f;

	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
	{
	}

	public void OnJoinedRoom()
	{
	}

	public void AskForPickupItemSpawnTimes()
	{
	}

	[PunRPC]
	[Obsolete]
	public void RequestForPickupTimes(PhotonMessageInfo msgInfo)
	{
	}

	[PunRPC]
	public void RequestForPickupItems(PhotonMessageInfo msgInfo)
	{
	}

	private void SendPickedUpItems(PhotonPlayer targetPlayer)
	{
	}

	[PunRPC]
	public void PickupItemInit(double timeBase, float[] inactivePickupsAndTimes)
	{
	}
}
