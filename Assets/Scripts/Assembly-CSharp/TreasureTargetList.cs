using System;
using System.Collections.Generic;
using UnityEngine;

public class TreasureTargetList : UIListViewBase<TreasureTargetItem>
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private TreasurePreparation m_sPreparation;

	[SerializeField]
	private TreasureFeatureList m_sFeatureList;

	private List<HuntInfo> m_vList;

	private int m_iFormID;

	private Action<eHuntReturnType> m_sOnCloseEvent;

	private eHuntReturnType m_eResult;

	private GameObject m_goCollision;

	public void Init(List<HuntInfo> targetList, int formID, Action<eHuntReturnType> onClose)
	{
	}

	public void Init(List<HuntInfo> list)
	{
	}

	public void OnSelect(TreasureTargetItem target)
	{
	}

	public void OnFeatureList(TreasureTargetItem target)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
