using Photon;

public class OnAwakeUsePhotonView : MonoBehaviour
{
	private void Awake()
	{
	}

	private void Start()
	{
	}

	[PunRPC]
	public void OnAwakeRPC()
	{
	}

	[PunRPC]
	public void OnAwakeRPC(byte myParameter)
	{
	}
}
