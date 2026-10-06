using System;
using System.Collections.Generic;

[Serializable]
public class FieldItem
{
	public int iItemId;

	public eFieldItemUse eUse;

	public eFieldItemRange eRange;

	public List<EAbnormalState> eStateList;

	public bool bOthers;
}
