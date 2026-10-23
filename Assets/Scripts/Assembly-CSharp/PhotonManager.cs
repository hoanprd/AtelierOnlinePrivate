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

    public static readonly string sr_strAreaIdKey;

    public static readonly string sr_strRoomIdKey;

    public static readonly string sr_strRoomNameKey;

    public static readonly string sr_strUserIdKey;

    public static readonly string sr_strFriendIdKey;

    public static readonly string sr_strQuestIdKey;

    public static readonly string sr_strLeaderCharaIDKey;

    public static readonly string sr_strLeaderCharaLvList;

    public static readonly string sr_strUserNameList;

    public static readonly string sr_strRoomPlan;

    public static readonly string sr_strExqReadySTT;

    public static readonly string sr_strRoomComment;

    public static readonly string sr_strExqOwnerUserID;

    public static readonly string sr_strExqFriendOnly;

    public static readonly string sr_strExqNGUserIDList;

    public static readonly string sr_strExqRetireUserIDList;

    public static readonly string sr_strExqLockQuestIDList;

    private Action<bool, string>[] m_acCallback;

    private bool m_bCreateRoom;

    private bool m_bPhotonNetwork;

    private static bool m_bTimeOut;

    private static bool m_bTimeOut_Log;

    private string m_strRoomName;

    private int m_iPriorityUINum;

    private List<Func<bool>> m_fcEndFuncList;

    private Coroutine m_cSuspendCoroutine;

    private static bool m_bForceHost;

    public static PhotonManager Instance
    {
        get
        {
            return s_scrInstance;
        }
    }

    public static bool IsTimeOut
    {
        get
        {
            return m_bTimeOut;
        }
        set
        {
            m_bTimeOut = value;
        }
    }

    public static bool IsTimeOut_Log
    {
        get
        {
            return m_bTimeOut_Log;
        }
        set
        {
            m_bTimeOut_Log = value;
        }
    }

    public static bool IsForceHost
    {
        get
        {
            return m_bForceHost;
        }
        set
        {
            m_bForceHost = value;
        }
    }

    private void Awake()
    {
        if (s_scrInstance != null && s_scrInstance != this)
        {
            Destroy(gameObject);
            return;
        }
        s_scrInstance = this;
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
    }

    private bool CallCallBack(eCallback eKind, bool bSuccess, string strMessage)
    {
        return false;
    }

    public bool IsOffline()
    {
        return false;
    }

    public bool IsNetwork()
    {
        return false;
    }

    public bool IsConnected(bool bArrowOffline)
    {
        return false;
    }

    public bool IsInRoom()
    {
        return false;
    }

    public void SetPriorityUI(bool bAdd, Func<bool> fcEndFunc = null)
    {
    }

    public void Connect(bool bOffline = false, Action<bool, string> acConnect = null)
    {
    }

    public void OnConnectedToMaster()
    {
    }

    public void Disconnect(Action<bool, string> acDisConnect = null)
    {
        if (acDisConnect != null)
        {
            acDisConnect(true, string.Empty);
        }
    }

    public void OnConnectionFail(DisconnectCause cause)
    {
    }

    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
    }

    public void OnDisconnectedFromPhoton()
    {
    }

    public void JoinLobby(Action<bool, string> acJoinLobby = null, Action<bool, string> acUpdateRoomList = null)
    {
    }

    public void OnJoinedLobby()
    {
    }

    public void OnReceivedRoomListUpdate()
    {
    }

    public void JoinOrCreateRoom(bool bForceCreate, Action<bool, string> acJoinRoom = null)
    {
    }

    public void JoinOrCreateRoom(bool bForceCreate, string sRoomName, Action<bool, string> acJoinRoom = null, string sRoomGroupName = "", Dictionary<string, object> dicCustomOption = null)
    {
    }

    private void SetDicOptionParam(ref Dictionary<string, object> dic, string setKey, object setDefaultData)
    {
    }

    private void SetCustomPropertiesHashData(ref RoomOptions clsRoomOption, Dictionary<string, object> dicSetOption)
    {
    }

    public void JoinRoom(string strRoomName, Action<bool, string> acJoinRoom = null)
    {
    }

    public void OnCreatedRoom()
    {
    }

    public void OnPhotonCreateRoomFailed(object[] codeAndMsg)
    {
    }

    public void OnJoinedRoom()
    {
    }

    public void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
    }

    public void SearchFriendRoom(string strRoomName, long lFriendId, Action<bool, string, int> acSearchRoom = null)
    {
    }

    public string GetLatestRoomName()
    {
        return null;
    }

    public void OnMasterClientSwitched(PhotonPlayer clsMC)
    {
    }

    public void LeaveRoom(Action<bool, string> acLeaveRoom = null, Action<bool, string> acAfterLeaveConnect = null)
    {
    }

    public void OnLeftRoom()
    {
    }

    public void LeaveLobby(Action<bool, string> acLeaveLobby = null)
    {
    }

    public void OnLeftLobby()
    {
    }

    private void RejoinRoom(Action<bool, string> acCallback)
    {
    }

    private void OnRejoinRoom(bool bSuccess, string strMessage)
    {
    }

    [DebuggerHidden]
    private IEnumerator NewRoomProc()
    {
        return null;
    }

    private bool IsExistPriorityUI()
    {
        return false;
    }

    public static bool IsConnectInternet()
    {
        return false;
    }

    private void MakeNewRoom(bool bMulti)
    {
    }

    public static PhotonPlayer GetPlayer(int iID)
    {
        return null;
    }

    public List<RoomInfo> GetExqRoomList(string targetName = "", string beforeRoomName = "", bool isExqUserFilter = false, bool isExcludeMySelf = false, bool isIgnoreProgress = false)
    {
        return null;
    }

    private bool isValidExqRoomList(RoomInfo target, bool isExqUserFilter = false, bool isExcludeMySelf = false, bool isIgnoreProgress = false)
    {
        return false;
    }

    private void PrintCallbackState()
    {
    }
}