using UnityEngine;

public class ManualPhotonViewAllocator : MonoBehaviour
{
	public GameObject Prefab;

	public void AllocateManualPhotonView()
	{
	}

	[PunRPC]
	public void InstantiateRpc(int viewID)
	{
	}
}
