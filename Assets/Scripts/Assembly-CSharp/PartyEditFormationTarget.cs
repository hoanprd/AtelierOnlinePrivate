using UnityEngine;

public class PartyEditFormationTarget : PartyEditFormationChara
{
	[SerializeField]
	private UIButton m_sEditEquipButton;

	[SerializeField]
	private LockMark m_sEditEquipLock;

	[SerializeField]
	private UIButton m_sTrainingButton;

	[SerializeField]
	private LockMark m_sTrainingLock;

	[SerializeField]
	private GameObject m_goEnableGrowBadge;

	[SerializeField]
	private GameObject m_goDisable;

	[SerializeField]
	private GameObject m_goTreasureMark;

	private bool m_bEnableEdit;

	public void Init(PartyMember info, int formIndex = 0, ESortKind sort = ESortKind.eLEVEL, bool select = false, bool enable = true)
	{
	}

	public virtual void SetEnable(bool sw)
	{
	}
}
