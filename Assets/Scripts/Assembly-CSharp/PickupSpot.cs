using System;

[Serializable]
public class PickupSpot : SpotBase
{
	[Serializable]
	public class Tool
	{
		public int DF;
	}

	public string ICON;

	public Tool[] TL;

	public string PK;

	public void MakeTutorialData(int no, int pos)
	{
	}

	public void MakeTutorialUpdateData(int no)
	{
	}

	public override void UpdatePKTime()
	{
	}

	public override bool IsSpawnOK()
	{
		return false;
	}
}
