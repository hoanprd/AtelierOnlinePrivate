using System;

public class DialogUnsupportedDevice : UIWindowBase
{
	private Action m_sResultEvent;

	public void Init(Action onResult)
	{
	}

	public void OnDispOfficialSite()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public static DialogUnsupportedDevice Create()
	{
		return null;
	}
}
