public class Game_Gimmick_DungeonWayPoint : Game_Gimmick_Portal
{
	public override bool IsUnlock()
	{
		return false;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public override bool IsEnable()
	{
		return false;
	}
}
