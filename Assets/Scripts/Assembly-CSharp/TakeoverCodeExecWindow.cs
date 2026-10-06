using UnityEngine;

public class TakeoverCodeExecWindow : UIWindowBase
{
	[SerializeField]
	private GameObject m_goTakeoverWindow;

	[SerializeField]
	private UIWindowBase m_sWarningWindow;

	[SerializeField]
	private UIInput m_sMyID;

	[SerializeField]
	private UIInput m_sTakeoverCode;

	[SerializeField]
	private UIButton m_sExecButton;

	[SerializeField]
	private UIButton m_sDecide;

	[SerializeField]
	private UILabel m_sWarnTitle;

	[SerializeField]
	private UILabel m_sWarnTxt;

	public void Init()
	{
	}

	public void OnExec()
	{
	}

	public void OnDecide()
	{
	}

	private void OnLogout(ResponseDataCommon res)
	{
	}

	public void OnChangeInput()
	{
	}

	private void LateUpdate()
	{
	}

	public static TakeoverCodeExecWindow Create()
	{
		return null;
	}

	protected override void OnCloseEnd()
	{
	}

	private void InitInputField(UIInput field)
	{
	}
}
