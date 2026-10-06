using UnityEngine;

public class Game_MA_HitColl_Base : Game_Mover_Base
{
	public bool m_hitIsOnce;

	private float m_waitSec_Now;

	public float m_waitSec_NextHit;

	protected override void MoverUpdate_Normal()
	{
	}

	protected virtual void OnTriggerEnter(Collider col)
	{
	}

	protected virtual void HitPlayer(Game_Chara_MA_Player player)
	{
	}

	protected virtual void OnTriggerExit(Collider col)
	{
	}

	protected virtual void ExitPlayer(Game_Chara_MA_Player player)
	{
	}
}
