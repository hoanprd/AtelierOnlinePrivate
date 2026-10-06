using UnityEngine;

public class Game_Gimmick_Portal : Game_Gimmick_Base
{
	[SerializeField]
	private GameObject m_goLight;

	protected bool m_bUnlock;

	protected int m_iPortalId;

	protected void UpdateLight(bool bUnlockEffect)
	{
	}

	public virtual bool IsUnlock()
	{
		return false;
	}

	public override bool IsEnable()
	{
		return false;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public void SetPortalId(int iId)
	{
	}

	public int GetPortalId()
	{
		return 0;
	}

	public void Unlock(bool bUnlockEffect = true)
	{
	}
}
