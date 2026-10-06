using UnityEngine;

public class Game_Spawner_Chara_Mob : Game_Spawner_Base
{
	public override eSpawnerKind GetSpawnerKind()
	{
		return eSpawnerKind.Ignore;
	}

	protected override string GetSpawnPrefabPath()
	{
		return null;
	}

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}
}
