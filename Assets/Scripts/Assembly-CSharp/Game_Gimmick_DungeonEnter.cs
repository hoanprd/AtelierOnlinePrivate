public class Game_Gimmick_DungeonEnter : Game_Gimmick_Base
{
	public int DungeonID;

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public override bool IsImmediate()
	{
		return false;
	}

	public override bool IsOnce()
	{
		return false;
	}
}
