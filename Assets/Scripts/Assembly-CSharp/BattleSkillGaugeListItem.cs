using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class BattleSkillGaugeListItem : UIBase
{
	public enum ESkillGaugeStep
	{
		Accept = 0,
		ReserveWait = 1,
		Reserve = 2,
		CancelWait = 3,
		WaitMoment = 4
	}

	public class SkillObject
	{
		public GameObject mainObj;

		public GameObject noneObj;

		public GameObject maxObj;

		public GameObject efcTap;

		public GameObject gaugeRec;

		public UITexture color;

		public SkillObject(GameObject _mainObj, int num)
		{
		}
	}

	private ESkillGaugeStep m_step;

	private MultiPlay_BattleData m_battleData;

	private MultiPlay_BattleMemberData m_memberData;

	private MultiPlay_BattleCharaData m_charaData;

	private BattleCharaData m_battleCharaData;

	private int m_index;

	private ActiveSkill m_skill;

	private int m_beforeTurn;

	private float m_spAddRate;

	private float m_SP0;

	private float m_SP1;

	private float m_plusSP0;

	private float m_plusSP1;

	private bool m_plusSPFlag;

	private bool m_sliderPause;

	[SerializeField]
	private UISlider m_slider;

	[SerializeField]
	private GameObject m_button;

	private SkillObject skillObj;

	[SerializeField]
	private Transform m_longTapParentObj;

	private GameObject m_longTapObj;

	private UITweenReset m_longTapOuttweens;

	[SerializeField]
	private Color m_defaultColor;

	[SerializeField]
	private Color m_grayColor;

	public void Init(MultiPlay_BattleMemberData memberData, int index)
	{
	}

	public void UpdateMe()
	{
	}

	public void SPChange(int memberID)
	{
	}

	public void SetGaugePause(bool pause)
	{
	}

	public void DidTapSkill(bool auto = false)
	{
	}

	public void DidTapSkillOut(int memberID, int index)
	{
	}

	public void ChangeStep(ESkillGaugeStep step, int memberID, int index)
	{
	}

	public ESkillGaugeStep GetStep()
	{
		return ESkillGaugeStep.Accept;
	}

	[DebuggerHidden]
	private IEnumerator Accept()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator WaitMoment()
	{
		return null;
	}

	public MultiPlay_BattleMemberData GetMember()
	{
		return null;
	}

	private void DidLongTapSkill()
	{
	}

	private string GetSkillText()
	{
		return null;
	}

	private void ClearLongTapSkill()
	{
	}

	private void OnOutFinished()
	{
	}
}
