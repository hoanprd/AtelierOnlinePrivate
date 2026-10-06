using UnityEngine;

public class BattleSkillGauge : MonoBehaviour
{
	private enum EAnimKind
	{
		eMAX = 0,
		eRESERVE = 1,
		eEXECUTE = 2
	}

	public GameObject m_goMax;

	public GameObject m_goNext;

	public GameObject m_goNextText;

	public GameObject m_goExecute;

	public GameObject m_goNone;

	public UISlider m_sGauge;

	public UISprite m_sGaugeSprite;

	public UITexture m_tIcon;

	public UIButton m_sButton;

	private UITweenReset[] m_asAnim;

	private int m_iSkillID;

	public int ID
	{
		get
		{
			return 0;
		}
	}

	public bool IsReserve
	{
		get
		{
			return false;
		}
	}

	public UIButton Button
	{
		get
		{
			return null;
		}
	}

	public bool IsGaugeMax
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	private void StartAnim(EAnimKind kind)
	{
	}

	public void Init(int skillID)
	{
	}

	public void SetValue(float value)
	{
	}

	public void AddValue(float value)
	{
	}

	public void SetReserve(bool sw)
	{
	}

	public void SwitchReserve()
	{
	}

	public void SetNextMark(bool sw)
	{
	}

	public void Reset()
	{
	}

	public void Execute()
	{
	}
}
