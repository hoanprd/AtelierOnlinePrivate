using System;

public class Game_Gimmick_ExitDungeonPortal : Game_Gimmick_Base
{
	[NonSerialized]
	public int m_iMoveValue;

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
