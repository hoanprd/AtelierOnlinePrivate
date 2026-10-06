using System.Collections;
using System.Diagnostics;
using Tutorial;

public class TutorialCommandWait : TutorialCommandBase
{
	private bool m_bWaitEnd;

	public override void Exec(Data clsData)
	{
	}

	[DebuggerHidden]
	private IEnumerator WaitSecond(float fSecond)
	{
		return null;
	}

	public override bool IsEnd()
	{
		return false;
	}
}
