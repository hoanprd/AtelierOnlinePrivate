using System;
using System.Collections.Generic;
using UnityEngine;

public class TrainingPotionWindow : UIWrapListBase
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private Transform m_trDetailRoot;

	[SerializeField]
	private UIButton m_sExecuteButton;

	[SerializeField]
	private UILabel m_sSortName;

	[SerializeField]
	private Transform m_trListRoot;

	[SerializeField]
	private UILabel m_sSelectNum;

	[SerializeField]
	private TrainingLevel m_sLevel;

	[SerializeField]
	private TrainingParam m_sParam;

	[SerializeField]
	private GameObject m_goExecuteEffect;

	[SerializeField]
	private GameObject m_goLevelUpEffect;

	[SerializeField]
	private GameObject m_goLevelUpEffect2;

	[SerializeField]
	private TrainingAnimEvent m_sAnimEvent;

	private EOrder m_eOrderKind;

	private List<InventoryInfo> m_vFeedList;

	private List<ItemBar> m_vItemList;

	private GrowPotionResponse m_sInfo;

	private GrowCharaData m_sCharaData;

	private List<long> m_vSelectList;

	private Action m_sOnExit;

	private bool m_bEnableAddEXP;

	private const string csSORT_KEY = "POSION_SORT";

	public List<long> Feeds
	{
		get
		{
			return null;
		}
	}

	public List<InventoryInfo> FeedsInventory
	{
		get
		{
			return null;
		}
	}

	protected override bool CreatePrefab()
	{
		return false;
	}

	public void Init(GrowCharaData chara, ResponseDataCommon common, Action onExit)
	{
	}

	public void Execute(bool lvup, Action modifyTrigger)
	{
	}

	public void UpdateInfo(ResponseDataCommon common)
	{
	}

	private void ChangeSortKind(EOrder kind)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	private void UpdateSelectStatus()
	{
	}

	private void UpdateStatus()
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnSortSwitch()
	{
	}

	public void OnClose()
	{
	}

	public void OnSelectItem(ItemBar item)
	{
	}

	public void OnDetailItem(ItemBar item)
	{
	}

	public void OnReset()
	{
	}

	public void OnRecommend()
	{
	}
}
