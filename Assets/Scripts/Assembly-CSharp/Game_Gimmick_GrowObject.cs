public class Game_Gimmick_GrowObject : Game_Gimmick_UseBombBase
{
	public GrowManager m_scrMng;

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

	public void SetData(float fLength, float fClimbDir)
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
