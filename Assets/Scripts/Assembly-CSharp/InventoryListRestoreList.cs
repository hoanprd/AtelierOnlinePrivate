using System.Collections.Generic;
using UnityEngine;

public class InventoryListRestoreList : UIListViewBase<ItemBar>
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UIScrollListArrow m_sArrow;

	[SerializeField]
	private UILabel m_sSelectNum;

	public void Init(List<InventoryInfo> inv)
	{
	}

	public virtual void Bringin()
	{
	}

	public virtual void OnClose()
	{
	}

	protected virtual void OnCloseEnd()
	{
	}
}
