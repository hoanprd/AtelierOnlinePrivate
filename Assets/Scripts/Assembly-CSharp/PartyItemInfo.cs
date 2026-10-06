using System;
using System.Collections.Generic;

[Serializable]
public class PartyItemInfo
{
	[Serializable]
	public class EnableItem : ResponseBase
	{
		public int CATEG;
	}

	public PartyItemManualInfo MANU;

	public List<PartyItemData> AUTO;

	public List<EnableItem> ENB;
}
