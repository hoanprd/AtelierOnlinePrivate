using System;

public class FiltersWindow : UIListViewBase<SortWindowItem>
{
	private int m_iSelect;

	private Action<int> m_sOnSelect;

	public void Init(int select, SortItemInfo[] info, Action<int> onSelect)
	{
	}

	public void Init(int select)
	{
	}

	public void OnSelect(SortWindowItem item)
	{
	}
}
