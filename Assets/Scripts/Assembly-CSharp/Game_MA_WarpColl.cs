using UnityEngine;

public class Game_MA_WarpColl : Game_MA_HitColl_Base
{
	public GameObject m_goWarpPos;

	public Game_Chara_MA_Player.eDirection m_eAfterWarpDir;

	public bool m_bUseDiff;

	protected override void HitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}
}
