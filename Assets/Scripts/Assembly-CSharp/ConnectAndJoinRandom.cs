using Photon;

public class ConnectAndJoinRandom : MonoBehaviour
{
	public bool AutoConnect;

	public byte Version;

	private bool ConnectInUpdate;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnConnectedToMaster()
	{
	}

	public virtual void OnJoinedLobby()
	{
	}

	public virtual void OnPhotonRandomJoinFailed()
	{
	}

	public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
	{
	}

	public void OnJoinedRoom()
	{
	}
}
