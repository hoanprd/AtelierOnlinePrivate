using UnityEngine;

public class ItemDetailHowtoGetItem : MonoBehaviour
{
	private enum EKind
	{
		ePICKUP = 0,
		eALTER = 1,
		eSHOP = 2,
		eDROP = 3
	}

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UIButton m_sGotoButton;

	[SerializeField]
	private UIButton m_sUseTicketButton;

	[SerializeField]
	private UIButton m_sAlterButton;

	[SerializeField]
	private UILabel m_sTicketNum;

	private int m_iTicketNum;

	private int m_iMaxTicketNum;

	private EKind m_eKind;

	private FairyItemInfo m_sFairyInfo;

	public FairyItemInfo FairyInfo
	{
		get
		{
			return null;
		}
	}

	public int UseNum
	{
		get
		{
			return 0;
		}
	}

	public void OnUpdateTicket()
	{
	}

	public void OnAddTicket()
	{
	}

	public void OnDecTicket()
	{
	}

	public void OnAlter()
	{
	}

	public void OnGoto()
	{
	}

	public void InitAlter(MasterItem master)
	{
	}

	public void InitShop()
	{
	}

	public void InitDrop()
	{
	}

	public void InitPickup(FairyItemInfo fairyInfo)
	{
	}
}
