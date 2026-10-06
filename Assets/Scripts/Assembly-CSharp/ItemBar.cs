using UnityEngine;

public class ItemBar : MonoBehaviour
{
	public UILongTapButton m_sButton;

	public UITexture m_txPicture;

	public ItemQualityFrame m_sFrame;

	public UISprite m_sCategoryIcon;

	public UITexture m_sMoneyIcon;

	public UILabel m_sNum;

	public SkillMark m_sSpecialSkill;

	public GameObject m_goStateRoot;

	public LimitBreakMark m_sLimitBreak;

	public UITexture m_txFaceIcon;

	public GameObject m_goFoodMark;

	public GameObject m_goLockMark;

	public UISprite m_sStorageBG;

	public UISprite m_sStorageIcon;

	public ItemBarSubInfo m_sSubInfo;

	public GameObject m_goSelectObject;

	public UILongTapButton m_sSelectButton;

	public GameObject m_goBlackFilter;

	private ItemBarEvent m_sSelectEvent;

	private ItemBarEvent m_sDetailEvent;

	[SerializeField]
	private UITexture m_DedicatedEquIcon;

	private InventoryInfo m_sInfo;

	private int m_iItemDF;

	private int m_iItemQty;

	private int m_iSkill;

	private int m_iCharaDF;

	private EWealthKind m_eWealth;

	public bool Select
	{
		get
		{
			return false;
		}
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

	public int ItemDF
	{
		get
		{
			return 0;
		}
	}

	public int ItemQuality
	{
		get
		{
			return 0;
		}
	}

	public int ItemSpecialSkill
	{
		get
		{
			return 0;
		}
	}

	public EWealthKind Wealth
	{
		get
		{
			return (EWealthKind)0;
		}
	}

	public int CharaDF
	{
		get
		{
			return 0;
		}
	}

	public void SetEnableSelect(bool sw)
	{
	}

	public void SetSelect(bool sw)
	{
	}

	public void UpdateFav()
	{
	}

	public void SetEnableClick(bool sw)
	{
	}

	public void SetEnableLongTap(bool sw)
	{
	}

	public void InitDetailEvent(ItemBarEvent ev)
	{
	}

	public void InitSelectEvent(ItemBarEvent ev)
	{
	}

	public void InitDetail(InventoryInfo inv, bool sell)
	{
	}

	public void InitDetailDisplayStorage(InventoryInfo inv, bool sell)
	{
	}

	public void SetDisableEquipMark()
	{
	}

	public void Init(InventoryInfo inv)
	{
	}

	public void InitDisplayStorage(InventoryInfo inv)
	{
	}

	public void Init(int df, int num = 0)
	{
	}

	public void Init(EWealthKind kind, int num)
	{
	}

	public void Init(EWealthKind kind, int num, bool dispNum)
	{
	}

	public void InitRankingPoint(int num)
	{
	}

	public void InitChara(int df)
	{
	}

	public void Init(int df, int quality, int trt, int num, int fav = 0, bool forceDispNum = false, int place = 0)
	{
	}

	public void SetBlackFilter(bool sw)
	{
	}

	public void OnDetail()
	{
	}

	public void OnSelect()
	{
	}

	public static ItemBar Create(Transform parent)
	{
		return null;
	}
}
