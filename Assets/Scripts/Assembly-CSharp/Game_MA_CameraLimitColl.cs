using UnityEngine;

public class Game_MA_CameraLimitColl : Game_MA_HitColl_Base
{
	public Vector2 m_v2CameraLimitPos_Min;

	public Vector2 m_v2CameraLimitPos_Max;

	protected override void Awake()
	{
	}

	protected override void HitPlayer(Game_Chara_MA_Player player)
	{
	}

	protected override void ExitPlayer(Game_Chara_MA_Player player)
	{
	}
}
