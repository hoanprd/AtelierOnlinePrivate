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
			return !IsExist || !Instance.gameObject.activeSelf;
		}
	}

	public static bool IsBlackOut
	{
		get
		{
			return IsExist && Instance.m_eStep == EStep.eWAIT;
		}
	}

	public static void Enable(float duration = 0.5f)
	{
		Enable(Color.black, duration);
	}

	public static void Enable(Color col, float duration = 0.5f)
	{
		if (!IsExist && Instance == null)
		{
			return;
		}
		Instance.m_fDuration = duration;
		Instance.gameObject.SetActive(true);
		if (Instance.m_goTextRoot != null)
		{
			Instance.m_goTextRoot.SetActive(false);
		}
		Instance.m_eStep = EStep.eIN;
		Instance.m_bExitReq = false;
		Instance.SetColor(col);
	}

	public static void Disable(float duration = 0.5f)
	{
		if (!IsExist)
		{
			return;
		}
		Instance.m_fDuration = duration;
		Instance.m_bExitReq = true;
		SetDownload(false);
	}

	public static void SetDownload(bool sw)
	{
		if (!IsExist)
		{
			return;
		}
		if (Instance.m_goDownloadRoot != null)
		{
			Instance.m_goDownloadRoot.SetActive(sw);
		}
		if (!sw)
		{
			return;
		}
		MasterTips tip = null;
		if (MasterData.Tips != null)
		{
			tip = MasterData.Tips.GetLoading();
		}
		else if (Instance.m_sLocalTips != null)
		{
			tip = Instance.m_sLocalTips.GetLoading();
		}
		if (tip != null)
		{
			if (Instance.m_sTipsText != null)
			{
				Instance.m_sTipsText.text = tip.sContent;
			}
			if (Instance.m_sTipsTitleText != null)
			{
				Instance.m_sTipsTitleText.text = tip.sTitle;
			}
		}
		if (Instance.m_goTipsRoot != null)
		{
			Instance.m_goTipsRoot.SetActive(true);
		}
		if (Instance.m_sDownloadGauge != null)
		{
			Instance.m_sDownloadGauge.value = 0f;
		}
	}

	public static void SetFirstDownload(bool sw)
	{
		if (!IsExist)
		{
			return;
		}
		if (Instance.m_goDownloadRoot != null)
		{
			Instance.m_goDownloadRoot.SetActive(sw);
		}
		if (Instance.m_goTipsRoot != null)
		{
			Instance.m_goTipsRoot.SetActive(false);
		}
	}

	public static void SetProgress(float rate, string text = "")
	{
		if (!IsExist)
		{
			return;
		}
		if (Instance.m_sDownloadGauge != null)
		{
			Instance.m_sDownloadGauge.value = rate;
		}
		if (Instance.m_sDownloadText != null)
		{
			if (string.IsNullOrEmpty(text))
			{
				Instance.m_sDownloadText.text = "DOWNLOADING..." + rate.ToString("P");
			}
			else
			{
				Instance.m_sDownloadText.text = text;
			}
		}
	}

	private void Update()
	{
		switch (m_eStep)
		{
		case EStep.eIN:
			if (m_sBlackAnim != null)
			{
				m_sBlackAnim.FindTweener();
				UITweener[] tweens = m_sBlackAnim.GetComponents<UITweener>();
				for (int i = 0; i < tweens.Length; i++)
				{
					if (tweens[i] != null)
					{
						tweens[i].duration = m_fDuration;
					}
				}
				m_sBlackAnim.TweenForward();
			}
			m_eStep = EStep.eTEXT_IN;
			break;
		case EStep.eTEXT_IN:
			if (m_sBlackAnim != null && !m_sBlackAnim.IsAnimEnd)
			{
				return;
			}
			if (m_goTextRoot != null && m_goTextRoot.activeSelf && m_sTextAnim != null)
			{
				m_sTextAnim.TweenForward();
			}
			m_eStep = EStep.eWAIT;
			break;
		case EStep.eWAIT:
			if (Input.anyKeyDown && m_goDownloadRoot != null && m_goDownloadRoot.activeSelf)
			{
				if (Sound_Manager.GetInst() != null)
				{
					Sound_Manager.GetInst().PlaySound(eSoundID.system_000);
				}
				MasterTips tip = (MasterData.Tips != null) ? MasterData.Tips.GetLoading() : ((m_sLocalTips != null) ? m_sLocalTips.GetLoading() : null);
				if (tip != null)
				{
					if (m_sTipsText != null)
					{
						m_sTipsText.text = tip.sContent;
					}
					if (m_sTipsTitleText != null)
					{
						m_sTipsTitleText.text = tip.sTitle;
					}
				}
			}
			if (!m_bExitReq)
			{
				return;
			}
			if (m_goTextRoot != null && m_goTextRoot.activeSelf && m_sTextAnim != null)
			{
				m_sTextAnim.TweenReverse();
			}
			m_eStep = EStep.eTEXT_OUT;
			break;
		case EStep.eTEXT_OUT:
			if (m_goTextRoot != null && m_goTextRoot.activeSelf && m_sTextAnim != null && !m_sTextAnim.IsAnimEnd)
			{
				return;
			}
			if (m_sBlackAnim != null)
			{
				m_sBlackAnim.FindTweener();
				UITweener[] tweens2 = m_sBlackAnim.GetComponents<UITweener>();
				for (int j = 0; j < tweens2.Length; j++)
				{
					if (tweens2[j] != null)
					{
						tweens2[j].duration = m_fDuration;
					}
				}
				m_sBlackAnim.TweenReverse();
			}
			m_eStep = EStep.eOUT;
			break;
		case EStep.eOUT:
			if (m_sBlackAnim == null || m_sBlackAnim.IsAnimEnd)
			{
				m_eStep = EStep.eNONE;
				gameObject.SetActive(false);
			}
			break;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		gameObject.SetActive(false);
	}

	private void SetColor(Color col)
	{
		if (m_sBlackAnimColor != null)
		{
			m_sBlackAnimColor.from = new Color(col.r, col.g, col.b, 0f);
			m_sBlackAnimColor.to = new Color(col.r, col.g, col.b, 1f);
		}
	}
}
