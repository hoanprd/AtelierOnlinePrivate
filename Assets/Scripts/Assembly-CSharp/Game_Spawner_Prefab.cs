using System;
using UnityEngine;

public class Game_Spawner_Prefab : Game_Spawner_Base
{
	protected enum eCreateStep
	{
		Wait = 0,
		LoadAsset_Init = 1,
		LoadAsset_Wait = 2,
		Create = 3,
		End = 4
	}

	protected eCreateStep m_createStep;

	protected bool m_isCreateOK;

	protected string m_spawnPath;

	private Action<GameObject> m_createCallBack;

	protected bool m_useFader;

	[SerializeField]
	protected bool[] m_dispTimeArray;

	[SerializeField]
	protected bool[] m_dispWeatherArray;

	protected Game_Animal_GimmickFader m_dispFader;

	public GameObject m_spawnObject;

	public static string GetAssetPath(string optionData)
	{
		return null;
	}

	private void Update()
	{
	}

	protected virtual void Create()
	{
	}

	protected override void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	public bool IsCreateEnd()
	{
		return false;
	}

	public override void Spawn(Action<GameObject> callBack = null)
	{
	}

	public void SetDispArray(bool use, bool[] dispTimeArray = null, bool[] dispWeatherArray = null)
	{
	}

	protected override GameObject GetSpawnPrefabObject()
	{
		return null;
	}

	protected override Game_RaderMap_Marker.eMarkerKind GetRaderMapMarkerKind()
	{
		return Game_RaderMap_Marker.eMarkerKind.None;
	}

	public override eSpawnerKind GetSpawnerKind()
	{
		return eSpawnerKind.Ignore;
	}

	public override void SetSpawnerDataText(string optionData)
	{
	}

	protected override Color GetGizmoSphereColor()
	{
		return default(Color);
	}
}
