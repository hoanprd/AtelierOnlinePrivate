using System;
using UnityEngine;

public class INNPopup : MonoBehaviour
{
	public enum eLabel
	{
		CallUse = 0,
		CallHave = 1,
		Message = 2,
		EnumMax = 3
	}

	public enum eButton
	{
		Yes = 0,
		No = 1,
		Cancel = 2,
		EnumMax = 3
	}

	private eButton m_eClickedButton;

	private Action<eButton> m_acEndDismiss;

	private Action<eButton> m_acClick;

	private int m_iNeedCall;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private UITweenReset m_scrInOutTween;

	[SerializeField]
	private UIButton[] m_scrButtonAry;

	private void Awake()
	{
	}

	private void SetLabelText(eLabel eKind, string strText)
	{
	}

	private void OnClickYes()
	{
	}

	private void OnAPIEnd(VillageHealResponse clsRes)
	{
	}

	private void OnDialogEnd(EButtonKind eResult)
	{
	}

	private void OnClickNo()
	{
	}

	private void OnClickCancel()
	{
	}

	private void BringIn()
	{
	}

	private void Dismiss()
	{
	}

	private void OnEndDismiss()
	{
	}

	public void Init(int iNeedCall, Action<eButton> acEndCallBack, Action<eButton> acClickCallBack)
	{
	}

	public eButton GetClickedButton()
	{
		return eButton.Yes;
	}

	public bool IsEnd()
	{
		return false;
	}
}
