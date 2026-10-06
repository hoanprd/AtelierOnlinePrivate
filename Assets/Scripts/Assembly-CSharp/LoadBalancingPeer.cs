using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;

internal class LoadBalancingPeer : PhotonPeer
{
	private enum RoomOptionBit
	{
		CheckUserOnJoin = 1,
		DeleteCacheOnLeave = 2,
		SuppressRoomEvents = 4,
		PublishUserId = 8,
		DeleteNullProps = 0x10,
		BroadcastPropsChangeToAll = 0x20
	}

	private readonly Dictionary<byte, object> opParameters;

	internal bool IsProtocolSecure
	{
		get
		{
			return false;
		}
	}

	public LoadBalancingPeer(ConnectionProtocol protocolType)
		: base(ConnectionProtocol.Udp)
	{
	}

	public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		: base(ConnectionProtocol.Udp)
	{
	}

	public virtual bool OpGetRegions(string appId)
	{
		return false;
	}

	public virtual bool OpJoinLobby(TypedLobby lobby = null)
	{
		return false;
	}

	public virtual bool OpLeaveLobby()
	{
		return false;
	}

	private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
	{
	}

	public virtual bool OpCreateRoom(EnterRoomParams opParams)
	{
		return false;
	}

	public virtual bool OpJoinRoom(EnterRoomParams opParams)
	{
		return false;
	}

	public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
	{
		return false;
	}

	public virtual bool OpLeaveRoom(bool becomeInactive)
	{
		return false;
	}

	public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
	{
		return false;
	}

	public virtual bool OpFindFriends(string[] friendsToFind, FindFriendsOptions options = null)
	{
		return false;
	}

	public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
	{
		return false;
	}

	protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, bool webForward = false)
	{
		return false;
	}

	protected internal void OpSetPropertyOfRoom(byte propCode, object value)
	{
	}

	[Obsolete]
	public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties, bool broadcast, byte channelId)
	{
		return false;
	}

	public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, bool webForward = false)
	{
		return false;
	}

	protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, bool webForward = false)
	{
		return false;
	}

	public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
	{
		return false;
	}

	public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
	{
		return false;
	}

	public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
	{
		return false;
	}

	public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
	{
		return false;
	}

	public virtual bool OpSettings(bool receiveLobbyStats)
	{
		return false;
	}
}
