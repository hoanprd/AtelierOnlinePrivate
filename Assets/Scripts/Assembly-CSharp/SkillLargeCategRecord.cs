using System;

[Serializable]
public class SkillLargeCategRecord : MasterRecordBase
{
	public int iID;

	public string sName;

	public override int GetMapKey()
	{
		return 0;
	}
}
