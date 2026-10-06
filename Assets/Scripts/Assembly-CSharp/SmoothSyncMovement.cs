using Photon;
using UnityEngine;

public class SmoothSyncMovement : Photon.MonoBehaviour, IPunObservable
{
	public float SmoothingDelay;

	private Vector3 correctPlayerPos;

	private Quaternion correctPlayerRot;

	public void Awake()
	{
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	public void Update()
	{
	}
}
