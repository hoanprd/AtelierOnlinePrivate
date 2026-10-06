using UnityEngine;

public class RefundWindow : UIWindowBase
{
	[SerializeField]
	private UILabel m_call;

	[SerializeField]
	private UILabel m_guid;

	[SerializeField]
	private UILabel m_refund_code;

	[SerializeField]
	private UILabel m_cpLabel;

	private float copyAlpha;

	private string m_opne_url;

	public void SetWindow(int call, string guid, string code, string url)
	{
	}

	public void setClipboardGuid()
	{
	}

	public void setClipboardRefund()
	{
	}

	public void openUrl()
	{
	}

	public void Update()
	{
	}
}
