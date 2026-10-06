using UnityEngine;

public class TakeoverCodeWindow : UIWindowBase
{
	[SerializeField]
	private GameObject m_goTakeoverCodeWindow;

	[SerializeField]
	private UILabel m_sMyID;

	[SerializeField]
	private UILabel m_sTakeoverCode;

	private static readonly string ConfirmDialogTitle;

	private static readonly string ConfirmDialogText;

	public void Init()
	{
	}

	public void OnUpdate()
	{
	}

	public void OnCopyText()
	{
	}

	public void UpdateTakeoverCode()
	{
	}

	public static TakeoverCodeWindow Create()
	{
		return null;
	}

	protected override void OnCloseEnd()
	{
	}
}
