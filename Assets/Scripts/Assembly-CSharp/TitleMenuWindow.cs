using UnityEngine;

public class TitleMenuWindow : UIWindowBase
{
	[SerializeField]
	private GameObject m_goTakeOver;

	[SerializeField]
	private GameObject m_goTakeOverCode;

	public override void Bringin()
	{
		bool hasUser = PlayerPrefs.HasKey("USERID");
		if (m_goTakeOver != null)
		{
			m_goTakeOver.SetActive(hasUser);
		}
		if (m_goTakeOverCode != null)
		{
			m_goTakeOverCode.SetActive(hasUser);
		}
		base.Bringin();
	}

	public void OnDispInfo()
	{
		DialogCommon.CreateOKDialog("オフラインモードで動作中です。");
	}

	public void OnContactUs()
	{
		ContactUsWindow win = ContactUsWindow.Create();
		if (win != null)
		{
			win.Bringin();
		}
		else
		{
			DialogCommon.CreateOKDialog("オフラインモードのためお問い合わせは利用できません。");
		}
	}
}
