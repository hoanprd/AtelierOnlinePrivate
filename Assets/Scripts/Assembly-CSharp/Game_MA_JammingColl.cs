public class Game_MA_JammingColl : Game_MA_HitColl_Base
{
	public enum eKind
	{
		Off = 0,
		On = 1
	}

	public eKind m_jammingKind;

	protected override void HitPlayer(Game_Chara_MA_Player player)
	{
	}

	private void SetJamming()
	{
	}

	public static void RemoveJamming()
	{
	}
}
