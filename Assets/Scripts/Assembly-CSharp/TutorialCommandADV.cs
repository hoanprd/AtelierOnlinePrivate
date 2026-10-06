using Tutorial;

public class TutorialCommandADV : TutorialCommandBase
{
	private bool m_bReturnTitleDialog;

	public override void Exec(Data clsData)
	{
	}

	public override bool IsEnd()
	{
		return false;
	}

	private void OnADVErrorDialog(EButtonKind eResult)
	{
	}
}
