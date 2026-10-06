using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using migrate;

public class TakeoverDialog : UIWindowBase
{
	[SerializeField]
	private UITable m_sTable;

	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private UIScrollView m_sScrollView;

	[SerializeField]
	private TakeoverItem m_sPrefab;

	[SerializeField]
	private GameObject m_goWarning;

	[SerializeField]
	private GameObject m_goTakeoverWindow;

	[SerializeField]
	private UIWindowBase m_sWarningWindow;

	[SerializeField]
	private UIButton m_sDecide;

	private string m_before_user_id;

	private int m_iNowAuthKind;

	private List<TakeoverItem> m_vItemList;

	private bool m_bFirst;

	private AuthenticationManager.AuthType m_sKind;

	private List<AuthenticationManager.AuthType> m_vAuthTypeList;

	private string m_strBeforeSno;

	public void Init(bool first)
	{
	}

	public void OnDispInfo()
	{
	}

	public void OnSelectAuthType(AuthenticationManager.AuthType type)
	{
	}

	public void OnAuthStart()
	{
	}

	private void ReleaseLinkageDialogCallback(EButtonKind button)
	{
	}

	private void AuthenticateLinkageIDCallback(bool is_success)
	{
	}

	private void ResearchCoopUserCallback(TitleUserCreateResponse response)
	{
	}

	private void CoopUserCallback(TitleUserCreateResponse response)
	{
	}

	private bool IsAPISuccess<T>(ResponseData<T> response)
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator Authentication()
	{
		return null;
	}

	private void ShowConnecting()
	{
	}

	private void HideConnecting()
	{
	}

	private void OnAuthSuccess()
	{
	}

	private void OnLogout(ResponseDataCommon res)
	{
	}

	private void OnAuthCancelOrFailed()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public static TakeoverDialog Create()
	{
		return null;
	}
}
