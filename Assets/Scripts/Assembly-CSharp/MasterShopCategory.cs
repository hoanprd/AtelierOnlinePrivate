using System;
using System.Collections.Generic;
using UnityEngine;

public class MasterShopCategory : ScriptableObject
{
	[Serializable]
	public class Data
	{
		public int iID;

		public string sName;

		public int iPrio;
	}

	public List<Data> m_vList;

	public Data Find(int id)
	{
		return null;
	}

	public string Get(int id)
	{
		return null;
	}
}
