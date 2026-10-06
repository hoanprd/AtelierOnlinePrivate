using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CinemaManager : UIBase
{
	private object[] m_list;

	private bool m_bFinish;

	private Dictionary<string, object> m_registerList;

	private List<GameObject> m_objectList;

	private MultiPlay_BattleMemberData m_actionMember;

	private List<MultiPlay_BattleMemberData> m_targetMemberList;

	private List<MultiPlay_BattleMemberData> m_deathMemberList;

	public PhotonView_MultiPlay.eActionKind m_action;

	public List<MasterCinema> m_cinemaMasterList;

	private List<Method> m_methodList;

	public bool IsFinish
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_BattleMemberData ActionMember
	{
		get
		{
			return null;
		}
	}

	public List<MultiPlay_BattleMemberData> TargetMemberList
	{
		get
		{
			return null;
		}
	}

	public List<MultiPlay_BattleMemberData> DeathMemberList
	{
		get
		{
			return null;
		}
	}

	[DebuggerHidden]
	private IEnumerator VectorLerp(Vector3 a, Vector3 b, float t, Action<Vector3> didProc = null)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator FloatLerp(float a, float b, float t, Action<float> didProc = null)
	{
		return null;
	}

	public static CinemaManager Create(GameObject parent)
	{
		return null;
	}

	public static CinemaManager Play(GameObject parent, string path, object[] list = null, Action<CinemaManager> didEnd = null)
	{
		return null;
	}

	public void SetRegister(string key, object value)
	{
	}

	private void Awake()
	{
	}

	public void Init(string path, object[] list = null, Action<CinemaManager> didEnd = null)
	{
	}

	[DebuggerHidden]
	private IEnumerator PlayMain(List<Method> methodList, Action<CinemaManager> didEnd)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator PlayCommand(Method method, int section = 0, Action<bool> callback = null)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator StartCutIn()
	{
		return null;
	}

	private void ConvertText2CommandLine(List<Method> methodList)
	{
	}

	private Method GetSectionStartCommand(eMethodType type, string arg)
	{
		return null;
	}

	private int GetSectionEndCommand(Method method, int section)
	{
		return 0;
	}

	private object GetRegister(string name)
	{
		return null;
	}

	private bool GetRegisterBool(string name)
	{
		return false;
	}

	private int GetRegisterInt(string name)
	{
		return 0;
	}

	private float GetRegisterFloat(string name)
	{
		return 0f;
	}

	private string GetRegisterString(string name)
	{
		return null;
	}

	private GameObject GetRegisterGameObject(string name)
	{
		return null;
	}

	private MultiPlay_BattleMemberData GetRegisterBattleMember(string name)
	{
		return null;
	}

	private CinemaManager GetRegisterCinemaManager(string name)
	{
		return null;
	}

	private T FindObjectFromName<T>(GameObject root, string name = null) where T : Component
	{
		return null;
	}

	private T FindObjectFromName<T>(string name = null) where T : Component
	{
		return null;
	}
}
