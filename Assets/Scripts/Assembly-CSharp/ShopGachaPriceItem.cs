using UnityEngine;

public class ShopGachaPriceItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sCount;

	[SerializeField]
	private GameObject m_goWealthRoot;

	[SerializeField]
	private UILabel m_sPrice;

	[SerializeField]
	private GameObject m_goTicketRoot;

	[SerializeField]
	private UILabel m_sTikectPrice;

	[SerializeField]
	private UILabel m_sTikectNum;

	[SerializeField]
	private GameObject m_goLimitWindow;

	[SerializeField]
	private UISprite m_sLimitWinBase;

	[SerializeField]
	private UILabel m_sLimit;

	[SerializeField]
	private UITexture[] m_atxPriceIcon;

	[SerializeField]
	private GameObject m_goCompensationMark;

	private UIButton m_sButton;

	private GachaInfo.SellInfo m_sSellInfo;

	private int m_iStep;

	public int Step
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

	public int Price
	{
		get
		{
			return 0;
		}
	}

	public int WealthKind
	{
		get
		{
			return 0;
		}
	}

	public bool IsCompensation
	{
		get
		{
			return false;
		}
	}

	public int SellId
	{
		get
		{
			return 0;
		}
	}

	public GachaInfo.SellInfo Info
	{
		get
		{
			return null;
		}
	}

	public void Init(GachaInfo.SellInfo sell, int step)
	{
	}

	private bool IsTicket()
	{
		return false;
	}

	private void SetLimitText(int step)
	{
	}

	private void Update()
	{
	}
}
