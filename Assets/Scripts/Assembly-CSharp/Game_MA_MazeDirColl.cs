public class Game_MA_MazeDirColl : Game_MA_HitColl_Base
{
	public enum eMazeDir
	{
		Go = 0,
		Return = 1,
		EnumMax = 2
	}

	public eMazeDir m_eDir;

	protected override void HitPlayer(Game_Chara_MA_Player player)
	{
	}
}
