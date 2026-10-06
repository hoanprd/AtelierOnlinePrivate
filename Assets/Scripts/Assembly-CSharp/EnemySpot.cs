using System;

[Serializable]
public class EnemySpot : SpotBase
{
	public int DF;

	public int LV;

	public string RP;

	public override void UpdatePKTime()
	{
	}

	public override bool IsSpawnOK()
	{
		return false;
	}

	public void MakeTutorialData(int no, int pos)
	{
	}
}
