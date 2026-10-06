using UnityEngine;

public class ShopGachaCoordinateList : UIListViewBase<ShopGachaCoordinateItem>
{
	[SerializeField]
	private Transform m_trItemDetailRoot;

	public void Init(ShopGachaShow.Coordinate detail, ShopGachaShow.PickupInfo param)
	{
	}

	private void Init(int id, ShopGachaShow.PickupInfo param)
	{
	}

	public void OnDetail(ShopGachaShow.Item item)
	{
	}
}
