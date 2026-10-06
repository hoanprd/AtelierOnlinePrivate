using System.Collections.Generic;
using UnityEngine;

public class GrowBlazeArtsParam : MonoBehaviour
{
	public enum eType
	{
		ATTACK = 0,
		SCOPE = 1,
		ELEMENT = 2,
		EFFECT = 3,
		DAMAGE = 4
	}

	[SerializeField]
	private UILabel m_sSkillTitleLab;

	[SerializeField]
	private UILabel m_sSkillStatusLab;

	[SerializeField]
	private UILabel m_sChangeSkillStatusLab;

	[SerializeField]
	private GameObject m_sUpArrow;

	private int m_iPage;

	private List<ActiveSkill> m_sSkillList;

	private eType m_sType;

	public eType Type
	{
		get
		{
			return eType.ATTACK;
		}
	}

	public void Init(List<ActiveSkill> master, eType type)
	{
	}

	public void NextPage(ActiveSkill nowSkill, ActiveSkill afterSkill, bool isLvUp)
	{
	}

	public void NextPage()
	{
	}

	private void SetAttackText(List<ActiveSkill> skillList)
	{
	}

	private void SetScopeText(List<ActiveSkill> skillList)
	{
	}

	private void SetElementText(List<ActiveSkill> skillList)
	{
	}

	private void SetEffectText(List<ActiveSkill> skillList)
	{
	}

	private void SetDamageText(List<ActiveSkill> skillList)
	{
	}

	public void CalcAndActiveDiffValue(ActiveSkill now, ActiveSkill after, bool isLvUp)
	{
	}

	public void ActiveDiffValue(float value)
	{
	}

	public void InactiveDiffValue()
	{
	}
}
