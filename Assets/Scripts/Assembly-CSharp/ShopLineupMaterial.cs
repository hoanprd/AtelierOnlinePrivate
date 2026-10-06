using UnityEngine;

public class ShopLineupMaterial : UIListViewBase<ShopLineupMaterialItem>
{
	[SerializeField]
	private Transform m_trDetailWindowRoot;

	private int m_iItemID;

	private ShopGachaShow.Item m_sData;

	public void Init(ShopGachaShow.Item item)
	{
	}

	public void OnDetail(int index)
	{
	}
}
