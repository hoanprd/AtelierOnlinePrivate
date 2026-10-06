using UnityEngine;

internal class CompositeQualityLimitDialog : UIWindowBase
{
	[SerializeField]
	private ExqRoomConfirmWindow m_sConfirmWindow;

	private CompositeTarget m_sTarget;

	private CompositeInfo m_compositeInfo;

	public void Init(CompositeInfoResponse res)
	{
	}

	public override void OnClose()
	{
	}

	public void OnConfirm()
	{
	}
}
