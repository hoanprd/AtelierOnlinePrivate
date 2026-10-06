using UnityEngine;

public class Game_Gimmick_ThrowBomb : Game_Gimmick_BombBase
{
	private enum eMainStep
	{
		First = 0,
		Put = 1,
		Last = 2,
		End = 3
	}

	private float m_waitSec_Now;

	private bool m_isSetFire;

	private Vector3 m_BombPos;

	private eMainStep m_mainStep;

	private float m_waitSec_PutBomb;

	protected override void Awake()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	public override eBombKind GetBombKind()
	{
		return eBombKind.Normal;
	}

	public void SetFire(Vector3 bombPos)
	{
	}
}
