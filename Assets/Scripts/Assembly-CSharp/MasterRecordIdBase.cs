using System;

[Serializable]
public class MasterRecordIdBase : MasterRecordBase
{
	public int id;

	public override int GetMapKey()
	{
		return 0;
	}
}
