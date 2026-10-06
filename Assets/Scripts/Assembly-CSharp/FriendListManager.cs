using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FriendListManager : UIWrapListBase
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
	private FriendListSearchWindow m_sSearchWindow;

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

	private List<FriendData> m_vDispFriend;

	private Action<List<FriendData>> m_sCallback;

	private FriendList.FriendLimit m_sLimit;

	private List<FriendData> m_vFriendAll;

	private List<long> m_vRecent;

	private PlayerDetailManager m_sDetailWindow;

	private bool m_bJoinRoom;

	private DialogUnsupportedDevice m_scrUnsupportedDevice;

	private const int ciTABGROUP = 12;

	private const string SORT_PREFIX = "SORT_FRIEND";

	private void MakeDispFriendList()
	{
	}

	private void UpdateReceiveBadge()
	{
	}

	public void Init(FriendList list, Action<List<FriendData>> callback = null)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnOpenSearchWindow()
	{
	}

	public void OnChangeTab(FriendListTab select)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	public void OnJoinRoom(FriendListItem target)
	{
	}

	[DebuggerHidden]
	private IEnumerator TryToJoinRoom(FriendListItem target)
	{
		return null;
	}

	public void OnDetail(FriendListItem target)
	{
	}

	public void OnBlock(FriendListItem target)
	{
	}

	public void OnBlockCancel(FriendListItem target)
	{
	}

	public void OnRequest(FriendListItem target)
	{
	}

	public void OnRequestCancel(FriendListItem target)
	{
	}

	public void OnGoodbye(FriendListItem target)
	{
	}

	public void OnAgree(FriendListItem target)
	{
	}

	public void OnReject(FriendListItem target)
	{
	}

	public void OnAllAgree()
	{
	}

	public void OnAllReject()
	{
	}

	private void CompleteUpdateData(string content)
	{
	}

	private void UpdateInfo(FriendData data)
	{
	}

	private void UpdateCount()
	{
	}

	private void LoadSort()
	{
	}

	private void OnSortDecide(bool update)
	{
	}

	public void OnSort()
	{
	}

	private int CompareLogin(FriendData a, FriendData b)
	{
		return 0;
	}

	private int CompareLevel(FriendData a, FriendData b)
	{
		return 0;
	}

	private int ComparePlay(FriendData a, FriendData b)
	{
		return 0;
	}
}
