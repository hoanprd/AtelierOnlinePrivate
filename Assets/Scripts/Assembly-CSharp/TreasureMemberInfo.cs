using UnityEngine;

public class TreasureMemberInfo : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_goInfoRoot;

	[SerializeField]
	protected GameObject m_goEmptyMark;

	[SerializeField]
	protected UITexture m_txCharaIcon;

	[SerializeField]
	protected UILabel m_sLevel;

	[SerializeField]
	protected UIGrid m_sLimitbreakGrid;

	[SerializeField]
	protected EquipWeaponElementInfo m_sWeaponInfo;

	[SerializeField]
	protected int m_iIndex;

	public int Index
	{
		get
		{
			return 0;
		}
	}

	public virtual void Init(int index, FormationInfo form)
	{
	}

	public virtual void Init(int index)
	{
	}

	protected void SetLimitbreak(int num)
	{
	}
}
