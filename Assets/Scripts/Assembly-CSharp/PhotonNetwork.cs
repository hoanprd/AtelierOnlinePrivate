using System;
using System.Collections.Generic;
using System.Diagnostics;
using ExitGames.Client.Photon;
using UnityEngine;

public static class PhotonNetwork
{
	public delegate void EventCallback(byte eventCode, object content, int senderId);

	public const string versionPUN = "1.103.1";

	internal static readonly PhotonHandler photonMono;

	internal static NetworkingPeer networkingPeer;

	public static readonly int MAX_VIEW_IDS;

	internal const string serverSettingsAssetFile = "PhotonServerSettings";

	public static ServerSettings PhotonServerSettings;

	public static bool InstantiateInRoomOnly;

	public static PhotonLogLevel logLevel;

	public static float precisionForVectorSynchronization;

	public static float precisionForQuaternionSynchronization;

	public static float precisionForFloatSynchronization;

	public static bool UseRpcMonoBehaviourCache;

	public static bool UsePrefabCache;

	public static Dictionary<string, GameObject> PrefabCache;

	public static HashSet<GameObject> SendMonoMessageTargets;

	public static Type SendMonoMessageTargetType;

	public static bool StartRpcsAsCoroutine;

	private static bool isOfflineMode;

	private static Room offlineModeRoom;

	[Obsolete]
	public static int maxConnections;

	private static bool _mAutomaticallySyncScene;

	private static bool m_autoCleanUpPlayerObjects;

	private static int sendInterval;

	private static int sendIntervalOnSerialize;

	private static bool m_isMessageQueueRunning;

	private static Stopwatch startupStopwatch;

	public static float BackgroundTimeout;

	private static EventCallback OnEventCall__BackingField;

	internal static int lastUsedViewSubId;

	internal static int lastUsedViewSubIdStatic;

	internal static List<int> manuallyAllocatedViewIds;

	public static string gameVersion { get; set; }

	public static string ServerAddress
	{
		get
		{
			return null;
		}
	}

	public static CloudRegionCode CloudRegion
	{
		get
		{
			return CloudRegionCode.eu;
		}
	}

	public static string CurrentCluster
	{
		get
		{
			return null;
		}
	}

	public static bool connected
	{
		get
		{
			return false;
		}
	}

	public static bool connecting
	{
		get
		{
			return false;
		}
	}

	public static bool connectedAndReady
	{
		get
		{
			return false;
		}
	}

	public static ConnectionState connectionState
	{
		get
		{
			return ConnectionState.Disconnected;
		}
	}

	public static ClientState connectionStateDetailed
	{
		get
		{
			return ClientState.Uninitialized;
		}
	}

	public static ServerConnection Server
	{
		get
		{
			return ServerConnection.MasterServer;
		}
	}

	public static AuthenticationValues AuthValues
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Room room
	{
		get
		{
			return null;
		}
	}

	public static PhotonPlayer player
	{
		get
		{
			return null;
		}
	}

	public static PhotonPlayer masterClient
	{
		get
		{
			return null;
		}
	}

	public static string playerName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static PhotonPlayer[] playerList
	{
		get
		{
			return null;
		}
	}

	public static PhotonPlayer[] otherPlayers
	{
		get
		{
			return null;
		}
	}

	public static List<FriendInfo> Friends { get; internal set; }

	public static int FriendsListAge
	{
		get
		{
			return 0;
		}
	}

	public static IPunPrefabPool PrefabPool
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool offlineMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool automaticallySyncScene
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool autoCleanUpPlayerObjects
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool autoJoinLobby
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool EnableLobbyStatistics
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static List<TypedLobbyInfo> LobbyStatistics
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static bool insideLobby
	{
		get
		{
			return false;
		}
	}

	public static TypedLobby lobby
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int sendRate
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int sendRateOnSerialize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool isMessageQueueRunning
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static double time
	{
		get
		{
			return 0.0;
		}
	}

	public static int ServerTimestamp
	{
		get
		{
			return 0;
		}
	}

	public static bool isMasterClient
	{
		get
		{
			return false;
		}
	}

	public static bool inRoom
	{
		get
		{
			return false;
		}
	}

	public static bool isNonMasterClientInRoom
	{
		get
		{
			return false;
		}
	}

	public static int countOfPlayersOnMaster
	{
		get
		{
			return 0;
		}
	}

	public static int countOfPlayersInRooms
	{
		get
		{
			return 0;
		}
	}

	public static int countOfPlayers
	{
		get
		{
			return 0;
		}
	}

	public static int countOfRooms
	{
		get
		{
			return 0;
		}
	}

	public static bool NetworkStatisticsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int ResentReliableCommands
	{
		get
		{
			return 0;
		}
	}

	public static bool CrcCheckEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int PacketLossByCrcCheck
	{
		get
		{
			return 0;
		}
	}

	public static int MaxResendsBeforeDisconnect
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int QuickResends
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool UseAlternativeUdpPorts { get; set; }

	public static event EventCallback OnEventCall
	{
		add
		{
		}
		remove
		{
		}
	}

	static PhotonNetwork()
	{
	}

	public static void SwitchToProtocol(ConnectionProtocol cp)
	{
	}

	public static bool ConnectUsingSettings(string gameVersion)
	{
		return false;
	}

	public static bool ConnectToMaster(string masterServerAddress, int port, string appID, string gameVersion)
	{
		return false;
	}

	public static bool Reconnect()
	{
		return false;
	}

	public static bool ReconnectAndRejoin()
	{
		return false;
	}

	public static bool ConnectToBestCloudServer(string gameVersion)
	{
		return false;
	}

	public static bool ConnectToRegion(CloudRegionCode region, string gameVersion, string cluster = null)
	{
		return false;
	}

	public static void OverrideBestCloudServer(CloudRegionCode region)
	{
	}

	public static void RefreshCloudServerRating()
	{
	}

	public static void NetworkStatisticsReset()
	{
	}

	public static string NetworkStatisticsToString()
	{
		return null;
	}

	[Obsolete]
	public static void InitializeSecurity()
	{
	}

	private static bool VerifyCanUseNetwork()
	{
		return false;
	}

	public static void Disconnect()
	{
	}

	public static bool FindFriends(string[] friendsToFind, FindFriendsOptions options = null)
	{
		return false;
	}

	public static bool CreateRoom(string roomName)
	{
		return false;
	}

	public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
	{
		return false;
	}

	public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers)
	{
		return false;
	}

	public static bool JoinRoom(string roomName)
	{
		return false;
	}

	public static bool JoinRoom(string roomName, string[] expectedUsers)
	{
		return false;
	}

	public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
	{
		return false;
	}

	public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers)
	{
		return false;
	}

	public static bool JoinRandomRoom()
	{
		return false;
	}

	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers)
	{
		return false;
	}

	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter, string[] expectedUsers = null)
	{
		return false;
	}

	public static bool ReJoinRoom(string roomName)
	{
		return false;
	}

	private static void EnterOfflineRoom(string roomName, RoomOptions roomOptions, bool createdRoom)
	{
	}

	public static bool JoinLobby()
	{
		return false;
	}

	public static bool JoinLobby(TypedLobby typedLobby)
	{
		return false;
	}

	public static bool LeaveLobby()
	{
		return false;
	}

	public static bool LeaveRoom(bool becomeInactive = true)
	{
		return false;
	}

	public static bool GetCustomRoomList(TypedLobby typedLobby, string sqlLobbyFilter)
	{
		return false;
	}

	public static RoomInfo[] GetRoomList()
	{
		return null;
	}

	public static void SetPlayerCustomProperties(Hashtable customProperties)
	{
	}

	public static void RemovePlayerCustomProperties(string[] customPropertiesToDelete)
	{
	}

	public static bool RaiseEvent(byte eventCode, object eventContent, bool sendReliable, RaiseEventOptions options)
	{
		return false;
	}

	public static int AllocateViewID()
	{
		return 0;
	}

	public static int AllocateSceneViewID()
	{
		return 0;
	}

	private static int AllocateViewID(int ownerId)
	{
		return 0;
	}

	private static int[] AllocateSceneViewIDs(int countOfNewViews)
	{
		return null;
	}

	public static void UnAllocateViewID(int viewID)
	{
	}

	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group)
	{
		return null;
	}

	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group, object[] data)
	{
		return null;
	}

	public static GameObject InstantiateSceneObject(string prefabName, Vector3 position, Quaternion rotation, byte group, object[] data)
	{
		return null;
	}

	public static int GetPing()
	{
		return 0;
	}

	public static void FetchServerTimestamp()
	{
	}

	public static void SendOutgoingCommands()
	{
	}

	public static bool CloseConnection(PhotonPlayer kickPlayer)
	{
		return false;
	}

	public static bool SetMasterClient(PhotonPlayer masterClientPlayer)
	{
		return false;
	}

	public static void Destroy(PhotonView targetView)
	{
	}

	public static void Destroy(GameObject targetGo)
	{
	}

	public static void DestroyPlayerObjects(PhotonPlayer targetPlayer)
	{
	}

	public static void DestroyPlayerObjects(int targetPlayerId)
	{
	}

	public static void DestroyAll()
	{
	}

	public static void RemoveRPCs(PhotonPlayer targetPlayer)
	{
	}

	public static void RemoveRPCs(PhotonView targetPhotonView)
	{
	}

	public static void RemoveRPCsInGroup(int targetGroup)
	{
	}

	internal static void RPC(PhotonView view, string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
	{
	}

	internal static void RPC(PhotonView view, string methodName, PhotonPlayer targetPlayer, bool encrpyt, params object[] parameters)
	{
	}

	public static void CacheSendMonoMessageTargets(Type type)
	{
	}

	public static HashSet<GameObject> FindGameObjectsWithComponent(Type type)
	{
		return null;
	}

	[Obsolete]
	public static void SetReceivingEnabled(int group, bool enabled)
	{
	}

	public static void SetInterestGroups(byte group, bool enabled)
	{
	}

	[Obsolete]
	public static void SetReceivingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	public static void SetInterestGroups(byte[] disableGroups, byte[] enableGroups)
	{
	}

	[Obsolete]
	public static void SetSendingEnabled(int group, bool enabled)
	{
	}

	public static void SetSendingEnabled(byte group, bool enabled)
	{
	}

	[Obsolete]
	public static void SetSendingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	public static void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups)
	{
	}

	public static void SetLevelPrefix(short prefix)
	{
	}

	public static void LoadLevel(int levelNumber)
	{
	}

	public static AsyncOperation LoadLevelAsync(int levelNumber)
	{
		return null;
	}

	public static void LoadLevel(string levelName)
	{
	}

	public static AsyncOperation LoadLevelAsync(string levelName)
	{
		return null;
	}

	public static bool WebRpc(string name, object parameters)
	{
		return false;
	}

	public static bool CallEvent(byte eventCode, object content, int senderId)
	{
		return false;
	}
}
