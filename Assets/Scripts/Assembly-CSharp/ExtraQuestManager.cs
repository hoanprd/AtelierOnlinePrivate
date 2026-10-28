using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ExtraQuestManager : MonoBehaviour
{
	private static ExtraQuestManager sInstance;

	private bool m_isAlreadyClear;

	private bool m_isAlreadyRetire;

	private bool m_isKillTargets;

	private int m_keyCharaNum;

	private int m_prevAreaID;

	private int m_roomPlanID;

	private bool m_bReadyLock;

	private bool m_bIsAlreadyleaveDungeon;

	private string m_sBeforeRoomName = string.Empty;

	public string m_returnRoomName = string.Empty;

	public ExtraQuestRetireDialogMng m_retireDialogWindow;

	private bool m_finishQuestClearApi;

	private bool m_finishGetClonePartyData;

	private bool m_finishStartAnimation;

	private bool m_ExistStartAnimation;

	private bool m_finishRetireAnimation;

	private bool m_finishRemoveNGUser;

	private bool m_isCheckExistOwner;

	private int m_targetKillCount;

	private int m_questDF;

	private int m_TryingOrderQuestDF;

	[SerializeField]
	private GameObject colliderObj;

	public static ExtraQuestManager Instance
	{
		get
		{
			return sInstance;
		}
	}

	public bool IsAlreadyClear
	{
		get
		{
			return m_isAlreadyClear;
		}
	}

	public bool IsAlreadyRetire
	{
		get
		{
			return m_isAlreadyRetire;
		}
	}

	public bool IsKillTargets
	{
		get
		{
			return m_isKillTargets;
		}
	}

	public int KeyCharaNum
	{
		get
		{
			return m_keyCharaNum;
		}
	}

	public int PrevAreaID
	{
		get
		{
			return m_prevAreaID;
		}
		set
		{
			m_prevAreaID = value;
		}
	}

	public int RoomPlanID
	{
		get
		{
			return m_roomPlanID;
		}
		set
		{
			m_roomPlanID = value;
		}
	}

	public bool ReadyLock
	{
		get
		{
			return m_bReadyLock;
		}
		set
		{
			m_bReadyLock = value;
		}
	}

	public bool IsAlreadyLeaveDungeon
	{
		get
		{
			return m_bIsAlreadyleaveDungeon;
		}
		set
		{
			m_bIsAlreadyleaveDungeon = value;
		}
	}

	public string BeforeRoomName
	{
		get
		{
			return m_sBeforeRoomName;
		}
		set
		{
			m_sBeforeRoomName = value;
		}
	}

	private void Awake()
	{
		sInstance = this;
		if (base.transform.parent == null)
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
		ActivateCollider(false);
	}

	public void QuestStartInitialize()
	{
		m_isAlreadyClear = false;
		m_isAlreadyRetire = false;
		m_isKillTargets = false;
		m_bIsAlreadyleaveDungeon = false;
	}

	public bool IsExtraQuestMode()
	{
		return false;
	}

	public bool IsOwner()
	{
		return true;
	}

	public bool ExistsOwner()
	{
		return true;
	}

	public void ConfirmNotExistsOwner()
	{
	}

	public void SetEnableCheckExistOwner(bool enable)
	{
		m_isCheckExistOwner = enable;
	}

	public void ExecQuestStartAnimation()
	{
		StartCoroutine(StartAnimationProc());
	}

	[DebuggerHidden]
	private IEnumerator StartAnimationProc()
	{
		m_finishStartAnimation = true;
		yield break;
	}

	public bool IsClear()
	{
		return m_isAlreadyClear;
	}

	public void LeaveDungeonCallBack()
	{
		m_bIsAlreadyleaveDungeon = true;
	}

	public void CheckQuestClear(int[] killEnemys)
	{
	}

	public void NoticeQusetClearInPhoton()
	{
	}

	public void ExecClear(int keyCharaNum)
	{
		m_keyCharaNum = keyCharaNum;
		m_isAlreadyClear = true;
	}

	public void ClearProc()
	{
	}

	[DebuggerHidden]
	private IEnumerator SendExtraQuestClear()
	{
		m_finishQuestClearApi = true;
		yield break;
	}

	[DebuggerHidden]
	private IEnumerator SendResult()
	{
		yield break;
	}

	private void QuestClearCallBack(ResponseDataCommon res)
	{
		m_finishQuestClearApi = true;
	}

	private void ClonePirtyCharaCallBack()
	{
		m_finishGetClonePartyData = true;
	}

	public void ExecRetire()
	{
		m_isAlreadyRetire = true;
	}

	public void RegistRetireUserID(string targetUserId)
	{
	}

	public void RetireAnimationCallBack()
	{
		m_finishRetireAnimation = true;
	}

	public void RemoveNGUserCallBack()
	{
		m_finishRemoveNGUser = true;
	}

	[DebuggerHidden]
	private IEnumerator RetireProc()
	{
		yield break;
	}

	public void Retire_ExtraQuest(Action callback)
	{
		StartCoroutine(ExecRetireExtraQuest(callback));
	}

	[DebuggerHidden]
	public IEnumerator ExecRetireExtraQuest(Action callback)
	{
		if (callback != null)
		{
			callback();
		}
		yield break;
	}

	public void Enter_ExtraQuestMenu(Action callback, string enterRoomName = "")
	{
		StartCoroutine(ExecEnterExtraQuest(callback, enterRoomName));
	}

	[DebuggerHidden]
	public IEnumerator ExecEnterExtraQuest(Action callback, string enterRoomName = "")
	{
		if (callback != null)
		{
			callback();
		}
		yield break;
	}

	private void ReEnterExtraQuest()
	{
	}

	[DebuggerHidden]
	private IEnumerator ExecReEnterExtraQuest()
	{
		yield break;
	}

	public void ExecEnterExtraQuestWaitUntilEnterAcademy(Action callback, string roomName = "")
	{
		StartCoroutine(EnterExtraQuestWaitUntilEnterAcademy(callback, roomName));
	}

	[DebuggerHidden]
	public IEnumerator EnterExtraQuestWaitUntilEnterAcademy(Action callback, string roomName = "")
	{
		if (callback != null)
		{
			callback();
		}
		yield break;
	}

	public void ResetOrderQuest(EQuestGroup group, Action callback = null)
	{
		if (callback != null)
		{
			callback();
		}
	}

	public void CancelQuestBackyard(int iQuestDf, Action callback = null)
	{
		if (callback != null)
		{
			callback();
		}
	}

	public bool IsUnLockQuest(int questDf)
	{
		return true;
	}

	public void ReceiveExtraQuest(int questId)
	{
		m_questDF = questId;
	}

	public void ExecForceExitRoom()
	{
	}

	public void ActivateCollider(bool active)
	{
		if (colliderObj != null)
		{
			colliderObj.SetActive(active);
		}
	}
}
