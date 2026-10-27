using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PhotonManager : MonoBehaviour
{
    public enum eCallback
    {
        Connect = 0,
        DisConnect = 1,
        JoinLobby = 2,
        UpdateRoomList = 3,
        JoinRoom = 4,
        LeaveRoom = 5,
        LeaveLobby = 6,
        Rejoin = 7,
        AfterLeaveConnect = 8,
        EnumMax = 9
    }

    private static PhotonManager s_scrInstance;

    public static readonly string sr_strAreaIdKey = "AreaId";
    public static readonly string sr_strRoomIdKey = "RoomId";
    public static readonly string sr_strRoomNameKey = "RoomName";
    public static readonly string sr_strUserIdKey = "UserId";
    public static readonly string sr_strFriendIdKey = "FriendId";
    public static readonly string sr_strQuestIdKey = "QuestId";
    public static readonly string sr_strLeaderCharaIDKey = "LeaderCharaID";
    public static readonly string sr_strLeaderCharaLvList = "LeaderCharaLvList";
    public static readonly string sr_strUserNameList = "UserNameList";
    public static readonly string sr_strRoomPlan = "RoomPlan";
    public static readonly string sr_strExqReadySTT = "ExqReadySTT";
    public static readonly string sr_strRoomComment = "RoomComment";
    public static readonly string sr_strExqOwnerUserID = "ExqOwnerUserID";
    public static readonly string sr_strExqFriendOnly = "ExqFriendOnly";
    public static readonly string sr_strExqNGUserIDList = "ExqNGUserIDList";
    public static readonly string sr_strExqRetireUserIDList = "ExqRetireUserIDList";
    public static readonly string sr_strExqLockQuestIDList = "ExqLockQuestIDList";

    private Action<bool, string>[] m_acCallback = new Action<bool, string>[(int)eCallback.EnumMax];
    private bool m_bCreateRoom;
    private bool m_bPhotonNetwork;
    private static bool m_bTimeOut;
    private static bool m_bTimeOut_Log;
    private string m_strRoomName;
    private int m_iPriorityUINum;
    private List<Func<bool>> m_fcEndFuncList = new List<Func<bool>>();
    private Coroutine m_cSuspendCoroutine;
    private static bool m_bForceHost;

    public static PhotonManager Instance => s_scrInstance;

    public static bool IsTimeOut
    {
        get => m_bTimeOut;
        set => m_bTimeOut = value;
    }

    public static bool IsTimeOut_Log
    {
        get => m_bTimeOut_Log;
        set => m_bTimeOut_Log = value;
    }

    public static bool IsForceHost
    {
        get => m_bForceHost;
        set => m_bForceHost = value;
    }

    private void Awake()
    {
        if (s_scrInstance != null && s_scrInstance != this)
        {
            Destroy(gameObject);
            return;
        }
        s_scrInstance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnDestroy()
    {
        if (s_scrInstance == this)
        {
            s_scrInstance = null;
        }
    }

    private void Update()
    {
    }

    private void SetCallback(eCallback eKind, Action<bool, string> acCallback)
    {
        if (m_acCallback == null)
        {
            m_acCallback = new Action<bool, string>[(int)eCallback.EnumMax];
        }
        m_acCallback[(int)eKind] = acCallback;
    }

    private bool CallCallBack(eCallback eKind, bool bSuccess, string strMessage)
    {
        int index = (int)eKind;
        if (m_acCallback != null && index >= 0 && index < m_acCallback.Length && m_acCallback[index] != null)
        {
            Action<bool, string> callback = m_acCallback[index];
            m_acCallback[index] = null;
            callback(bSuccess, strMessage);
            return true;
        }
        return false;
    }

    public bool IsOffline()
    {
        return PhotonNetwork.offlineMode;
    }

    public bool IsNetwork()
    {
        return PhotonNetwork.connected;
    }

    public bool IsConnected(bool bArrowOffline)
    {
        if (bArrowOffline && IsOffline()) return true;
        return PhotonNetwork.connectedAndReady;
    }

    public bool IsInRoom()
    {
        return PhotonNetwork.inRoom;
    }

    public void SetPriorityUI(bool bAdd, Func<bool> fcEndFunc = null)
    {
        if (bAdd)
        {
            m_iPriorityUINum++;
            if (fcEndFunc != null)
            {
                m_fcEndFuncList.Add(fcEndFunc);
            }
        }
        else
        {
            m_iPriorityUINum = Mathf.Max(0, m_iPriorityUINum - 1);
            if (fcEndFunc != null)
            {
                m_fcEndFuncList.Remove(fcEndFunc);
            }
        }
    }

    public void Connect(bool bOffline = false, Action<bool, string> acConnect = null)
    {
        SetCallback(eCallback.Connect, acConnect);
        PhotonNetwork.offlineMode = bOffline;
        if (!PhotonNetwork.connected)
        {
            PhotonNetwork.ConnectUsingSettings("1.0");
        }
        else
        {
            CallCallBack(eCallback.Connect, true, string.Empty);
        }
    }

    public void OnConnectedToMaster()
    {
        CallCallBack(eCallback.Connect, true, string.Empty);
    }

    public void Disconnect(Action<bool, string> acDisConnect = null)
    {
        SetCallback(eCallback.DisConnect, acDisConnect);
        PhotonNetwork.Disconnect();
    }

    public void OnConnectionFail(DisconnectCause cause)
    {
        CallCallBack(eCallback.Connect, false, cause.ToString());
        CallCallBack(eCallback.DisConnect, true, string.Empty);
    }

    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        CallCallBack(eCallback.Connect, false, cause.ToString());
    }

    public void OnDisconnectedFromPhoton()
    {
        CallCallBack(eCallback.DisConnect, true, string.Empty);
        CallCallBack(eCallback.JoinLobby, false, "Disconnected");
        CallCallBack(eCallback.JoinRoom, false, "Disconnected");
        CallCallBack(eCallback.Rejoin, false, "Disconnected");
    }

    public void JoinLobby(Action<bool, string> acJoinLobby = null, Action<bool, string> acUpdateRoomList = null)
    {
        SetCallback(eCallback.JoinLobby, acJoinLobby);
        SetCallback(eCallback.UpdateRoomList, acUpdateRoomList);
        if (PhotonNetwork.connected && !PhotonNetwork.insideLobby)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    public void OnJoinedLobby()
    {
        CallCallBack(eCallback.JoinLobby, true, string.Empty);
    }

    public void OnReceivedRoomListUpdate()
    {
        CallCallBack(eCallback.UpdateRoomList, true, string.Empty);
    }

    public void JoinOrCreateRoom(bool bForceCreate, Action<bool, string> acJoinRoom = null)
    {
        JoinOrCreateRoom(bForceCreate, "DefaultRoom", acJoinRoom);
    }

    public void JoinOrCreateRoom(bool bForceCreate, string sRoomName, Action<bool, string> acJoinRoom = null, string sRoomGroupName = "", Dictionary<string, object> dicCustomOption = null)
    {
        m_strRoomName = sRoomName;
        SetCallback(eCallback.JoinRoom, acJoinRoom);
        RoomOptions roomOptions = new RoomOptions
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = 4
        };

        if (dicCustomOption != null)
        {
            SetCustomPropertiesHashData(ref roomOptions, dicCustomOption);
        }

        if (bForceCreate)
        {
            PhotonNetwork.CreateRoom(sRoomName, roomOptions, TypedLobby.Default);
        }
        else
        {
            PhotonNetwork.JoinOrCreateRoom(sRoomName, roomOptions, TypedLobby.Default);
        }
    }

    private void SetDicOptionParam(ref Dictionary<string, object> dic, string setKey, object setDefaultData)
    {
        if (dic != null && !dic.ContainsKey(setKey))
        {
            dic[setKey] = setDefaultData;
        }
    }

    private void SetCustomPropertiesHashData(ref RoomOptions clsRoomOption, Dictionary<string, object> dicSetOption)
    {
        if (clsRoomOption.CustomRoomProperties == null)
        {
            clsRoomOption.CustomRoomProperties = new ExitGames.Client.Photon.Hashtable();
        }
        foreach (KeyValuePair<string, object> pair in dicSetOption)
        {
            clsRoomOption.CustomRoomProperties[pair.Key] = pair.Value;
        }
    }

    public void JoinRoom(string strRoomName, Action<bool, string> acJoinRoom = null)
    {
        m_strRoomName = strRoomName;
        SetCallback(eCallback.JoinRoom, acJoinRoom);
        PhotonNetwork.JoinRoom(strRoomName);
    }

    public void OnCreatedRoom()
    {
    }

    public void OnPhotonCreateRoomFailed(object[] codeAndMsg)
    {
        string msg = codeAndMsg != null && codeAndMsg.Length > 1 ? codeAndMsg[1].ToString() : "Create Room Failed";
        CallCallBack(eCallback.JoinRoom, false, msg);
    }

    public void OnJoinedRoom()
    {
        CallCallBack(eCallback.JoinRoom, true, string.Empty);
        CallCallBack(eCallback.Rejoin, true, string.Empty);
    }

    public void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
        string msg = codeAndMsg != null && codeAndMsg.Length > 1 ? codeAndMsg[1].ToString() : "Join Room Failed";
        CallCallBack(eCallback.JoinRoom, false, msg);
    }

    public void SearchFriendRoom(string strRoomName, long lFriendId, Action<bool, string, int> acSearchRoom = null)
    {
    }

    public string GetLatestRoomName()
    {
        return m_strRoomName;
    }

    public void OnMasterClientSwitched(PhotonPlayer clsMC)
    {
    }

    public void LeaveRoom(Action<bool, string> acLeaveRoom = null, Action<bool, string> acAfterLeaveConnect = null)
    {
        SetCallback(eCallback.LeaveRoom, acLeaveRoom);
        SetCallback(eCallback.AfterLeaveConnect, acAfterLeaveConnect);
        if (PhotonNetwork.inRoom)
        {
            PhotonNetwork.LeaveRoom();
        }
        else
        {
            CallCallBack(eCallback.LeaveRoom, true, string.Empty);
        }
    }

    public void OnLeftRoom()
    {
        CallCallBack(eCallback.LeaveRoom, true, string.Empty);
        CallCallBack(eCallback.AfterLeaveConnect, true, string.Empty);
    }

    public void LeaveLobby(Action<bool, string> acLeaveLobby = null)
    {
        SetCallback(eCallback.LeaveLobby, acLeaveLobby);
        if (PhotonNetwork.insideLobby)
        {
            PhotonNetwork.LeaveLobby();
        }
    }

    public void OnLeftLobby()
    {
        CallCallBack(eCallback.LeaveLobby, true, string.Empty);
    }

    private void RejoinRoom(Action<bool, string> acCallback)
    {
        SetCallback(eCallback.Rejoin, acCallback);
        if (!string.IsNullOrEmpty(m_strRoomName))
        {
            PhotonNetwork.ReconnectAndRejoin();
        }
        else
        {
            CallCallBack(eCallback.Rejoin, false, "Room name is empty");
        }
    }

    private void OnRejoinRoom(bool bSuccess, string strMessage)
    {
        CallCallBack(eCallback.Rejoin, bSuccess, strMessage);
    }

    [DebuggerHidden]
    private IEnumerator NewRoomProc()
    {
        yield return null;
    }

    private bool IsExistPriorityUI()
    {
        return m_iPriorityUINum > 0 || (m_fcEndFuncList != null && m_fcEndFuncList.Count > 0);
    }

    public static bool IsConnectInternet()
    {
        return Application.internetReachability != NetworkReachability.NotReachable;
    }

    private void MakeNewRoom(bool bMulti)
    {
    }

    public static PhotonPlayer GetPlayer(int iID)
    {
        return PhotonPlayer.Find(iID);
    }

    public List<RoomInfo> GetExqRoomList(string targetName = "", string beforeRoomName = "", bool isExqUserFilter = false, bool isExcludeMySelf = false, bool isIgnoreProgress = false)
    {
        RoomInfo[] rooms = PhotonNetwork.GetRoomList();
        if (rooms == null) return null;
        return new List<RoomInfo>(rooms);
    }

    private bool isValidExqRoomList(RoomInfo target, bool isExqUserFilter = false, bool isExcludeMySelf = false, bool isIgnoreProgress = false)
    {
        return target != null;
    }

    private void PrintCallbackState()
    {
    }
}