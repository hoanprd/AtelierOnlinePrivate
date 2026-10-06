using UnityEngine;

public class PartyEditFormationMember : PartyEditFormationChara
{
	[SerializeField]
	private GameObject m_goInfoRoot;

	[SerializeField]
	private GameObject m_goEmptyMark;

	[SerializeField]
	private UIButton m_sRemoveButton;

	private int m_iFormIndex;

	public int Index
	{
		get
		{
			return 0;
		}
	}

	public override void Init(PartyMember info, int formIndex = 0, ESortKind sort = ESortKind.eLEVEL, bool select = false)
	{
	}
}
