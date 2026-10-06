using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MasterListBase<T> : ScriptableObject where T : MasterRecordBase
{
	[SerializeField]
	public List<T> m_vList;

	private Dictionary<int, T> m_map;

	public List<T> List
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public T Find(int df)
	{
		return null;
	}

	public void MakeMap()
	{
	}
}
