public class Game_MA_FieldDungeonEnter : Game_MA_HitColl_Base
{
	public int iAreaID;

	public int iStageID;

	public int iSpawnID;

	public bool bPopup;

	public string strPopupMessage;

	protected override void HitPlayer(Game_Chara_MA_Player player)
	{
	}

	private void EnterDungeon(MapInfo clsInfo)
	{
	}
}
