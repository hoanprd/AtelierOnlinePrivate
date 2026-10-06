using Tutorial;

public class TutorialCommandSkipSelect : TutorialCommandBase
{
	private bool m_bEnd;

	public override void Exec(Data clsData)
	{
	}

	public override bool IsEnd()
	{
		return false;
	}

	private void OnDialogEnd(EButtonKind eReslut)
	{
	}
}
