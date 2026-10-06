using System.Collections;
using System.Diagnostics;
using Tutorial;

public class TutorialCommandCloseLauncher : TutorialCommandBase
{
	public override void Exec(Data clsData)
	{
	}

	public override bool IsEnd()
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator CloseLauncher()
	{
		return null;
	}

	private bool IsOpen()
	{
		return false;
	}

	private bool IsEndAnimation()
	{
		return false;
	}
}
