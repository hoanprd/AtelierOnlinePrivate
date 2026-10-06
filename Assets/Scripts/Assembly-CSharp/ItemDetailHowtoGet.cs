using UnityEngine;

public class ItemDetailHowtoGet : UIListViewBase<ItemDetailHowtoGetItem>
{
	[SerializeField]
	private UILabel m_sTicketNum;

	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private UIScrollListArrow m_sArrow;

	public void UpdateInfo()
	{
	}

	public void Init(int itemDF, FairyItemInfo pickupInfo)
	{
	}
}
