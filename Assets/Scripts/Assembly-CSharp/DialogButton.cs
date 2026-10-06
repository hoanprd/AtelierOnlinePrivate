using UnityEngine;

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
			return EButtonKind.eNORMAL;
		}
	}

	public void SetCallback(EventDelegate del)
	{
	}

	public void SetText(string text, EButtonKind type = EButtonKind.eNORMAL)
	{
	}
}
