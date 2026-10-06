using System;

public class ItemListFilterWindow : UIListViewBase<ItemListFilterItem>
{
	public UIGrid m_sGrid;

	public UITweenReset m_sAnim;

	private bool m_bBringin;

	private Action<int> m_sCallback;

	public void Init(ECategory kind, int defaultCategory, Action<int> callback)
	{
	}

	private void Regist(int category, int defaultCategory)
	{
	}

	public void OnChange()
	{
	}

	public void OnCancel()
	{
	}

	public void OnClose()
	{
	}
}
