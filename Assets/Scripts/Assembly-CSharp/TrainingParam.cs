using System.Collections;
using System.Diagnostics;

public class TrainingParam : UIListViewBase<EquipmentParam>
{
	private CharaSpec m_sBaseParam;

	private CharaSpec m_sNextParam;

	public void Init(CharaDetail param)
	{
	}

	public void Init(CharaDetail param, CharaSpec up)
	{
	}

	public void Init(CharaSpec param)
	{
	}

	public void Init(CharaSpec param, CharaSpec up)
	{
	}

	public void Apply()
	{
	}

	[DebuggerHidden]
	private IEnumerator ApplyParam()
	{
		return null;
	}
}
