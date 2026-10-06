using UnityEngine;

public class LoadingManager : SingletonBase<LoadingManager>
{
	private enum EStep
	{
		eNONE = 0,
		eIN = 1,
		eTEXT_IN = 2,
		eWAIT = 3,
		eTEXT_OUT = 4,
		eOUT = 5
	}

	[SerializeField]
	private UITweenReset m_sBlackAnim;

	[SerializeField]
	private TweenColor m_sBlackAnimColor;

	[SerializeField]
	private UITweenReset m_sTextAnim;

	[SerializeField]
	private GameObject m_goTextRoot;

	[SerializeField]
	private UILabel m_sTextEng;

	[SerializeField]
	private UILabel m_sTextJp;

	[SerializeField]
	private GameObject m_goDownloadRoot;

	[SerializeField]
	private UILabel m_sDownloadText;

	[SerializeField]
	private UISlider m_sDownloadGauge;

	[SerializeField]
	private GameObject m_goTipsRoot;

	[SerializeField]
	private UILabel m_sTipsText;

	[SerializeField]
	private UILabel m_sTipsTitleText;

	[SerializeField]
	private MasterTipsList m_sLocalTips;

	private EStep m_eStep;

	private bool m_bExitReq;

	private float m_fDuration;

	public static bool IsEnd
	{
		get
		{
			return false;
		}
	}

	public static bool IsBlackOut
	{
		get
		{
			return false;
		}
	}

	public static void Enable(float duration = 0.5f)
	{
	}

	public static void Enable(Color col, float duration = 0.5f)
	{
	}

	public static void Disable(float duration = 0.5f)
	{
	}

	public static void SetDownload(bool sw)
	{
	}

	public static void SetFirstDownload(bool sw)
	{
	}

	public static void SetProgress(float rate, string text = "")
	{
	}

	private void Update()
	{
	}

	protected override void Awake()
	{
	}

	private void SetColor(Color col)
	{
	}
}
