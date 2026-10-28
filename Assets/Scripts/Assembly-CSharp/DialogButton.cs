using UnityEngine;

[RequireComponent(typeof(UIButton))]
public class DialogButton : MonoBehaviour
{
	public UIButton m_sButton;

	public UILabel m_sLabel;

	public UISprite m_sBackground;

	private EButtonKind m_sType;

	public EButtonKind Type
	{
		get
		{
			return m_sType;
		}
	}

	public void SetCallback(EventDelegate del)
	{
		if (m_sButton != null && m_sButton.onClick != null)
		{
			m_sButton.onClick.Add(del);
		}
	}

	public void SetText(string text, EButtonKind type = EButtonKind.eNORMAL)
	{
		if (m_sLabel != null)
		{
			m_sLabel.text = text;
		}
		m_sType = type;
	}
}
