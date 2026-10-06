public class Game_Gimmick_Check : Game_Gimmick_Base
{
	public enum eCheck
	{
		Dungeon = 0,
		Taru = 1,
		EnumMax = 2
	}

	public virtual eCheck GetCheck()
	{
		return eCheck.Dungeon;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
