using UnityEngine;

public class ItemDetailEquipmentMini : MonoBehaviour
{
	public UILongTapButton m_sSelectButton;

	public GameObject m_goDisableMark;

	public ItemQualityFrame m_sFrame;

	public GameObject m_goIcon;

	public UITexture m_txItemPic;

	public UITexture m_txSkillPic;

	public SkillMark m_sSpecialSkill;

	public EquipWeaponElementInfo m_sWeaponInfo;

	public UILabel m_sLevel;

	public LimitBreakMark m_sLimitbreak;

	public GameObject m_goEquipLevelRoot;

	public UILabel m_sEquipLevel;

	public GameObject m_goEmptyRoot;

	public GameObject[] m_agoEmptyMark;

	public UISprite m_sEmptyCategoryIcon;

	public GameObject m_goEmpty;

	public int m_iEmptyKind;

	private EEquipPart m_ePart;

	private InventoryInfo m_sInventory;

	public InventoryInfo Inventory
	{
		get
		{
			return null;
		}
	}

	public EEquipPart PartKind
	{
		get
		{
			return EEquipPart.eWEAPON;
		}
	}

	public bool EnableEquip
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetDisalbeEquipMark()
	{
	}

	public void SetEmptyKind(int kind)
	{
	}

	public void ChangeDispStatus(EEquipStatusKind kind)
	{
	}

	private void SetExist(bool sw)
	{
	}

	private void InitNone(EEquipPart part)
	{
	}

	public void Init(EEquipPart part, InventoryInfo item, int charaLevel = 1)
	{
	}

	public void SetEnableEquip(MasterItem master, int charaLevel)
	{
	}

	public void SetEquip(bool sw)
	{
	}

	public void SetEnable(bool sw)
	{
	}

	private void InitItemCategory(EEquipPart part)
	{
	}

	public static ItemDetailEquipmentMini Create(Transform root)
	{
		return null;
	}
}
