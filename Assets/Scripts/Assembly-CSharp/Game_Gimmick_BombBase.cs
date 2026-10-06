using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class Game_Gimmick_BombBase : Game_Gimmick_Base
{
	public enum eExplodeEffect
	{
		Normal = 0,
		Freeze = 1,
		Grow = 2,
		None = 3,
		EnumMax = 4
	}

	public enum eExplodeSound
	{
		Normal = 0,
		Freeze = 1,
		Grow = 2,
		Wind = 3,
		EnumMax = 4
	}

	private static readonly eEffectKind[] sc_eExplodeEffectAry;

	private static readonly eSoundID[] sc_eExplodeSEAry;

	protected static readonly float sc_fExplodeEffectWait;

	protected Game_Chara_MA_Player m_scrPlayer;

	protected bool m_bExploded;

	[SerializeField]
	private eExplodeEffect m_eExplodeEff;

	[SerializeField]
	private eExplodeSound m_eExplodeSE;

	[SerializeField]
	private GameObject m_goBarrel;

	public static eEffectKind GetBombEffectKind(eBombKind eBomb)
	{
		return eEffectKind.Touch_Hit;
	}

	protected override void OnHitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	protected override void OnExitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	[DebuggerHidden]
	public IEnumerator Explode()
	{
		return null;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public override bool IsImmediate()
	{
		return false;
	}

	public override bool IsEnable()
	{
		return false;
	}

	public virtual eBombKind GetBombKind()
	{
		return eBombKind.Normal;
	}
}
