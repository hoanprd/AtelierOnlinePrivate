using System.Collections.Generic;
using UnityEngine;

public class TreasurePartyEditChara : TreasureMemberInfo
{
	[SerializeField]
	protected GameObject m_goSelect;

	[SerializeField]
	protected GameObject m_goBonusRoot;

	[SerializeField]
	protected GameObject[] m_agoBonus;

	protected int m_iChara;

	public int CharaID
	{
		get
		{
			return 0;
		}
	}

	public bool IsSelect
	{
		get
		{
			return false;
		}
	}

	public override void Init(int index, FormationInfo form)
	{
	}

	public override void Init(int index)
	{
	}

	public void SetSelect(bool sw)
	{
	}

	public void ResetBonus()
	{
	}

	public void SetBonus(List<List<int>> bonus)
	{
	}
}
