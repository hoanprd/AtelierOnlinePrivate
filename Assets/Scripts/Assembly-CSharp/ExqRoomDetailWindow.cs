using System;
using System.Collections.Generic;
using UnityEngine;

public class ExqRoomDetailWindow : MonoBehaviour
{
	[Serializable]
	public class Member
	{
		private const int MAX_MEMBER = 4;

		public GameObject[] objRoot;

		public UITexture[] atxIcon;

		public UILabel[] sCharaLv;

		public UILabel[] sUserName;

		public void Init(RoomInfo room)
		{
		}

		public void Reset()
		{
		}
	}

	[SerializeField]
	private UILabel m_sComment;

	[SerializeField]
	private UILabel m_sRoomPlan;

	[SerializeField]
	private UILabel m_sDetail;

	[SerializeField]
	private QuestTargetIcon m_sTargetIcon;

	[SerializeField]
	private Member m_sMemberList;

	private RoomInfo m_sRoomInfo;

	private QuestShow m_sInfo;

	private MasterQuestInfo m_sMaster;

	private bool m_bLock;

	private bool m_bUpdateInfo;

	private bool m_bReadOnly;

	private Dictionary<int, QuestShow> m_dDetailList;

	private Dictionary<int, InventoryList> m_dInventoryList;

	private Transform m_trTargetDetailRoot;

	private Action<QuestDetail> m_sOnUpdateInfoEvent;

	private Action<int> m_sOnUpdatePresentNum;

	private Action<DegreeMissionInfo> m_sOnDispMissionTitle;

	private Action m_sOnGotoShop;

	private Action<DegreeMissionInfo[]> m_sOnUpdateMissionInfo;

	private List<RoomInfo> m_vOrderList;

	private Action m_saEnterBtnEvent;

	public List<RoomInfo> OrderList
	{
		set
		{
		}
	}

	public void SetUpdateInfoEvent(Action<QuestDetail> ev)
	{
	}

	public void SetTargetDetailRoot(Transform root)
	{
	}

	public void SetUpdatePresentNumEvent(Action<int> ev)
	{
	}

	public void SetMissionTitleDetailEvent(Action<DegreeMissionInfo> ev)
	{
	}

	public void SetGotoShopEvent(Action ev)
	{
	}

	public void SetUpdateMission(Action<DegreeMissionInfo[]> ev)
	{
	}

	public void CacheClear()
	{
	}

	public void RemoveDetail(int df)
	{
	}

	public void SetBuutonEnable(bool sw)
	{
	}

	public void ResetInfo()
	{
	}

	public void Init(int df, QuestDetail status, RoomInfo room, Action onEnterBtnEvent, bool readOnly = false, bool autoDispPop = true)
	{
	}

	private void Init(MasterQuestInfo master)
	{
	}

	private void InitProgress(QuestShow info, bool notify = true)
	{
	}

	private void InitActionButton(MasterQuestInfo master, QuestShow progress)
	{
	}

	public void OnEnterRoom()
	{
	}
}
