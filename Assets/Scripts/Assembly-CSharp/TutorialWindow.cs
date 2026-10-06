using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Tutorial;
using UnityEngine;

public class TutorialWindow : SingletonBase<TutorialWindow>
{
	public enum eButton
	{
		OK = 0,
		Next = 1,
		Prev = 2,
		EnumMax = 3
	}

	public enum eLabel
	{
		Title = 0,
		CatchPhrase = 1,
		Detail = 2,
		Page = 3,
		EnumMax = 4
	}

	private List<Data> m_clsDataList;

	private int m_iPageNow;

	private bool m_bReachedMaxPage;

	private bool m_bUpdateBtnColor;

	private bool m_bEndPageTween;

	private bool m_bEnd;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private UITexture m_scrTexture;

	[SerializeField]
	private UITweenReset m_scrRootTween;

	[SerializeField]
	private UITweenReset m_scrPageTween;

	[SerializeField]
	private UITweenReset m_scrCatchTween;

	[SerializeField]
	private GameObject m_goCatchPhrase;

	[SerializeField]
	private GameObject m_goPageButtonPrev;

	[SerializeField]
	private GameObject m_goPageButtonNext;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private UIButton m_scrCloseButton;

	private int m_iPageMax
	{
		get
		{
			return 0;
		}
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetLabel(eLabel eKind, string strText)
	{
	}

	private void InitPage()
	{
	}

	[DebuggerHidden]
	private IEnumerator ChangePage(int iPage)
	{
		return null;
	}

	private void OnEndPageTween()
	{
	}

	private void SetPage(int iPage)
	{
	}

	private void Dismiss()
	{
	}

	private void OnEndDismiss()
	{
	}

	public void Init(List<Data> clsDataList, string strAssetName, float fDelay)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void ClickedButton(eButton eKind)
	{
	}
}
