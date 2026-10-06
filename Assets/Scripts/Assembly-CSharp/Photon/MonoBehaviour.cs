using UnityEngine;

namespace Photon
{
	public class MonoBehaviour : UnityEngine.MonoBehaviour
	{
		private PhotonView pvCache;

		public PhotonView photonView
		{
			get
			{
				return null;
			}
		}
	}
}
