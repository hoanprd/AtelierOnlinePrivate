using System;
using UnityEngine;

public class ExqRoomFilterWindow : MonoBehaviour
{
	private RoomPlan m_nowRoomPlan;

	private RoomMemberNum m_nowRoomMemberNum;

	[SerializeField]
	private UILabel m_lSelectedRoomPlan;

	[SerializeField]
	private UILabel m_lSelectedRoomMemberNum;

	[SerializeField]
	private ExqRoomSelectListWindow m_sSelectWindow;

	[SerializeField]
	private UITweenReset m_sAnim;

	private Action<RoomPlan, RoomMemberNum> m_saCallback;

	public void Init(Action<RoomPlan, RoomMemberNum> callback)
	{
	}

	private void SetLabel()
	{
	}

	public void OnDecide()
	{
	}

	public void OnChangeIntention()
	{
	}

	public void OnChangeMemberCapacity()
	{
	}

	public void OnCancel()
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
