using UnityEngine;

public class Game_Spawner_Gimmick : Game_Spawner_Prefab
{
	[SerializeField]
	private SphereCollider m_hitCollSub;

	[SerializeField]
	private float m_growHeight;

	[SerializeField]
	private float m_growClimbDir;

	private Vector3 m_collCenter;

	private float m_collRadius;

	private Game_Gimmick_Base m_gimmick;

	public bool m_isLocal;

	protected override void Create()
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

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	public Game_Gimmick_Base GetGimmick()
	{
		return null;
	}
}
