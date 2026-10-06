using System.Collections.Generic;
using UnityEngine;

public class GrowBlazeArtsParamWnd : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sSkillName;

	[SerializeField]
	private UILabel m_sContext;

	[SerializeField]
	private GrowBlazeArtsParam m_sSkillStatusPrefab;

	[SerializeField]
	private UIGrid m_sSkillStatusRoot;

	[SerializeField]
	private GameObject m_sNextBtn;

	private List<GrowBlazeArtsParam> m_sStatusList;

	private ActiveSkill m_sNowSkill;

	private ActiveSkill m_sAfterSkill;

	private bool m_bIsLvUp;

	public void Init(ActiveSkill master)
	{
	}

	public void Init(ActiveSkill now, ActiveSkill up, bool isLvUp)
	{
	}

	private void CreateStatusPrefabs(ActiveSkill master)
	{
	}

	private float CalcDiffAddEffectValue(ActiveSkill now, ActiveSkill up)
	{
		return 0f;
	}

	private float CalcDiffDamageValue(ActiveSkill now, ActiveSkill up)
	{
		return 0f;
	}

	public void Destroy()
	{
	}

	public void OnNextButton()
	{
	}
}
