using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestDetailWindow : MonoBehaviour
{
	[Serializable]
	public class ActionInfo
	{
		public QuestDetailCost sCost;

		public GameObject sIgnoreCancel;

		public GameObject goOrdersMax;

		public GameObject goNoNeedReport;

		public GameObject goChangesWithConditionsReward;

		public UIButton sCancelButton;

		public UIButton sDeliveryButton;

		public UIButton sOrderButton;

		public UIGrid sGrid;

		public UITable sTable;
	}

	private struct RequestInitModel
	{
		public QuestDetailWindow m_questDetailWindow;

		public int m_df;

		public QuestDetail m_status;

		public DegreeMissionInfo[] m_degree;

		public bool m_readOnly;

		public bool m_autoDispPop;
	}

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sComment;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UILabel m_sDetail;

	[SerializeField]
	private QuestClearInfo m_sClearInfo;

	[SerializeField]
	private QuestReward m_sRewardInfo;

	[SerializeField]
	private GameObject m_goDetailRoot;

	[SerializeField]
	private QuestUnlockConditionList m_sUnlockCondition;

	[SerializeField]
	private ActionInfo m_sAction;

	[SerializeField]
	private SpawnPrefabData m_sDeliveryWindow;

	private static readonly List<RequestInitModel> m_requestList;

	private static bool m_isRunInit;

	private DegreeMissionInfo[] m_asDegreeList;

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

	private List<QuestDetail> m_vOrderList;

	private QuestDetail m_vQuestDetail;

	public Transform DeliveryRoot
	{
		set
		{
		}
	}

	public List<QuestDetail> OrderList
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

	private void ResetInfo()
	{
	}

	public void Init(int df, QuestDetail status, DegreeMissionInfo[] degree, bool readOnly = false, bool autoDispPop = true)
	{
	}

	public void RequestInit(int df, QuestDetail status, DegreeMissionInfo[] degree, bool readOnly = false, bool autoDispPop = true)
	{
	}

	private void RunEndInit()
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

	private bool IsEnableCancel(EQuestCategory categ)
	{
		return false;
	}

	public void OnSelectDeliveryItem(bool execute, List<InventoryInfo> select)
	{
	}

	private void OnExecuteDelivery(List<InventoryInfo> select)
	{
	}

	private void OnCancelConfirm(EButtonKind result)
	{
	}

	public void OnReceive()
	{
	}

	private void ConfirmCost()
	{
	}

	private bool ReceiveConfirm()
	{
		return false;
	}

	private bool OrderLimitConfirm()
	{
		return false;
	}

	private void OnReceiveExecute()
	{
	}

	public void OnDelivery()
	{
	}

	public void OnCancel()
	{
	}

	public void OnTargetDetail()
	{
	}

	public void OnMissionTitleDetail(QuestUnlockBar target)
	{
	}

	protected void DispTargetDetail(MasterQuestInfo master)
	{
	}

	protected virtual void UpdateMaterial(InventoryList inv, int updateFav, int gotoAlter)
	{
	}
}
