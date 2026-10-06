using System;
using UnityEngine;

public class LimitbreakConfirmWindow : UIWindowBase
{
	[Serializable]
	public class Info
	{
		public GameObject goRoot;

		public UITexture txFaceIcon;

		public UILabel sHaveNum;

		public UILabel sResultNum;

		public void Init(int charaDF, int now, int result)
		{
		}
	}

	[SerializeField]
	private Info m_sEnough;

	[SerializeField]
	private Info m_sNotEnough;

	[SerializeField]
	private GameObject m_goOKButton;

	[SerializeField]
	private UILabel m_sCancelText;

	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private UILabel m_sContent;

	public void Init(int charaDF, int now, int need)
	{
	}
}
