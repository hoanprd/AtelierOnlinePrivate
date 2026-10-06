using System.Collections.Generic;
using UnityEngine;

public class NetworkCullingHandler : MonoBehaviour, IPunObservable
{
	private int orderIndex;

	private CullArea cullArea;

	private List<byte> previousActiveCells;

	private List<byte> activeCells;

	private PhotonView pView;

	private Vector3 lastPosition;

	private Vector3 currentPosition;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private bool HaveActiveCellsChanged()
	{
		return false;
	}

	private void UpdateInterestGroups()
	{
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
