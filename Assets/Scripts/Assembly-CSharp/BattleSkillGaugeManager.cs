using System.Collections.Generic;
using UnityEngine;

public class BattleSkillGaugeManager : MonoBehaviour
{
	[SerializeField]
	public GameObject m_gaugePrefab;

	private BattleSkillGauge[] m_asGauge;

	private List<BattleSkillGauge> m_vReserveList;

	public UIGrid SkillGaugeRoot;

	private GameObject[] GaugeArray;

	private BattleSkillGaugeListItem[] GaugeItemArray;

	private List<BattleSkillGaugeListItemEnemy> GaugeItemEnemyList;

	private int m_count;

	private void Awake()
	{
	}

	private void OnClick(BattleSkillGauge gauge)
	{
	}

	private void UpdateNextMark()
	{
	}

	private void Update()
	{
	}

	public void AddSkillGauge(MultiPlay_BattleMemberData memberData)
	{
	}

	public void AddSkillGaugeEnemy(MultiPlay_BattleMemberData member)
	{
	}

	public void ClearSkillGauge(bool flag)
	{
	}

	public void ClearSkillGauge()
	{
	}

	public void DidTapSkill(int memberID, int skillListID)
	{
	}

	public void ChangeStep(BattleSkillGaugeListItem.ESkillGaugeStep step, int memberID, int skillListID)
	{
	}

	public BattleSkillGaugeListItem GetReserveSkill()
	{
		return null;
	}

	public void SPChange(int memberID)
	{
	}

	public void SetGaugePause(bool flag)
	{
	}
}
