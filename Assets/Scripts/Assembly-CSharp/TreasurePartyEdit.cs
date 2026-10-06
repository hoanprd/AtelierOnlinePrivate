using System;
using System.Collections.Generic;
using UnityEngine;

public class TreasurePartyEdit : UIWrapListBase
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private TreasureSuccessRate m_sScuccessRate;

	[SerializeField]
	private UIGrid m_sMemberGrid;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private UILabel m_sFilterName;

	[SerializeField]
	private Transform m_trSortWindowRoot;

	[SerializeField]
	private TreasureTargetInfoBase.Condition m_sCondition;

	private SortFilterWindow m_sSortFilterWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private TreasurePartyEditMember[] m_asMember;

	private List<PartyMember> m_vMember;

	private HuntInfo m_sInfo;

	private List<List<int>> m_vBonusChara;

	private List<int> m_vRequireChara;

	private int m_iChooseChara;

	private TreasurePartyEditMember m_sMember;

	private GameObject m_goCollision;

	private Action<HuntInfo> m_sOnResult;

	private readonly string SORT_PREFIX;

	public void Init(HuntInfo info, Action<HuntInfo> onResult)
	{
	}

	private void InitMember()
	{
	}

	private void MakeDispList()
	{
	}

	private void UpdateTargetList()
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	private void DecideMember()
	{
	}

	private void UpdateMember()
	{
	}

	public void OnRecommend()
	{
	}

	public void OnSelectTarget(TreasurePartyEditMemberTarget target)
	{
	}

	public void OnSelectMember(TreasurePartyEditMember member)
	{
	}

	public void OnRemove(TreasurePartyEditMember member)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void LoadSort()
	{
	}

	private void OnSortDecide(bool update)
	{
	}

	public void OnFilterButton()
	{
	}

	public void OnSortButton()
	{
	}

	private List<PartyMember> GetFilter(EFilterKind kind)
	{
		return null;
	}

	private int DefaultCompare(PartyMember a, PartyMember b)
	{
		return 0;
	}

	private int CompareBonus(PartyMember a, PartyMember b)
	{
		return 0;
	}
}
