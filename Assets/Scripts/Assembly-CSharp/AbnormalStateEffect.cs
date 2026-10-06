using System;

[Serializable]
public class AbnormalStateEffect : MasterRecordIdBase
{
	public string name;

	public int group;

	public EAbnormalStateTarget trarget;

	public float value;
}
