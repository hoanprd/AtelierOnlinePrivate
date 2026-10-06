public class Game_Gimmick_FreezeObject : Game_Gimmick_UseBombBase
{
	protected override void MoverUpdate_Normal()
	{
	}

	protected override void ExecOwn()
	{
	}

	protected override void ExecMultiSub(bool perform)
	{
	}

	private void CommonExec(bool perform)
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
