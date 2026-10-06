using UnityEngine;

public class ItemBarSubInfo : MonoBehaviour
{
	[SerializeField]
	private ItemEquipMark m_sEquipMark;

	[SerializeField]
	private GameObject m_goNewMark;

	[SerializeField]
	private GameObject m_goSeleckMark;

	[SerializeField]
	private UILabel m_sLv;

	[SerializeField]
	private UILabel m_sQuality;

	[SerializeField]
	private UILabel m_sPrice;

	public bool IsSelect
	{
		get
		{
			return false;
		}
	}

	public void Init(InventoryInfo inv)
	{
	}

	public void SetDisableEquipMark()
	{
	}

	public void DispSellInfo(InventoryInfo inv)
	{
	}

	public void DispSellInfo(MasterItem master)
	{
	}

	public void SetSelect(bool sw)
	{
	}
}
