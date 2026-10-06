using System.Collections.Generic;
using UnityEngine;

public class UIListViewBase<T> : MonoBehaviour where T : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_goObjectPrefab;

	[SerializeField]
	protected Transform m_trRoot;

	[SerializeField]
	protected UIScrollView m_sScroll;

	protected List<T> m_vObjectList;

	protected int m_iUseCount;

	public int UseCount
	{
		get
		{
			return 0;
		}
	}

	public bool EnableScroll
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(GameObject prefab, Transform root)
	{
	}

	public void Reposition()
	{
	}

	public void Clear()
	{
	}

	public virtual void Reset()
	{
	}

	public virtual T GetObject()
	{
		return null;
	}

	public int GetIndex(T tgt)
	{
		return 0;
	}

	public T Get(int index)
	{
		return null;
	}
}
