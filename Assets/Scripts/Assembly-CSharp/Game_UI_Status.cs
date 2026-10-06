using UnityEngine;

public class Game_UI_Status : Game_UI_Status_Base
{
	[SerializeField]
	private UITexture m_txEtcIcon;

	public bool m_bEnablePurchase;

	public UILabel m_sMana;

	public UILabel m_sCall;

	public UILabel m_sSpoon;

	public UILabel m_sFlood;

	public UILabel m_sEtc;

	public GameObject m_goPurchaseButton;

	public UIGrid m_sGrid;

	private int m_iDispMana;

	private int m_iDispCall;

	private int m_iDispSpoon;

	private int m_iDispFlood;

	private int m_iDispEtc;

	private bool m_bDispMana;

	private bool m_bDispCall;

	private bool m_bDispSpoon;

	private bool m_bDispFlood;

	private bool m_bDispEtc;

	private MasterWealth m_EtcWealth;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Init(bool ether = true, bool call = true, bool spoon = false, bool enablePurchase = true, bool flood = false)
	{
	}

	private void UpdateStatus()
	{
	}

	private void Update()
	{
	}

	public void SetViewEtcWealth(int wealthDf)
	{
	}

	public void OnProduct()
	{
	}

	public void floodDisp(bool flg)
	{
	}
}
