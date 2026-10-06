using UnityEngine;

public class Game_Spawner_Animal : Game_Spawner_Base
{
	public enum eSpawnAnimalKind
	{
		Rabbit = 0,
		Butterfly = 1,
		Frog = 2,
		Wolf = 3,
		Bird = 4,
		Bee = 5,
		Gull = 6,
		EnumMax = 7
	}

	public eSpawnAnimalKind m_spawnObjKind;

	private static readonly string m_filePath;

	private static readonly string[] m_fileNameArray;

	protected override string GetSpawnPrefabPath()
	{
		return null;
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

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	protected override Color GetGizmoSphereColor()
	{
		return default(Color);
	}
}
