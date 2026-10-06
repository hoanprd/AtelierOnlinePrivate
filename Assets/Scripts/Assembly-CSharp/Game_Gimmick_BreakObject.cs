public class Game_Gimmick_BreakObject : Game_Gimmick_UseBombBase
{
	public enum eBreakEffectKind
	{
		Rock = 0,
		Tree = 1,
		EnumMax = 2
	}

	public eBreakEffectKind m_breakEffectKind;

	private static readonly eEffectKind[] m_effectKindArray;

	protected override string GetExecEffectAssetPath()
	{
		return null;
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected override void ExecOwn()
	{
	}

	protected override void ExecMultiSub(bool perform)
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
