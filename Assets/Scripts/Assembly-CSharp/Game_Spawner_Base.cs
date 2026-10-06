using System;
using System.Collections.Generic;
using Spawner;
using UnityEngine;

public class Game_Spawner_Base : MonoBehaviour
{
	protected bool m_spawnObjActive;

	private static int m_enableSpawnCount_Now;

	private static readonly int m_enableSpawnCount_Max;

	protected int m_pos;

	protected int m_no;

	protected bool m_spawned;

	protected GameObject m_spawnedObj;

	protected GameObject m_markerObj;

	public eSpawnControlKind m_spawnCtrlKind;

	public List<int> m_spawnCtrlFlgIdList;

	public eSpawnControlExec m_spawnExecKind;

	public bool m_debugDrawFlag;

	public virtual void Spawn(Action<GameObject> callBack = null)
	{
	}

	public void SetActiveSpawnedObj(bool active)
	{
	}

	public virtual void UpdateSpotInfo()
	{
	}

	public virtual void Kill()
	{
	}

	public virtual Vector3 GetCreatePos(Vector3 original)
	{
		return default(Vector3);
	}

	public virtual Vector3 GetCreateRot(Vector3 original)
	{
		return default(Vector3);
	}

	protected virtual GameObject GetSpawnPrefabObject()
	{
		return null;
	}

	protected virtual string GetSpawnPrefabPath()
	{
		return null;
	}

	public string GetSpawnPrefabPath_Public()
	{
		return null;
	}

	protected virtual void SetSpawnObjectParam(int pos, int no, GameObject spawned)
	{
	}

	protected virtual Game_RaderMap_Marker.eMarkerKind GetRaderMapMarkerKind()
	{
		return Game_RaderMap_Marker.eMarkerKind.None;
	}

	public virtual string GetSpawnerDataText()
	{
		return null;
	}

	public virtual eSpawnerKind GetSpawnerKind()
	{
		return eSpawnerKind.Ignore;
	}

	protected string GetSpawnerInfo()
	{
		return null;
	}

	public virtual void SetPos(int pos)
	{
	}

	public virtual void SetNo(int no)
	{
	}

	public virtual void SetSpawnerDataText(string optionData)
	{
	}

	public virtual bool IsRespawnOK()
	{
		return false;
	}

	public void OnDrawGizmos()
	{
	}

	protected virtual Color GetGizmoSphereColor()
	{
		return default(Color);
	}
}
