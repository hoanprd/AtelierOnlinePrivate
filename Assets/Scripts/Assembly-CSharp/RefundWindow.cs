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

	private float copyAlpha = -1f;

	private string m_opne_url = string.Empty;

	public void SetWindow(int call, string guid, string code, string url)
	{
		if (m_call != null)
		{
			m_call.text = call.ToString();
		}
		if (m_guid != null)
		{
			m_guid.text = guid;
		}
		if (m_refund_code != null)
		{
			m_refund_code.text = code;
		}
		m_opne_url = url;
	}

	public void setClipboardGuid()
	{
		if (m_guid != null)
		{
			GUIUtility.systemCopyBuffer = m_guid.text;
		}
		copyAlpha = 0.01f;
	}

	public void setClipboardRefund()
	{
		if (m_refund_code != null)
		{
			GUIUtility.systemCopyBuffer = m_refund_code.text;
		}
		copyAlpha = 0.01f;
	}

	public void openUrl()
	{
		if (!string.IsNullOrEmpty(m_opne_url))
		{
			Application.OpenURL(m_opne_url);
		}
	}

	public void Update()
	{
		if (copyAlpha > 0f)
		{
			copyAlpha += 0.07f;
			if (m_cpLabel != null)
			{
				Color col = m_cpLabel.color;
				float a = copyAlpha;
				if (a <= 2f)
				{
					if (a > 1f)
					{
						a = 2f - a;
					}
				}
				else
				{
					copyAlpha = -1f;
					a = 0f;
				}
				col.a = a;
				m_cpLabel.color = col;
			}
		}
	}
}
