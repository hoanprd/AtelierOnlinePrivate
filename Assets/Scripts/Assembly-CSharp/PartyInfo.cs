using System;
using System.Collections.Generic;

[Serializable]
public class PartyInfo
{
	public PartyItemInfo ITM;

	public List<FormationInfo> FRM;

	public List<PartyMember> MMB;

	public int BA_USG_CNT;

	public List<PartyMember> GetBattleMember()
	{
		return null;
	}

	public void SortMember()
	{
	}

	public int GetLeaderID()
	{
		return 0;
	}

	public PartyMember GetMember(int df)
	{
		return null;
	}
}
