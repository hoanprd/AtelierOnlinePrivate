using System.Collections.Generic;
using UnityEngine;

public class Game_Spawner_WindObject : Game_Spawner_Prefab
{
	public class CollStatus
	{
		public Vector3 center;

		public float radius;
	}

	public enum eCollText
	{
		CenterX = 0,
		CenterY = 1,
		CenterZ = 2,
		Radius = 3,
		EnumMax = 4
	}

	public static readonly int sr_iCheckCollMax;

	[SerializeField]
	private SphereCollider[] m_checkCollAry;

	private Game_Gimmick_Base m_gimmick;

	private List<CollStatus> m_collList;

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
