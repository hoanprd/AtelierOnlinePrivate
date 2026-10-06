using UnityEngine;

public class ADVLoading : SingletonBase<ADVLoading>
{
	private enum EStep
	{
		eNONE = 0,
		eIN = 1,
		eANIM_IN = 2,
		eWAIT = 3,
		eOUT = 4
	}

	[SerializeField]
	private UITweenReset m_sBlackAnim;

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

	public static void Disable(float duration = 0.5f)
	{
	}

	private void Update()
	{
	}

	protected override void Awake()
	{
	}
}
