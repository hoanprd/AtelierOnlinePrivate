using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class FairyPickResultWindow : UIListViewBase<FairyPickResultOnce>
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private UICenterOnChild m_sCenter;

	[SerializeField]
	private GameObject m_goOKButton;

	[SerializeField]
	private UIButton m_sSkipButton;

	private int m_iSelect;

	private FairyPickResultOnce m_sActive;

	private void Test()
	{
	}

	public void Init(FairyPickResult[] result)
	{
	}

	[DebuggerHidden]
	private IEnumerator InitList(FairyPickResult[] result)
	{
		return null;
	}

	public void OnOpenStart()
	{
	}

	public void OnSkip()
	{
	}

	public void OnClose()
	{
	}

	public void OnCloseEnd()
	{
	}

	[DebuggerHidden]
	private IEnumerator Execute()
	{
		return null;
	}
}
