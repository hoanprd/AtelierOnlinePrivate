using System.Collections.Generic;
using UnityEngine;

public class ItemDetailBase : MonoBehaviour
{
	public UILabel m_sName;

	public UILabel m_sDetail;

	public UITexture m_txPicture;

	public UIButton m_sCloseButton;

	public UIToggle m_sFavToggle;

	public UILabel m_sAlterLevel;

	public UILabel m_sQuarity;

	public UILabel m_sQuarityLimit;

	public GameObject[] m_agoRecipeInfo;

	public GameObject[] m_agoInventoryInfo;

	public EquipSkillList m_sSkillList;

	public GameObject m_goExtraSkillNone;

	public SkillMark m_sExtraSkill;

	public SkillMark m_sExtraSkillPending;

	public LimitBreakMark m_sLimitBreak;

	public AnimationController m_sAnim;

	private InventoryInfo m_sInventory;

	public bool EnableCloseButton
	{
		set
		{
		}
	}

	public InventoryInfo Info
	{
		get
		{
			return null;
		}
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	protected virtual void InitLimitBreak(int quality)
	{
	}

	public virtual void Init(int itemID, int lv, int quality, int qualityLimit, int trt, bool recipe, int fav, bool exist = false)
	{
	}

	protected void InitSkill(List<ActiveSkill> skillList)
	{
	}

	protected void InitSpecialSkill(int id)
	{
	}

	private void SetEnableRecipe(bool recipe)
	{
	}

	public void OnSwitchFav()
	{
	}

	public void SetPendingSkill()
	{
	}

	public void InitRecipe(int df)
	{
	}

	public void Init(InventoryInfo inv, bool exist = false)
	{
	}

	public void Init(int itemID, int lv, int quality, int qualitylimt, int trt, bool exist)
	{
	}
}
