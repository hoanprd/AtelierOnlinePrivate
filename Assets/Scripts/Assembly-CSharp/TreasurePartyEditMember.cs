using UnityEngine;

public class TreasurePartyEditMember : TreasurePartyEditChara
{
	[SerializeField]
	private UIButton m_sRemoveButton;

	[SerializeField]
	private GameObject m_goMemberMark;

	public override void Init(int index, FormationInfo form)
	{
	}

	public override void Init(int index)
	{
	}
}
