using UnityEngine;

public class Game_Gimmick_FreezeBomb : Game_Gimmick_BombBase
{
	private enum eMainStep
	{
		First = 0,
		Up = 1,
		Explode = 2,
		Last = 3,
		End = 4
	}

	private static readonly float sc_fBombSize;

	private eMainStep m_eMainStep;

	private bool m_bSetFire;

	private Vector3 m_v3TargetPos;

	private float m_fExplodeTh;

	private float m_fYPosLog;

	private Rigidbody m_scrRigid;

	private Vector3 m_v3MyGravity;

	private float m_fWaitTime;

	[SerializeField]
	private float m_fThrowAngle;

	private void FixedUpdate()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	private void ThrowBomb(Vector3 v3Target, float fAngle)
	{
	}

	public override eBombKind GetBombKind()
	{
		return eBombKind.Normal;
	}

	public void SetFire(Vector3 v3Target, float fScale)
	{
	}
}
