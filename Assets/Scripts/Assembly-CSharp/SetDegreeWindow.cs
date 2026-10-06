using System;
using System.Collections.Generic;
using UnityEngine;

public class SetDegreeWindow : UIListViewBase<SetDegreeItem>
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UILabel m_sHave;

	[SerializeField]
	private UIScrollListArrow m_sArrow;

	[SerializeField]
	private Transform m_trDegreeRoot;

	private DegreeIcon m_sDegreeIcon;

	[SerializeField]
	private Transform m_trSortWindowRoot;

	[SerializeField]
	private SortStateInfo m_sSortState;

	[SerializeField]
	private UILabel m_sFilterName;

	private SortFilterWindow m_sSortWindow;

	private ESortKind m_eSortKind;

	private EFilterKind m_eFilterKind;

	private EOrder m_eOrderKind;

	private List<DegreeInfo> m_vList;

	private List<DegreeInfo> m_vDispList;

	private DegreeInfo m_sNow;

	private Action<DegreeInfo> m_sOnCloseEvent;

	private const string SORT_PREFIX = "SET_DEGREE";

	public void Init(DegreeInfo now, DegreeInfo[] enableTTL, Action<DegreeInfo> onCloseEvent)
	{
	}

	private void CreateList()
	{
	}

	public void OnSelect(SetDegreeItem target)
	{
	}

	private void InitDegree(DegreeInfo degree)
	{
	}

	private void LoadSort()
	{
	}

	private void OnSortDecide(bool update)
	{
	}

	public void OnFilter()
	{
	}

	public void OnSort()
	{
	}

	public virtual void Bringin()
	{
	}

	public virtual void OnClose()
	{
	}

	protected void OnCloseEnd()
	{
	}

	private List<DegreeInfo> GetFilteredItem()
	{
		return null;
	}

	private List<DegreeInfo> GetSortItem(List<DegreeInfo> list)
	{
		return null;
	}
}
