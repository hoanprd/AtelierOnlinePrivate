using System;
using UnityEngine;

public class FairyPickManager : UIListViewBase<FairyPickAreaItem>
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private FairyPickResultWindow m_sResultWindow;

	[SerializeField]
	private UILabel m_sHaveNum;

	[SerializeField]
	private UILabel m_sGotoAreaName;

	[SerializeField]
	private UILabel m_sUseNum;

	[SerializeField]
	private UIRepeatButton m_sUpButton;

	[SerializeField]
	private UIRepeatButton m_sDownButton;

	[SerializeField]
	private UIButton m_sDecideButton;

	private const string csKEY = "FAIRY_AREA";

	private int m_iUseNum;

	private int m_iUseMaxNum;

	private Action<InventoryList> m_sOnCloseEvent;

	private InventoryList m_sAddInventory;

	private void Debug()
	{
	}

	public void Init(FairyItemInfo[] areaList, Action<InventoryList> onCloseEnd)
	{
	}

	private void UpdateTicket()
	{
	}

	private void UpdateAddDecStatus()
	{
	}

	public void OnDecide()
	{
	}

	public void OnAddTicket()
	{
	}

	public void OnDecTicket()
	{
	}

	public void OnSelect(FairyPickAreaItem target)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
