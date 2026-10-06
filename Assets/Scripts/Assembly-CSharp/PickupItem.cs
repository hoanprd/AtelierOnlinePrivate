using System.Collections.Generic;
using Photon;
using UnityEngine;

public class PickupItem : Photon.MonoBehaviour, IPunObservable
{
	public float SecondsBeforeRespawn;

	public bool PickupOnTrigger;

	public bool PickupIsMine;

	public UnityEngine.MonoBehaviour OnPickedUpCall;

	public bool SentPickup;

	public double TimeOfRespawn;

	public static HashSet<PickupItem> DisabledPickupItems;

	public int ViewID
	{
		get
		{
			return 0;
		}
	}

	public void OnTriggerEnter(Collider other)
	{
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	public void Pickup()
	{
	}

	public void Drop()
	{
	}

	public void Drop(Vector3 newPosition)
	{
	}

	[PunRPC]
	public void PunPickup(PhotonMessageInfo msgInfo)
	{
	}

	internal void PickedUp(float timeUntilRespawn)
	{
	}

	[PunRPC]
	internal void PunRespawn(Vector3 pos)
	{
	}

	[PunRPC]
	internal void PunRespawn()
	{
	}
}
