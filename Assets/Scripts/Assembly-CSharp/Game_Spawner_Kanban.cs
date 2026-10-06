using UnityEngine;

public class Game_Spawner_Kanban : Game_Spawner_Base
{
	public enum eKanbanType
	{
		None = 0,
		Kanban_101 = 1,
		Kanban_102 = 2,
		Kanban_001 = 3,
		Kanban_002 = 4,
		Kanban_003 = 5,
		Kanban_004 = 6
	}

	[Multiline]
	public string m_kanbanText;

	public float m_visibleDistance;

	public eKanbanType m_kanbanType;

	private GameObject m_kanbanObj;

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

	public override void Kill()
	{
	}
}
