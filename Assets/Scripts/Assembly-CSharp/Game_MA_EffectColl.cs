using UnityEngine;

public class Game_MA_EffectColl : Game_MA_HitColl_Base
{
	public enum eMakePosKind
	{
		CollRoot = 0,
		PlayerRoot = 1
	}

	public eEffectKind m_playEffectKind;

	public bool m_lightLayerFlag;

	public eMakePosKind m_makeEffectPosKind;

	public Vector3 m_effectOffset;

	protected override void HitPlayer(Game_Chara_MA_Player player)
	{
	}
}
