using System;
using System.Collections.Generic;
using UnityEngine;

public class ExqRoomMemberWindow : UIWrapListBase
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UILabel m_sCountName;

	[SerializeField]
	private UILabel m_sCount;

	[SerializeField]
	private UILabel m_sReceiveNum;

	[SerializeField]
	private GameObject m_goReceiveControllButton;

	[SerializeField]
	private FriendListTab[] m_asTab;

	[SerializeField]
	private UILabel m_sNoneInfoText;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private Transform m_trSortWindowRoot;

	private SortFilterWindow m_sSortWindow;

	private ESortKind m_eSortKind;

	private EOrder m_eOrderKind;

	private EFriendState m_eTabKind;

	private FriendList m_sFriendList;

	private FriendList.FriendLimit m_sLimit;

	private List<FriendDetail> m_vFriendAll;

	private List<long> m_vRecent;

	[SerializeField]
	private Transform m_trDetailWindowRoot;

	private PlayerDetailManager m_sDetailWindow;

	private bool m_bJoinRoom;

	private DialogUnsupportedDevice m_scrUnsupportedDevice;

	private const int ciTABGROUP = 12;

	private List<PartyMember> m_vPartyMemberList;

	private List<FriendDetail> m_vFriendDetailList;

	private void MakeDispFriendList()
	{
	}

	public void Init(List<PartyMember> listParty, List<FriendDetail> listFriend, Action<List<FriendData>> callback = null)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	public void OnDetail(ExqRoomMemberListItem target)
	{
	}

	public void OnRequest(ExqRoomMemberListItem target)
	{
	}

	public void OnRequestCancel(ExqRoomMemberListItem target)
	{
	}

	public void OnGoodbye(ExqRoomMemberListItem target)
	{
	}

	public void OnAgree(ExqRoomMemberListItem target)
	{
	}

	public void OnReject(ExqRoomMemberListItem target)
	{
	}

	public void OnAllAgree()
	{
	}

	public void OnAllReject()
	{
	}

	private void CompleteUpdateData(string content, Action callback = null)
	{
	}

	private void UpdateInfo(FriendDetail data)
	{
	}

	public void OnChangeOwner(ExqRoomMemberListItem item)
	{
	}

	public void OnForceKick(ExqRoomMemberListItem item)
	{
	}
}
