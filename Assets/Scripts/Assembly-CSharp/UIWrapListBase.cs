using System.Collections.Generic;
using UnityEngine;

public abstract class UIWrapListBase : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_goPrefab;

	[SerializeField]
	protected bool m_bUseOrginalPrefab;

	[SerializeField]
	protected int m_iDispPrefabNum;

	[SerializeField]
	protected UIWrapContent m_sWrapContent;

	[SerializeField]
	protected UIScrollView m_sScroll;

	[SerializeField]
	protected UIDragScrollView m_sDragScroll;

	[SerializeField]
	protected GameObject m_goUpArrow;

	[SerializeField]
	protected GameObject m_goDownArrow;

	[SerializeField]
	protected GameObject m_goNoneText;

	[SerializeField]
	protected UIWrapScrollBar m_sScrollBar;

	protected List<GameObject> m_vPrefabList;

	protected int m_iItemNum;

	protected virtual bool CreatePrefab()
	{
		return false;
	}

	protected void CreateList()
	{
	}

	protected void UpdateList()
	{
	}

	protected virtual void OnLoopItem(GameObject target, int wrapIndex, int realIndex)
	{
	}

	protected abstract void InitItem(int index, GameObject target);
}
