using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TrainingBlazeMateriaWindow : UIWrapListBase
{
	[Serializable]
	public class LevelUp
	{
		public GameObject goNum;

		public GameObject goTxt;

		public AnimEventCtrl sAnimEvent;

		public Animation sEventAnim;

		public Animation sAnim;

		public UILabel sBefore;

		public UILabel sAfter;

		public void Init()
		{
		}
	}

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
	private TrainingBlazeArtsLevel m_sLevel;

	[SerializeField]
	private GrowBlazeArtsParamWnd m_sParam;

	[SerializeField]
	private GameObject m_goExecuteEffect;

	[SerializeField]
	private TrainingAnimEvent m_sAnimEvent;

	[SerializeField]
	private CompositeExecuteEffect m_sExecuteEffect;

	[SerializeField]
	private LevelUp m_sLevelUp;

	[SerializeField]
	private GameObject m_sDeath;

	[SerializeField]
	private UILabel m_sCostLab;

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

	public void Execute(Action modifyTrigger, int beforeLv, int afterLv)
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

	[DebuggerHidden]
	private IEnumerator LevelUpDirection(LevelUp target)
	{
		return null;
	}
}
