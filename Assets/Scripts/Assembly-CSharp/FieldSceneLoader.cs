using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldSceneLoader : MonoBehaviour
{
	private static FieldSceneLoader s_instance;

	private static Scene s_scene;

	private static AssetBundle s_sceneBudnle;

	private static string s_fieldPath;

	private bool m_isEndCreateFiled;

	private bool m_isEndClearField;

	private float m_makeFieldProgress;

	private GameObject m_fieldRootObj;

	public static FieldSceneLoader Instance
	{
		get
		{
			return null;
		}
	}

	public static string GetFieldSceneName(int areaId, int stageId, bool isDungeon)
	{
		return null;
	}

	public static string GetFieldAssetPath(int areaId, int stageId, bool isDungeon)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public GameObject GetFieldRootObj()
	{
		return null;
	}

	public void CreateField(int areaId, int stageId, Action failedCb = null, Action<Action<AssetLoader.eRetry>> retryCb = null)
	{
	}

	[DebuggerHidden]
	private IEnumerator MapAreaLoad(int areaId, int stageId, Action failedCb, Action<Action<AssetLoader.eRetry>> retryCb)
	{
		return null;
	}

	public float GetCreateFieldProgress()
	{
		return 0f;
	}

	public bool IsEndCreateField()
	{
		return false;
	}

	public void ClearField()
	{
	}

	[DebuggerHidden]
	private IEnumerator UnloadScene()
	{
		return null;
	}

	private void UnloadSceneBundle()
	{
	}

	public bool IsEndClearField()
	{
		return false;
	}
}
