using UnityEngine;

public class Game_Spawner_QuestArea : Game_Spawner_Base
{
	protected bool m_useFader;

	[SerializeField]
	protected bool[] m_dispTimeArray;

	[SerializeField]
	protected bool[] m_dispWeatherArray;

	protected Game_Animal_GimmickFader m_dispFader;

	protected override string GetSpawnPrefabPath()
	{
		return null;
	}

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	public override void UpdateSpotInfo()
	{
	}

	public void SetDispArray(bool use, bool[] dispTimeArray = null, bool[] dispWeatherArray = null)
	{
	}

	public override eSpawnerKind GetSpawnerKind()
	{
		return eSpawnerKind.Ignore;
	}
}
