using System.Collections.Generic;
using UnityEngine;

public class DisplayList : ScriptableObject
{
	public int m_iCategory;

	public List<Display> m_vList;

	public int Category
	{
		get
		{
			return 0;
		}
	}

	public DisplayList(int category)
	{
	}

	public void Clear()
	{
	}

	public void Add(int id, string content)
	{
	}

	public Display Find(int id)
	{
		return null;
	}

	private void OnEnable()
	{
	}
}
