using System.Collections;
using System.Diagnostics;

public class CompositeEquipParamList : UIListViewBase<EquipmentParam>
{
	private EquipParam m_sBaseParam;

	private EquipParam m_sNextParam;

	public void Init(EquipParam param)
	{
	}

	public void Init(EquipParam param, EquipParam up)
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
