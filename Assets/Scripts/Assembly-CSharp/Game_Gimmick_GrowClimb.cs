public class Game_Gimmick_GrowClimb : Game_Gimmick_Base
{
	private GrowManager m_scrMng;

	private Game_Chara_MA_Player m_scrPlayer;

	protected override void OnHitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	public void SetInfo(GrowManager scrMng)
	{
	}

	public GrowManager GetManager()
	{
		return null;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public GrowManager.eDir GetDir()
	{
		return GrowManager.eDir.Climb;
	}
}
