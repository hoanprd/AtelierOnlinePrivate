using UnityEngine;

public class AlterExecuteResultInfo : UIListViewBase<AlterExecuteResultSkillItem>
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sQualityPrefix;

	[SerializeField]
	private GameObject m_goNoneText;

	[SerializeField]
	private AlterExecuteResultExtraSkill m_sExtraSkill;

	[SerializeField]
	private LimitBreakMark m_sLimitBreak;

	[SerializeField]
	private UIGrid m_sGrid;

	public void InitNone(MasterItem master)
	{
	}

	public void Init(AlchemyConfirm.Item data)
	{
	}
}
