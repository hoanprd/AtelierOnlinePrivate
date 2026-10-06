using System;

[Serializable]
public class MasterRecordDFBase : MasterRecordBase
{
	public int DF;

	public override int GetMapKey()
	{
		return 0;
	}
}
