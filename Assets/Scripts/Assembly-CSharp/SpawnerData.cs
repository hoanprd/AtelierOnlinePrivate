using System;
using System.Collections.Generic;
using Spawner;
using UnityEngine;

[Serializable]
public class SpawnerData
{
	public int no;

	public int pos;

	public eSpawnerKind makeKind;

	public Vector3 makePos;

	public Vector3 makeRot;

	public eSpawnControlKind ctrlKind;

	public eSpawnControlExec ctrlExec;

	public List<int> ctrlFlag;

	public string optionData;

	public bool isSearched;

	private bool isUnlock;

	private bool isUpdateControl;

	public GameObject spawnDgnObj;

	public bool spawned;

	public Game_Spawner_Base spawnScr;

	public void UpdateControlFlag(bool flag)
	{
	}

	public bool IsUnlockArea()
	{
		return false;
	}

	public bool IsQuestStatus(EQuestSTT stt)
	{
		return false;
	}

	public bool IsSyncGimmick()
	{
		return false;
	}

	public bool IsPrefabGimmick()
	{
		return false;
	}

	public static string GetSpawnTextAssetPath(int areaId, int stageId, bool dungeon)
	{
		return null;
	}
}
