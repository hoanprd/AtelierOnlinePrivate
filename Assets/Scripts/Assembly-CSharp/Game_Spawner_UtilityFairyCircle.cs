using UnityEngine;

public class Game_Spawner_UtilityFairyCircle : Game_Spawner_Prefab
{
	private enum eMode
	{
		Field = 0,
		Dungeon = 1,
		FieldDungeon = 2
	}

	public int m_jumpAreaId;

	public int m_jumpStageId;

	public int m_jumpSpawnId;

	public int m_jumpDungeonId;

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

	private void SetEnable<T>(ref T script, GameObject parent) where T : MonoBehaviour
	{
	}

	private void SetDisable<T>(T script) where T : MonoBehaviour
	{
	}
}
