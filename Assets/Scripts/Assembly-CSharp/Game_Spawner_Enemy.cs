using UnityEngine;

public class Game_Spawner_Enemy : Game_Spawner_Base
{
	public enum eOption
	{
		EnemyKind = 0,
		SubId = 1,
		AIType = 2,
		MoveTime = 3,
		MoveWeather = 4,
		IsLocal = 5,
		FakeKind = 6,
		REncount = 7,
		REncountPer = 8,
		IsBoss = 9,
		AuraSize = 10,
		EnumMax = 11
	}

	public static readonly int sc_encountPerMag;

	public eEnemyKind m_spawnEnemyKind;

	public int m_spawnEnemySubId;

	public eFEnemyAIType m_aiType;

	public bool[] m_moveTime;

	public bool[] m_moveWeather;

	public bool m_isLocal;

	public eFakeEnemy m_fakeKind;

	public bool m_isRandomEncount;

	public float m_randomEncountPer;

	public bool m_isBoss;

	public eEnemyAuraSize m_auraSize;

	public static string GetAssetPath(string optionData)
	{
		return null;
	}

	protected override string GetSpawnPrefabPath()
	{
		return null;
	}

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	protected override Game_RaderMap_Marker.eMarkerKind GetRaderMapMarkerKind()
	{
		return Game_RaderMap_Marker.eMarkerKind.None;
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
