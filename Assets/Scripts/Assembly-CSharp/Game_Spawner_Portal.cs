using UnityEngine;

public class Game_Spawner_Portal : Game_Spawner_Base
{
	public enum ePortalKind
	{
		Field = 0,
		DungeonWayPoint = 1
	}

	public int m_portalId;

	public ePortalKind m_portalKind;

	protected override string GetSpawnPrefabPath()
	{
		return null;
	}

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	public override eSpawnerKind GetSpawnerKind()
	{
		return eSpawnerKind.Ignore;
	}

	public override string GetSpawnerDataText()
	{
		return null;
	}

	public override void SetSpawnerDataText(string optionData)
	{
	}

	protected override Color GetGizmoSphereColor()
	{
		return default(Color);
	}
}
