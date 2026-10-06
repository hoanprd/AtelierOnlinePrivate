using UnityEngine;

public class Game_Gimmick_CheckEnemy : Game_Gimmick_Base
{
	private long m_lEnemyNo;

	public ePickUpToolKind m_ePickUpKind;

	public eEffectKind m_eEffectKind;

	public Transform m_trEffectRoot;

	public eSoundID m_eSound;

	public float m_fSoundDelay;

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public ePickUpToolKind GetPickUpToolKind()
	{
		return ePickUpToolKind.None;
	}

	private Vector3 GetEffectPos()
	{
		return default(Vector3);
	}

	public override bool IsEnable()
	{
		return false;
	}

	public void SetEnemyNo(long enemyNo)
	{
	}

	public void Check()
	{
	}

	public void CheckEnd()
	{
	}
}
