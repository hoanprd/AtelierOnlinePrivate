using System;
using UnityEngine;

public class QuestCostConfirmDialog : UIWindowBase
{
	[Serializable]
	public class Wealth
	{
		public GameObject goRoot;

		public UILabel sCostName;

		public UILabel sHaveName;

		public UILabel sCost;

		public UILabel sHave;

		public UITexture sIcon;

		public bool Init(int df, int cost)
		{
			return false;
		}
	}

	[Serializable]
	public class Item
	{
		public GameObject goRoot;

		public UILabel sQuality;

		public UILabel sCost;

		public UILabel sHave;

		public UITexture sIcon;

		public bool Init(int df, int quality, int cost)
		{
			return false;
		}
	}

	[SerializeField]
	private Wealth m_sWealthInfo;

	[SerializeField]
	private Item m_sItemInfo;

	[SerializeField]
	private GameObject m_goDisable;

	[SerializeField]
	private UIButton m_sDecideButton;

	private EButtonKind m_eResult;

	private Action<EButtonKind> m_sResultEvent;

	public void Init(CostInfo cost, Action<EButtonKind> resultEvent)
	{
	}

	public void OnDecide()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public static QuestCostConfirmDialog Create()
	{
		return null;
	}
}
