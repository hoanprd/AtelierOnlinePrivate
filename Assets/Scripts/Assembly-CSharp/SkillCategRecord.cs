using System;

[Serializable]
public class SkillCategRecord : MasterRecordBase
{
	public int iInventoryKind;

	public int iLargeCategory;

	public int iID;

	public string sName;

	public override int GetMapKey()
	{
		return 0;
	}
}
