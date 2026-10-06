using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon;

namespace ExitGames.UtilityScripts
{
	public class PlayerRoomIndexing : PunBehaviour
	{
		public delegate void RoomIndexingChanged();

		public static PlayerRoomIndexing instance;

		public RoomIndexingChanged OnRoomIndexingChanged;

		public const string RoomPlayerIndexedProp = "PlayerIndexes";

		private int[] _playerIds;

		private object _indexes;

		private Dictionary<int, int> _indexesLUT;

		private List<bool> _indexesPool;

		private PhotonPlayer _p;

		public int[] PlayerIds
		{
			get
			{
				return null;
			}
		}

		public void Awake()
		{
		}

		public override void OnJoinedRoom()
		{
		}

		public override void OnLeftRoom()
		{
		}

		public override void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
		{
		}

		public override void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
		{
		}

		public override void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
		{
		}

		public override void OnMasterClientSwitched(PhotonPlayer newMasterClient)
		{
		}

		public int GetRoomIndex(PhotonPlayer player)
		{
			return 0;
		}

		private void SanitizeIndexing(bool forceIndexing = false)
		{
		}

		private void RefreshData()
		{
		}

		private void AssignIndex(PhotonPlayer player)
		{
		}

		private void UnAssignIndex(PhotonPlayer player)
		{
		}
	}
}
