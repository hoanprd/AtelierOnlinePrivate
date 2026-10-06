using System;
using UnityEngine;

public class ExqRoomCreateRoomWindow : MonoBehaviour
{
	public enum EToggleBtnSprite
	{
		btn_nomal02_02_S = 0,
		btn_nomal02_03_S = 1
	}

	public enum EToggleBtnLabelText
	{
		ON = 0,
		OFF = 1
	}

	private const string DEFAULT_COMMENT_TEXT = "ここをタ";

	[SerializeField]
	private UIInput m_sComment;

	private RoomPlan m_setRoomPlan;

	private RoomMemberNum m_setRoomMemberNum;

	[SerializeField]
	private UILabel m_lSelectedRoomPlan;

	[SerializeField]
	private UILabel m_lSelectedRoomMemberNum;

	[SerializeField]
	private UISprite m_uisFriendOnly;

	[SerializeField]
	private UILabel m_lFriendOnly;

	private bool m_isFriendOnly;

	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private ExqRoomConfirmWindow m_sConfirmWindow;

	[SerializeField]
	private ExqRoomSelectListWindow m_sSelectWindow;

	private Action<string, RoomPlan, RoomMemberNum, bool> m_saCallback;

	public void Init(Action<string, RoomPlan, RoomMemberNum, bool> callback)
	{
	}

	private void SetLabel()
	{
	}

	private void SetFriendOnlyButton(bool isFriendOnly)
	{
	}

	public void OnChangeIntention()
	{
	}

	public void OnChangeMemberCapacity()
	{
	}

	public void OnFriendOnlyToggle()
	{
	}

	public void OnDecide()
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
