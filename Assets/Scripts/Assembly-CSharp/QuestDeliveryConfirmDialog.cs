using System;
using System.Collections.Generic;

public class QuestDeliveryConfirmDialog : UIListViewBase<ItemBar>
{
	public UITweenReset m_sAnim;

	public UIGrid m_sGrid;

	public Action<EButtonKind> m_sCallback;

	private bool m_bBringin;

	private EButtonKind m_eResult;

	public void Init(List<InventoryInfo> list, Action<EButtonKind> callback)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	public void OnAnimEnd()
	{
	}
}
