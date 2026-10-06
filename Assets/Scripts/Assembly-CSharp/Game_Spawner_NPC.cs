using UnityEngine;

public class Game_Spawner_NPC : Game_Spawner_Base
{
	public int m_NPCID;

	public eFieldNPC m_NPCKind;

	public bool[] m_moveTime;

	public bool[] m_moveWeather;

	public int m_questID;

	public string m_talkFile;

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
