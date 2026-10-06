using UnityEngine;

public class PhotonRigidbodyView : MonoBehaviour, IPunObservable
{
	[SerializeField]
	private bool m_SynchronizeVelocity;

	[SerializeField]
	private bool m_SynchronizeAngularVelocity;

	private Rigidbody m_Body;

	private void Awake()
	{
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
