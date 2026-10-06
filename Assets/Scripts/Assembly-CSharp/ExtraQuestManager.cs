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

	private string m_sBeforeRoomName;

	public string m_returnRoomName;

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
			return null;
		}
	}

	public bool IsAlreadyClear
	{
		get
		{
			return false;
		}
	}

	public bool IsAlreadyRetire
	{
		get
		{
			return false;
		}
	}

	public bool IsKillTargets
	{
		get
		{
			return false;
		}
	}

	public int KeyCharaNum
	{
		get
		{
			return 0;
		}
	}

	public int PrevAreaID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int RoomPlanID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool ReadyLock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAlreadyLeaveDungeon
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string BeforeRoomName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void QuestStartInitialize()
	{
	}

	public bool IsExtraQuestMode()
	{
		return false;
	}

	public bool IsOwner()
	{
		return false;
	}

	public bool ExistsOwner()
	{
		return false;
	}

	public void ConfirmNotExistsOwner()
	{
	}

	public void SetEnableCheckExistOwner(bool enable)
	{
	}

	public void ExecQuestStartAnimation()
	{
	}

	[DebuggerHidden]
	private IEnumerator StartAnimationProc()
	{
		return null;
	}

	public bool IsClear()
	{
		return false;
	}

	public void LeaveDungeonCallBack()
	{
	}

	public void CheckQuestClear(int[] killEnemys)
	{
	}

	public void NoticeQusetClearInPhoton()
	{
	}

	public void ExecClear(int keyCharaNum)
	{
	}

	public void ClearProc()
	{
	}

	[DebuggerHidden]
	private IEnumerator SendExtraQuestClear()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator SendResult()
	{
		return null;
	}

	private void QuestClearCallBack(ResponseDataCommon res)
	{
	}

	private void ClonePirtyCharaCallBack()
	{
	}

	public void ExecRetire()
	{
	}

	public void RegistRetireUserID(string targetUserId)
	{
	}

	public void RetireAnimationCallBack()
	{
	}

	public void RemoveNGUserCallBack()
	{
	}

	[DebuggerHidden]
	private IEnumerator RetireProc()
	{
		return null;
	}

	public void Retire_ExtraQuest(Action callback)
	{
	}

	[DebuggerHidden]
	public IEnumerator ExecRetireExtraQuest(Action callback)
	{
		return null;
	}

	public void Enter_ExtraQuestMenu(Action callback, string enterRoomName = "")
	{
	}

	[DebuggerHidden]
	public IEnumerator ExecEnterExtraQuest(Action callback, string enterRoomName = "")
	{
		return null;
	}

	private void ReEnterExtraQuest()
	{
	}

	[DebuggerHidden]
	private IEnumerator ExecReEnterExtraQuest()
	{
		return null;
	}

	public void ExecEnterExtraQuestWaitUntilEnterAcademy(Action callback, string roomName = "")
	{
	}

	[DebuggerHidden]
	public IEnumerator EnterExtraQuestWaitUntilEnterAcademy(Action callback, string roomName = "")
	{
		return null;
	}

	public void ResetOrderQuest(EQuestGroup group, Action callback = null)
	{
	}

	public void CancelQuestBackyard(int iQuestDf, Action callback = null)
	{
	}

	public bool IsUnLockQuest(int questDf)
	{
		return false;
	}

	public void ReceiveExtraQuest(int questId)
	{
	}

	public void ExecForceExitRoom()
	{
	}

	public void ActivateCollider(bool active)
	{
	}
}
