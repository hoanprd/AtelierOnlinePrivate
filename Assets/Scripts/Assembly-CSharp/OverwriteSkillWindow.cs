using System;
using System.Collections.Generic;
using UnityEngine;

public class OverwriteSkillWindow : MonoBehaviour
{
	[Serializable]
	public class FeedInfo
	{
		public Transform trItemBarRoot;

		public UILabel sSkillNone;

		public GameObject goInventoryInfoRoot;

		public UILabel sItemName;

		public SkillMark sSkillMark;

		private ItemBar sItembar;

		public ItemBar ItemInfo
		{
			get
			{
				return null;
			}
		}

		public void SetInventory(InventoryInfo inventory)
		{
		}

		public void SetEmpty()
		{
		}
	}

	[SerializeField]
	private AnimationController[] m_asAnim;

	[SerializeField]
	private SpawnPrefabData m_sSkillSearchWindow;

	[SerializeField]
	private UIButton m_sExecuteButton;

	[SerializeField]
	private OverwriteConfrimDialog m_sConfirmDialog;

	[SerializeField]
	private SpawnPrefabData m_sResultWindow;

	[SerializeField]
	private UILabel m_sTargetInventoryName;

	[SerializeField]
	private UITexture m_txTargetInventoryPic;

	[SerializeField]
	private LimitBreakMark m_sTargetLimitbreakMark;

	[SerializeField]
	private OverwriteSkillInfo m_sTargetSkill;

	[SerializeField]
	private OverwriteSkillInfo m_sNextSkill;

	[SerializeField]
	private UITable m_sSkillTable;

	[SerializeField]
	private UISprite m_sWarningCheck;

	private bool m_bDispWarning;

	[SerializeField]
	private Transform m_trDetailRoot;

	[SerializeField]
	private FeedInfo m_sFeed;

	[SerializeField]
	private UILabel m_sNeedEther;

	[SerializeField]
	private UILabel m_sNeedSpoon;

	private OverwriteEquipCostInfo m_OverwriteEquipCostInfo;

	private InventoryList m_vTraitList;

	private InventoryInfo m_sTargetInventory;

	private InventoryInfo m_sFeedInventory;

	private List<long> m_vRemoveInventoryList;

	private Action<InventoryInfo, List<long>> m_sOnExit;

	private Action<InventoryInfo> m_sOnDetail;

	private const string csWARNING_KEY = "OVERWRITE_WARNING_KEY";

	private const string csZERO = "---";

	private readonly Color32 WARNING_COLOR;

	private readonly Color32 NOT_WARNING_COLOR;

	public void Init(PickTraitResponse res, InventoryInfo target, Action<InventoryInfo, List<long>> onExit, Action<InventoryInfo> onDetail)
	{
	}

	private void InitCost()
	{
	}

	private void InitTarget(InventoryInfo inventory)
	{
	}

	private void InitFeed()
	{
	}

	public void OnSwitchWarning()
	{
	}

	private void SetWarningCheck(bool sw)
	{
	}

	public void OnDetail()
	{
	}

	public void OnChangeFeed()
	{
	}

	public void OnSelectFeed(InventoryInfo select)
	{
	}

	private void UpdateExecuteButton()
	{
	}

	public void OnRemove()
	{
	}

	public void OnExecute()
	{
	}

	private void ConfirmLevelDown()
	{
	}

	private void ConfirmInvalidOverwrite()
	{
	}

	private void OnExecuteConfirmResult(EButtonKind result)
	{
	}

	private void UpdateDirection(AlchemyOverwriteExecuteResult result)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnDisable()
	{
	}
}
