using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class BattlePlayerCharaInfo : BattleCharaInfo
{
	public class BlazeArtsObject
	{
		public GameObject mainObj;

		public GameObject maxObj;

		public GameObject efcTap;

		public GameObject gaugeRec;

		public UITexture color;

		public BlazeArtsObject(GameObject _mainObj, UITexture _icon)
		{
		}
	}

	public const int BLAZE_ARTS_SKILL_INDEX = 99;

	private BattleSkillGaugeListItem.ESkillGaugeStep m_step;

	private MultiPlay_BattleData m_battleData;

	private MultiPlay_BattleCharaData m_charaData;

	private BattleCharaData m_battleCharaData;

	private ActiveSkill m_blazeArtsSkill;

	[SerializeField]
	private GameObject m_button;

	[SerializeField]
	private UITexture m_icon;

	private BlazeArtsObject m_blazeArtsObj;

	[SerializeField]
	private Color m_defaultColor;

	[SerializeField]
	private Color m_grayColor;

	public override void Init(MultiPlay_BattleMemberData memberData, LongTapButton longButton)
	{
	}

	public void UpdateMe()
	{
	}

	public void DidTapBlazeArts(bool auto = false)
	{
	}

	protected override Object[] IconChange()
	{
		return null;
	}

	protected override void IconChangeOnLongTapStart()
	{
	}

	public void ChangeStep(BattleSkillGaugeListItem.ESkillGaugeStep step, int memberID)
	{
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
}
