using System;

[Serializable]
public class MasterDegreeInfo
{
	public int DF;

	public int STP;

	public int TYP;

	public int RTY;

	public string NAME;

	public string DESC;

	public int PRIO;

	public int KEY_SIDE_QUEST;

	public int GetRarity()
	{
		return 0;
	}

	public int GetKind()
	{
		return 0;
	}
}
