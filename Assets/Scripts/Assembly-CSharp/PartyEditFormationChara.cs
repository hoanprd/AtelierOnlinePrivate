using UnityEngine;

public class PartyEditFormationChara : MonoBehaviour
{
	public enum ERole
	{
		eNONE = 0,
		eLEADER = 1,
		eMEMBER = 2
	}

	[SerializeField]
	protected UITexture m_txCharaIcon;

	[SerializeField]
	protected GameObject m_goSelectMark;

	[SerializeField]
	protected UILabel m_sRoleName;

	[SerializeField]
	protected UISprite m_sRolePlate;

	[SerializeField]
	protected UISprite m_sRoleFrame;

	[SerializeField]
	protected UILabel m_sLevel;

	[SerializeField]
	protected UILabel m_sStatus;

	[SerializeField]
	protected UISprite m_sStatusIcon;

	[SerializeField]
	protected UILongTapButton m_sSelectButton;

	[SerializeField]
	protected EquipWeaponElementInfo m_sWeaponInfo;

	[SerializeField]
	protected UIGrid m_sLimitbreakGrid;

	protected PartyMember m_sInfo;

	protected CharaSpec m_sSpec;

	protected readonly Color ccLEADER_COLOR;

	protected readonly Color ccMEMBER_COLOR;

	protected readonly Color ccLEADER_FRAME_COLOR;

	protected readonly Color ccMEMBER_FRAME_COLOR;

	public PartyMember Info
	{
		get
		{
			return null;
		}
	}

	public virtual void Init(PartyMember info, int formIndex = 0, ESortKind sort = ESortKind.eLEVEL, bool select = false)
	{
	}

	public void Select(bool sw, bool se = false)
	{
	}

	public void SetSortKind(ESortKind kind)
	{
	}

	public virtual void SetRole(int index)
	{
	}

	protected void SetLimitbreak(int num)
	{
	}
}
