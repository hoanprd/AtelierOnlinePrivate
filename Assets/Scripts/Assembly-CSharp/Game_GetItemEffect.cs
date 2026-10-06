using UnityEngine;

public class Game_GetItemEffect : System_Mover_Base
{
	private Vector3 m_gotchaPos;

	private Vector3 m_gotchaAdd;

	private static readonly Vector3 m_gotchaPos_Target;

	private static readonly float m_waitSec_Max;

	private float m_waitSec_Now;

	protected override void Awake()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}
}
