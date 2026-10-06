using UnityEngine;

public class ItemBarEquip : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sNameQualityNone;

	[SerializeField]
	private UISprite m_sCategoryIcon;

	[SerializeField]
	private UILabel m_sLevel;

	[SerializeField]
	private UITexture m_txEquipChara;

	[SerializeField]
	private GameObject m_goEquipMark;

	[SerializeField]
	private UILabel m_sEquipText;

	[SerializeField]
	private UISprite m_sEquipBase;

	[SerializeField]
	private LimitBreakMark m_sLimitBreak;

	[SerializeField]
	private UISprite m_sBackground;

	[SerializeField]
	private GameObject m_goLevelMax;

	[SerializeField]
	private GameObject m_goSpecialSkill;

	[SerializeField]
	private GameObject m_goStateRoot;

	[SerializeField]
	private GameObject m_goEquipLevelRoot;

	[SerializeField]
	private UILabel m_sEquipLevel;

	public bool DispLimitBreak
	{
		set
		{
		}
	}

	private void SetExist(bool sw)
	{
	}

	public void Init(int df, int lv, int quality, int trt)
	{
	}

	public void Init(InventoryInfo item)
	{
	}

	public void InitNone(EEquipPart part)
	{
	}

	public static ItemBarEquip Create(Transform root)
	{
		return null;
	}
}
