using System;
using System.Collections.Generic;

[Serializable]
public class AbnormalState : MasterRecordIdBase
{
	[Serializable]
	public class IdBean
	{
		public int id;
	}

	public string name;

	public int turn;

	public List<int> effectlist;

	public List<int> strongStatelist;

	public List<int> weakStatelist;

	public bool naturalheal;

	public string icon;

	public string telop;

	public int skillLow;

	public int skillHigh;

	public List<int> stateList;

	public List<IdBean> effectListJ;

	public List<IdBean> familyStateListJ;

	public List<IdBean> stateListJ;

	public bool IsAbnormalState()
	{
		return false;
	}

	public bool IsBuff()
	{
		return false;
	}

	public bool IsDebuff()
	{
		return false;
	}
}
