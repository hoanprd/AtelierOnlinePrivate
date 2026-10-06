using UnityEngine;

public class PhotonRigidbody2DView : MonoBehaviour, IPunObservable
{
	[SerializeField]
	private bool m_SynchronizeVelocity;

	[SerializeField]
	private bool m_SynchronizeAngularVelocity;

	private Rigidbody2D m_Body;

	private void Awake()
	{
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
