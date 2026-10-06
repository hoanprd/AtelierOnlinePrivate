using System;
using System.Collections.Generic;
using UnityEngine;

public class AlterKeywordSelect : UIListViewBase<AlterKeywordItem>
{
	[Serializable]
	public struct ButtonInfo
	{
		public UIToggle sToggle;

		public UILabel sWord;
	}

	private const int ciKEYWORD_NUM = 3;

	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private ButtonInfo[] m_asSelectButtons;

	[SerializeField]
	private UIButton m_sDecide;

	[SerializeField]
	private UITweenReset m_sSelectionAnim;

	[SerializeField]
	private UITweenReset m_sInoutAnim;

	[SerializeField]
	private AlterKeywordDecideTitle m_sDecideTitle;

	[SerializeField]
	private List<EventDelegate> m_vCloseCallback;

	private int[] m_aiSelectKeywordList;

	private int m_iSelectBoxIndex;

	public string Keyword
	{
		get
		{
			return null;
		}
	}

	public int[] Keywords
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Init(EventDelegate callback)
	{
	}

	public void OnSelectKeywordBox(UIToggle target)
	{
	}

	public void OnSelectWord(AlterKeywordItem target)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnClose()
	{
	}

	private void UpdateDecideState()
	{
	}

	private void UpdateKeywordList()
	{
	}
}
