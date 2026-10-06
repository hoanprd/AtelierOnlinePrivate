using UnityEngine;

public class EquipmentSelectItem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goNowEquip;

	[SerializeField]
	private UIButton m_sRemoveButton;

	[SerializeField]
	private ItemEquipMark m_sEquipMark;

	[SerializeField]
	private GameObject m_goLevelLimitRoot;

	[SerializeField]
	private UILabel m_sLevelLimit;

	private ItemBar m_sItemBar;

	private InventoryInfo m_sInventory;

	private static int LEVEL_LIMIT_50;

	public long ItemID
	{
		get
		{
			return 0L;
		}
	}

	public bool Select
	{
		set
		{
		}
	}

	public bool NowEquip
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Init()
	{
	}

	public void Init(InventoryInfo inv, bool now, int charaLV = 1)
	{
	}
}
