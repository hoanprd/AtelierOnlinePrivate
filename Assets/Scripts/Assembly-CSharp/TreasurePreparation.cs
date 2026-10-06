using System;
using UnityEngine;

public class TreasurePreparation : TreasureTargetItem
{
	[Serializable]
	public class Party
	{
		public UIGrid sGrid;

		private TreasurePartyEditChara[] asMember;

		public void Init(HuntInfo info)
		{
		}
	}

	[SerializeField]
	private TreasureFeatureList m_sFeatureList;

	[SerializeField]
	private UILabel m_sCost;

	[SerializeField]
	private UITexture m_txCostIcon;

	[SerializeField]
	private TreasurePartyEdit m_sPartyEdit;

	[SerializeField]
	private TreasureSuccessRate m_sSuccessRate;

	[SerializeField]
	private Bonus m_sBonus;

	[SerializeField]
	private Party m_sParty;

	[SerializeField]
	private UIButton m_sDecideButton;

	[SerializeField]
	private UIButton m_sRecommendButton;

	[SerializeField]
	private UIButton m_sPartyEditoButton;

	[SerializeField]
	private UIButton m_sImmidiateButton;

	[SerializeField]
	private UIButton m_sGiveupButton;

	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private AnimationController m_sRateAnim;

	private int m_iFormID;

	private bool m_bEnableCost;

	private eHuntReturnType m_eResult;

	private Action<eHuntReturnType> m_sOnCloseEvent;

	public void Init(int formID, HuntInfo info, Action<eHuntReturnType> onClose)
	{
	}

	public void InitDetail(HuntInfo info, Action<eHuntReturnType> onClose)
	{
	}

	private void Init(HuntInfo hunt, Action<eHuntReturnType> onClose, bool detail)
	{
	}

	public void UpdateInfo(HuntInfo info)
	{
	}

	private void InitButton(bool detail)
	{
	}

	private void InitCost()
	{
	}

	private void UpdateRate(bool immidiate)
	{
	}

	public void OnRecommend()
	{
	}

	public void OnChooseParty()
	{
	}

	public void OnDecideParty(HuntInfo info)
	{
	}

	public void OnDecide()
	{
	}

	public void OnImmidiate()
	{
	}

	private void OnImmidiateConfirmResult(bool decide, eHuntReturnType result, int wealthKind)
	{
	}

	public void OnGiveup()
	{
	}

	private void OnDecideResult(bool decide, eHuntReturnType result, int wealthKind)
	{
	}

	public void OnFeatureList()
	{
	}

	public void OnBack()
	{
	}

	private void OnCloseEnd()
	{
	}
}
