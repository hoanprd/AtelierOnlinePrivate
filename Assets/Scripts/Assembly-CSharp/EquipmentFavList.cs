using System.Collections.Generic;

public class EquipmentFavList : EquipmentListBase<EquipmentFavListItem>
{
	public EquipmentFavDetail m_sDetail;

	private List<InventoryInfo> m_sInventory;

	private EEquipKind m_eKind;

	protected override void ChangeItem()
	{
	}

	public void UpdateInfo(EquipFavoInfo info)
	{
	}

	public void Init(List<EquipFavoInfo> list, List<InventoryInfo> inv, int max, EEquipKind kind)
	{
	}
}
