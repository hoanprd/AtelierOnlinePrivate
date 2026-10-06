using System;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using UnityEngine;

internal class NetworkingPeer : LoadBalancingPeer, IPhotonPeerListener
{
	protected internal string AppId;

	private string tokenCache;

	public AuthModeOption AuthMode;

	public EncryptionMode EncryptionMode;

	public const string NameServerHost = "ns.exitgames.com";

	public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

	private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

	public bool IsInitialConnect;

	public bool insideLobby;

	protected internal List<TypedLobbyInfo> LobbyStatistics;

	public Dictionary<string, RoomInfo> mGameList;

	public RoomInfo[] mGameListCopy;

	private string playername;

	private bool mPlayernameHasToBeUpdated;

	private Room currentRoom;

	private JoinType lastJoinType;

	protected internal EnterRoomParams enterRoomParamsCache;

	private bool didAuthenticate;

	private string[] friendListRequested;

	private int friendListTimestamp;

	private bool isFetchingFriendList;

	private string cloudCluster;

	public string CurrentCluster;

	public Dictionary<int, PhotonPlayer> mActors;

	public PhotonPlayer[] mOtherPlayerListCopy;

	public PhotonPlayer[] mPlayerListCopy;

	public bool hasSwitchedMC;

	private HashSet<byte> allowedReceivingGroups;

	private HashSet<byte> blockSendingGroups;

	protected internal Dictionary<int, PhotonView> photonViewList;

	private readonly PhotonStream readStream;

	private readonly PhotonStream pStream;

	private readonly Dictionary<int, Hashtable> dataPerGroupReliable;

	private readonly Dictionary<int, Hashtable> dataPerGroupUnreliable;

	protected internal short currentLevelPrefix;

	protected internal bool loadingLevelAndPausedNetwork;

	protected internal const string CurrentSceneProperty = "curScn";

	protected internal const string CurrentScenePropertyLoadAsync = "curScnLa";

	public static bool UsePrefabCache;

	internal IPunPrefabPool ObjectPool;

	public static Dictionary<string, GameObject> PrefabCache;

	private Dictionary<Type, List<MethodInfo>> monoRPCMethodsCache;

	private readonly Dictionary<string, int> rpcShortcuts;

	private static readonly string OnPhotonInstantiateString;

	private string cachedServerAddress;

	private string cachedApplicationName;

	private ServerConnection cachedServerType;

	private AsyncOperation _AsyncLevelLoadingOperation;

	private RaiseEventOptions _levelReloadEventOptions;

	private bool _isReconnecting;

	private readonly Type typePunRPC;

	private readonly Type typePhotonMessageInfo;

	private readonly object keyByteZero;

	private readonly object keyByteOne;

	private readonly object keyByteTwo;

	private readonly object keyByteThree;

	private readonly object keyByteFour;

	private readonly object keyByteFive;

	private readonly object[] emptyObjectArray;

	private readonly Type[] emptyTypeArray;

	private Dictionary<int, object[]> tempInstantiationData;

	private readonly Hashtable reusedRpcEvent;

	public static int ObjectsInOneUpdate;

	private RaiseEventOptions options;

	public const int SyncViewId = 0;

	public const int SyncCompressed = 1;

	public const int SyncNullValues = 2;

	public const int SyncFirstValue = 3;

	public bool IsReloadingLevel;

	public bool AsynchLevelLoadCall;

	protected internal string AppVersion
	{
		get
		{
			return null;
		}
	}

	public AuthenticationValues AuthValues { get; set; }

	private string TokenForInit
	{
		get
		{
			return null;
		}
	}

	public bool IsUsingNameServer { get; protected internal set; }

	public string NameServerAddress
	{
		get
		{
			return null;
		}
	}

	public string MasterServerAddress { get; protected internal set; }

	public string GameServerAddress { get; protected internal set; }

	protected internal ServerConnection Server { get; private set; }

	public ClientState State { get; internal set; }

	public TypedLobby lobby { get; set; }

	private bool requestLobbyStatistics
	{
		get
		{
			return false;
		}
	}

	public string PlayerName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Room CurrentRoom
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public PhotonPlayer LocalPlayer { get; internal set; }

	public int PlayersOnMasterCount { get; internal set; }

	public int PlayersInRoomsCount { get; internal set; }

	public int RoomsCount { get; internal set; }

	protected internal int FriendListAge
	{
		get
		{
			return 0;
		}
	}

	public bool IsAuthorizeSecretAvailable
	{
		get
		{
			return false;
		}
	}

	public List<Region> AvailableRegions { get; protected internal set; }

	public CloudRegionCode CloudRegion { get; protected internal set; }

	public int mMasterClientId
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public NetworkingPeer(string playername, ConnectionProtocol connectionProtocol)
		: base(ConnectionProtocol.Udp)
	{
	}

	private string GetNameServerAddress()
	{
		return null;
	}

	public override bool Connect(string serverAddress, string applicationName)
	{
		return false;
	}

	public bool ReconnectToMaster()
	{
		return false;
	}

	public bool ReconnectAndRejoin()
	{
		return false;
	}

	public bool Connect(string serverAddress, ServerConnection type)
	{
		return false;
	}

	private bool Reconnect()
	{
		return false;
	}

	public bool ConnectToNameServer()
	{
		return false;
	}

	public bool ConnectToRegionMaster(CloudRegionCode region, string specificCluster = null)
	{
		return false;
	}

	protected internal void SetupProtocol(ServerConnection serverType)
	{
	}

	public override void Disconnect()
	{
	}

	private bool CallAuthenticate()
	{
		return false;
	}

	private void DisconnectToReconnect()
	{
	}

	public bool GetRegions()
	{
		return false;
	}

	public override bool OpFindFriends(string[] friendsToFind, FindFriendsOptions findFriendsOptions = null)
	{
		return false;
	}

	public bool OpCreateGame(EnterRoomParams enterRoomParams)
	{
		return false;
	}

	public override bool OpJoinRoom(EnterRoomParams opParams)
	{
		return false;
	}

	public override bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
	{
		return false;
	}

	public override bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
	{
		return false;
	}

	private void ReadoutProperties(Hashtable gameProperties, Hashtable pActorProperties, int targetActorNr)
	{
	}

	private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
	{
		return null;
	}

	public void ChangeLocalID(int newID)
	{
	}

	private void LeftLobbyCleanup()
	{
	}

	private void LeftRoomCleanup()
	{
	}

	protected internal void LocalCleanupAnythingInstantiated(bool destroyInstantiatedGameObjects)
	{
	}

	private void GameEnteredOnGameServer(OperationResponse operationResponse)
	{
	}

	private void AddNewPlayer(int ID, PhotonPlayer player)
	{
	}

	private void RemovePlayer(int ID, PhotonPlayer player)
	{
	}

	private void RebuildPlayerListCopies()
	{
	}

	private void ResetPhotonViewsOnSerialize()
	{
	}

	private void HandleEventLeave(int actorID, EventData evLeave)
	{
	}

	private void CheckMasterClient(int leavingPlayerId)
	{
	}

	protected internal void UpdateMasterClient()
	{
	}

	private static int ReturnLowestPlayerId(PhotonPlayer[] players, int playerIdToIgnore)
	{
		return 0;
	}

	protected internal bool SetMasterClient(int playerId, bool sync)
	{
		return false;
	}

	public bool SetMasterClient(int nextMasterId)
	{
		return false;
	}

	protected internal PhotonPlayer GetPlayerWithId(int number)
	{
		return null;
	}

	private void SendPlayerName()
	{
	}

	private Hashtable GetLocalActorProperties()
	{
		return null;
	}

	public void DebugReturn(DebugLevel level, string message)
	{
	}

	public void OnOperationResponse(OperationResponse operationResponse)
	{
	}

	public void OnStatusChanged(StatusCode statusCode)
	{
	}

	public void OnEvent(EventData photonEvent)
	{
	}

	public void OnMessage(object messages)
	{
	}

	private void SetupEncryption(Dictionary<byte, object> encryptionData)
	{
	}

	protected internal void UpdatedActorList(int[] actorsInRoom)
	{
	}

	private void SendVacantViewIds()
	{
	}

	public static void SendMonoMessage(PhotonNetworkingMessage methodString, params object[] parameters)
	{
	}

	protected internal void ExecuteRpc(Hashtable rpcData, int senderID = 0)
	{
	}

	private bool CheckTypeMatch(ParameterInfo[] methodParameters, Type[] callParameterTypes)
	{
		return false;
	}

	internal Hashtable SendInstantiate(string prefabName, Vector3 position, Quaternion rotation, byte group, int[] viewIDs, object[] data, bool isGlobalObject)
	{
		return null;
	}

	internal GameObject DoInstantiate(Hashtable evData, PhotonPlayer photonPlayer, GameObject resourceGameObject)
	{
		return null;
	}

	private void StoreInstantiationData(int instantiationId, object[] instantiationData)
	{
	}

	public object[] FetchInstantiationData(int instantiationId)
	{
		return null;
	}

	private void RemoveInstantiationData(int instantiationId)
	{
	}

	public void DestroyPlayerObjects(int playerId, bool localOnly)
	{
	}

	public void DestroyAll(bool localOnly)
	{
	}

	protected internal void RemoveInstantiatedGO(GameObject go, bool localOnly)
	{
	}

	private void ServerCleanInstantiateAndDestroy(int instantiateId, int creatorId, bool isRuntimeInstantiated)
	{
	}

	private void SendDestroyOfPlayer(int actorNr)
	{
	}

	private void SendDestroyOfAll()
	{
	}

	private void OpRemoveFromServerInstantiationsOfPlayer(int actorNr)
	{
	}

	protected internal void RequestOwnership(int viewID, int fromOwner)
	{
	}

	protected internal void TransferOwnership(int viewID, int playerID)
	{
	}

	public bool LocalCleanPhotonView(PhotonView view)
	{
		return false;
	}

	public PhotonView GetPhotonView(int viewID)
	{
		return null;
	}

	public void RegisterPhotonView(PhotonView netView)
	{
	}

	public void OpCleanRpcBuffer(int actorNumber)
	{
	}

	public void OpRemoveCompleteCacheOfPlayer(int actorNumber)
	{
	}

	public void OpRemoveCompleteCache()
	{
	}

	private void RemoveCacheOfLeftPlayers()
	{
	}

	public void CleanRpcBufferIfMine(PhotonView view)
	{
	}

	public void OpCleanRpcBuffer(PhotonView view)
	{
	}

	public void RemoveRPCsInGroup(int group)
	{
	}

	public void SetLevelPrefix(short prefix)
	{
	}

	internal void RPC(PhotonView view, string methodName, PhotonTargets target, PhotonPlayer player, bool encrypt, params object[] parameters)
	{
	}

	public void SetInterestGroups(byte[] disableGroups, byte[] enableGroups)
	{
	}

	public void SetSendingEnabled(byte group, bool enabled)
	{
	}

	public void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups)
	{
	}

	public void NewSceneLoaded()
	{
	}

	public void RunViewUpdate()
	{
	}

	private object[] OnSerializeWrite(PhotonView view)
	{
		return null;
	}

	private void OnSerializeRead(object[] data, PhotonPlayer sender, int networkTime, short correctPrefix)
	{
	}

	private object[] DeltaCompressionWrite(object[] previousContent, object[] currentContent)
	{
		return null;
	}

	private object[] DeltaCompressionRead(object[] lastOnSerializeDataReceived, object[] incomingData)
	{
		return null;
	}

	private bool AlmostEquals(object[] lastData, object[] currentContent)
	{
		return false;
	}

	private bool AlmostEquals(object one, object two)
	{
		return false;
	}

	protected internal static bool GetMethod(MonoBehaviour monob, string methodType, out MethodInfo mi)
	{
		mi = null;
		return false;
	}

	protected internal void LoadLevelIfSynced()
	{
	}

	protected internal void SetLevelInPropsIfSynced(object levelId, bool initiatingCall, bool asyncLoading = false)
	{
	}

	private void SendLevelReloadEvent()
	{
	}

	public void SetApp(string appId, string gameVersion)
	{
	}

	public bool WebRpc(string uriPath, object parameters)
	{
		return false;
	}
}
