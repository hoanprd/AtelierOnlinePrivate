using UnityEngine;

public class Game_MA_MoveSpeedColl : Game_MA_HitColl_Base
{
	private Game_Chara_MA_Player m_scrHitPlayer;

	public float m_fSpeedMag;

	protected override void HitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	protected void OnTriggerStay(Collider scrOther)
	{
	}

	protected override void ExitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	public void OnDrawGizmos()
	{
	}
}
