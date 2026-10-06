using UnityEngine;

public class Game_Spawner_Item : Game_Spawner_Base
{
	public enum eSpawnItemKind
	{
		Egg = 0,
		Kinoko = 1,
		Grass = 2,
		Stone = 3,
		Flower = 4,
		Fishing = 5,
		CatchNet = 6,
		Quest = 7,
		RainWater = 8,
		Tree = 9,
		FrogOil = 10,
		Grape = 11,
		Bird = 12,
		Rabbits = 13,
		Carriage = 14,
		TreeS = 15,
		FlowerN = 16,
		StoneN = 17,
		Mouse = 18,
		Gull = 19,
		ShiningFishing = 20,
		EnumMax = 21
	}

	private static readonly string[] m_itemTexName;

	public eSpawnItemKind m_spawnItemKind;

	public GameObject m_carriageTarget;

	public int m_carriageId;

	private Game_Item_PickUp_Base m_spawnedScr;

	private Vector3 m_targetPos;

	private static readonly string m_filePath_Texture;

	private static readonly Game_Item_PickUp_Base.ePickUpItemKind[] m_pickUpItemKindArray;

	public static void MakeSpawner(eSpawnItemKind kind, Vector3 pos)
	{
	}

	public static void SetItemKind(Game_Item_PickUp_Base gim, eSpawnItemKind kind, bool editor = false)
	{
	}

	public override Vector3 GetCreateRot(Vector3 original)
	{
		return default(Vector3);
	}

	protected override string GetSpawnPrefabPath()
	{
		return null;
	}

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	protected void SetAnimal(string path, bool isSpawnOK, string objName)
	{
	}

	protected void SetCarriage(string path, bool isSpawnOK, string objName)
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

	public override bool IsRespawnOK()
	{
		return false;
	}

	protected override Color GetGizmoSphereColor()
	{
		return default(Color);
	}
}
