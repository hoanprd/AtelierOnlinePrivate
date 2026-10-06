using System.Collections;
using System.Diagnostics;
using Tutorial;

public class TutorialCommandOpenLauncher : TutorialCommandBase
{
	private int m_iSubMenu;

	private LauncherBase m_sLauncher;

	private bool m_bExit;

	public override void Exec(Data clsData)
	{
	}

	public override bool IsEnd()
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator OpenLauncher()
	{
		return null;
	}
}
