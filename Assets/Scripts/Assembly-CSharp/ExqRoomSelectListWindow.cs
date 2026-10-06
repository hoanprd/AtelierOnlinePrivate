using System;
using System.Collections.Generic;
using UnityEngine;

public class ExqRoomSelectListWindow : UIListViewBase<SetExqRoomSelectListItem>
{
	private const int SCROLL_LIMIT_MAX_NUM = 8;

	private const int NO_DEFAULT_SELECTED = 999;

	[SerializeField]
	private UILabel m_lWindowTitle;

	[SerializeField]
	private Dictionary<int, string> m_dicItems;

	[SerializeField]
	private UITweenReset m_trAnim;

	private int m_selectedKey;

	private Action<int> m_saCallback;

	public void Init(string title, Dictionary<int, string> listSelectItems, Action<int> callback, int selectedKey = 999)
	{
	}

	private void CreateList()
	{
	}

	public void OnDecide(SetExqRoomSelectListItem item)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
