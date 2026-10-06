using System.Collections.Generic;

public class EquipmentFavListSub : EquipmentListBase<EquipmentFavListItemSub>
{
	public EquipmentFavDetailSub m_sDetail;

	private List<InventoryInfo> m_sInventory;

	private int m_iEnableEquipCount;

	protected override void ChangeItem()
	{
	}

	public void Init(List<EquipFavoSubInfo> list, List<InventoryInfo> inv, int maxRegist, int maxEquip)
	{
	}
}
