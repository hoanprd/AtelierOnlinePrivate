using System.Collections.Generic;
using UnityEngine;

public abstract class ShopComListBase : UIListViewBase<ShopComListItem>
{
	[SerializeField]
	protected AnimationController[] m_asAnim;

	[SerializeField]
	protected UIScrollListArrow m_sArrow;

	[SerializeField]
	protected UIScrollView m_sScrollView;

	protected ShopComInfo.Data[] m_asList;

	protected ShopComListItem m_sCenterObj;

	protected EShopComKind m_eTab;

	protected Dictionary<int, ShopComItem> m_sDetailList;

	public ShopComListItem SelectItem
	{
		get
		{
			return null;
		}
	}

	public ShopComDetail SelectDetail
	{
		get
		{
			return null;
		}
	}

	private void OnDisable()
	{
	}

	public virtual bool IsDismissEnd()
	{
		return false;
	}

	public virtual void Bringin()
	{
	}

	public virtual void Dismiss()
	{
	}

	protected virtual void OnDismiss()
	{
	}

	public virtual void OnSelect(ShopComListItem target)
	{
	}

	public virtual void UpdateInfo()
	{
	}

	protected virtual void UpdateDetail()
	{
	}

	protected void ReceiveDetail(ShopComShowResponse res)
	{
	}

	protected abstract void ReceiveDetailInfo(ShopComItem detail);

	protected virtual void OnOpenEnd()
	{
	}

	protected virtual void OnCloseEnd()
	{
	}
}
