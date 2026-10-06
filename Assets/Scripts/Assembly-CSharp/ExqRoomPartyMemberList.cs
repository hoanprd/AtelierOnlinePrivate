using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ExqRoomPartyMemberList : MonoBehaviour
{
	private const float SYNC_CHECK_TIME = 3f;

	[SerializeField]
	private GameObject m_goPrefab;

	[SerializeField]
	private AnimationController[] m_asLocRootAnim;

	private List<PartyEditMemberInfo> m_vInfoList;

	private List<PartyMember> m_vPartyMemberList;

	private List<FriendDetail> m_vFriendDetailList;

	public bool isUpdateReadyStatus;

	private bool isValidateRoomUsers;

	private int countValidateRoomUsersRecheck;

	private ExqRoomPartyManager m_partyManager;

	private PartyInfo m_party;

	public bool isActiveExistOwner;

	public bool isCheckingExistOwner;

	public bool isWaitUpdate;

	private float syncTimer;

	private Dictionary<long, FriendProfileResponse> dicClsFPRes;

	private bool m_bStockUpdate;

	public List<PartyMember> PartyMemberList
	{
		get
		{
			return null;
		}
	}

	public List<FriendDetail> FriendDetailList
	{
		get
		{
			return null;
		}
	}

	public bool CheckReadyMemberFull
	{
		get
		{
			return false;
		}
	}

	[SerializeField]
	private List<MultiPlay_CharaData> m_CheckMpCharaDataList
	{
		get
		{
			return null;
		}
	}

	private bool isSyncMultiData
	{
		get
		{
			return false;
		}
	}

	private void Update()
	{
	}

	public void Init(PartyInfo party, ExqRoomPartyManager partyManager)
	{
	}

	public void InitMemberChara()
	{
	}

	public bool IsAnimEnd()
	{
		return false;
	}

	private void CreateMemberInfoList()
	{
	}

	private void SetReadyStatus()
	{
	}

	private void ValidateRoomUsers()
	{
	}

	private void CheckSync()
	{
	}

	[DebuggerHidden]
	private IEnumerator ExistRoomOwner()
	{
		return null;
	}

	private void UpdateRoomInfo()
	{
	}

	[DebuggerHidden]
	private IEnumerator ExecUpdateRoomInfo()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator PrePareMultiData(Action callback = null)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator SetPartyInfoListData(Action callback = null)
	{
		return null;
	}

	private void ResetUpdateFlg()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void DisableChara()
	{
	}

	private void OnDissmissEnd()
	{
	}

	private void OnDisable()
	{
	}
}
