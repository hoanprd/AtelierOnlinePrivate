using Photon;
using UnityEngine;

public class PickupItemSimple : Photon.MonoBehaviour
{
	public float SecondsBeforeRespawn;

	public bool PickupOnCollide;

	public bool SentPickup;

	public void OnTriggerEnter(Collider other)
	{
	}

	public void Pickup()
	{
	}

	[PunRPC]
	public void PunPickupSimple(PhotonMessageInfo msgInfo)
	{
	}

	public void RespawnAfter()
	{
	}
}
