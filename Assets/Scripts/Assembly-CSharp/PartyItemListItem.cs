using UnityEngine;

public class PartyItemListItem : MonoBehaviour
{
	public enum EAlterState
	{
		eNONE = 0,
		eENABLE = 1,
		eDISABLE = 2
	}

	[SerializeField]
	private GameObject m_goNone;

	[SerializeField]
	private Transform m_trItemBarRoot;

	[SerializeField]
	private UILabel m_sHaveCount;

	[SerializeField]
	private UIButton m_sAlterButton;

	[SerializeField]
	private UIButton m_sSelectButton;

	[SerializeField]
	private GameObject m_goEnableAlterMark;

	[SerializeField]
	private GameObject m_trManualInfoRoot;

	[SerializeField]
	private UILabel m_sIndex;

	[SerializeField]
	private GameObject m_trAutoInfoRoot;

	[SerializeField]
	private UISprite m_sCategoryIcon;

	[SerializeField]
	private UILabel m_sCategoryName;

	private ItemBar m_sDetail;

	private int m_iLimit;

	private PartyItemData m_sData;

	private int m_iNO;

	private int m_iItemID;

	public int NO
	{
		get
		{
			return 0;
		}
	}

	public int Count
	{
		get
		{
			return 0;
		}
	}

	public int ItemID
	{
		get
		{
			return 0;
		}
	}

	public PartyItemData Data
	{
		get
		{
			return null;
		}
	}

	public void InitManual(int no, PartyItemData data, int haveNum, EAlterState enableAlter, ItemBarEvent onDetail)
	{
	}

	public void InitAuto(int kind, PartyItemData data, int haveNum, EAlterState enableAlter, ItemBarEvent onDetail)
	{
	}

	private void Init(PartyItemData data, int haveNum, EAlterState enableAlter, ItemBarEvent onDetail)
	{
	}

	private string GetCategoryIcon(int kind)
	{
		return null;
	}

	private string GetCategoryName(int kind)
	{
		return null;
	}
}
