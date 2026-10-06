using System;
using UnityEngine;

public class DialogBuyConfrim : UIWindowBase
{
	[SerializeField]
	private UILabel m_sContent;

	[SerializeField]
	private UITexture m_txCallIcon;

	[SerializeField]
	private UILabel m_sCallFreeNum;

	[SerializeField]
	private UILabel m_sCallComNum;

	[SerializeField]
	private UILabel m_sCallUseNum;

	[SerializeField]
	private UILabel m_sCallComWarning;

	[SerializeField]
	private UITexture m_txWealthIcon;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UILabel m_sNum;

	[SerializeField]
	private UILabel m_sUseNum;

	[SerializeField]
	private GameObject m_goCallRoot;

	[SerializeField]
	private GameObject m_goOtherRoot;

	private Action<EButtonKind> m_sOnResult;

	private EButtonKind m_eResult;

	public void Init(string content, EWealthKind kind, int use, Action<EButtonKind> onResult, bool compensationOnly = false)
	{
	}

	public void OnOK()
	{
	}

	public void OnCancel()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public static DialogBuyConfrim Create(string content, EWealthKind kind, int use, Action<EButtonKind> onResult, bool compensationOnly = false)
	{
		return null;
	}
}
