using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Game_Field_Manager : MonoBehaviour
{
	private static Game_Field_Manager m_inst;

	public bool IsMultiPlay;

	private GameObject[] m_fieldRootObj;

	private GameObject[] m_fieldMainObj;

	private Dictionary<int, Game_BattleArea_Base> m_battleMainObj;

	protected GameObject m_navmeshObj;

	private GameObject m_spawnerMng;

	private FieldSceneLoader m_fieldLoader;

	private bool m_isEndCreate;

	private bool m_isEndClear;

	private Game_Gimmick_EXDungeonWarpGate[] m_ExDungeonWarpGates;

	private List<Material> materialList;

	public static Game_Field_Manager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	public static string GetAreaTitleAssetPath(int areaId)
	{
		return null;
	}

	public static List<string> GetAssetPathList(int areaId)
	{
		return null;
	}

	public void ClearField()
	{
	}

	[DebuggerHidden]
	private IEnumerator UnloadScene()
	{
		return null;
	}

	public bool IsEndClearField()
	{
		return false;
	}

	public void Initialize()
	{
	}

	public Transform GetFieldRootTransform(eAreaKind kind)
	{
		return null;
	}

	public GameObject GetMapSceneRoot()
	{
		return null;
	}

	public Game_MapArea_Base GetCurrentMapArea()
	{
		return null;
	}

	public Game_BattleArea_Base GetCurrentBattleArea(int areaKind = 1)
	{
		return null;
	}

	public void CreateField_MapArea(int areaId, int stageId)
	{
	}

	[DebuggerHidden]
	private IEnumerator MapAreaLoad(int areaId, int stageId)
	{
		return null;
	}

	private void FailedCallback()
	{
	}

	private void RetryCallback(Action<AssetLoader.eRetry> callback)
	{
	}

	public float GetCreateFieldProgress()
	{
		return 0f;
	}

	public bool IsEndCreateField()
	{
		return false;
	}

	private void MakeNavMesh(int areaId, int stageId, bool isDungeon, bool isParts, GameObject root)
	{
	}

	public void MakeField_BattleArea()
	{
	}

	[DebuggerHidden]
	public IEnumerator LoadBattleArea()
	{
		return null;
	}

	private void AddBAPathDic(int areaKind, string path, ref Dictionary<int, string> pathDic)
	{
	}

	private void MatChange(Transform parent)
	{
	}

	private void ChangeMatRatio()
	{
	}

	public void ChangeField_MapArea(int areaId, int stageId)
	{
	}

	public void SetEnableField(eAreaKind kind, int areaKind = 1)
	{
	}

	public Transform GetSpawnerRoot()
	{
		return null;
	}

	private void LoadExDungeonWarpGate()
	{
	}

	public void ExecExqClearResult()
	{
	}
}
