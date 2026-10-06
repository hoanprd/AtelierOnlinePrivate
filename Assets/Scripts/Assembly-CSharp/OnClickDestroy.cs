using System.Collections;
using System.Diagnostics;
using Photon;

public class OnClickDestroy : MonoBehaviour
{
	public bool DestroyByRpc;

	public void OnClick()
	{
	}

	[DebuggerHidden]
	[PunRPC]
	public IEnumerator DestroyRpc()
	{
		return null;
	}
}
