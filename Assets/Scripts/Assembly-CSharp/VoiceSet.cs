using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class VoiceSet
{
	public Dictionary<int, Game_Chara_BA_VoiceSet> m_vVoiceList;

	public Coroutine m_sLoading;

	public abstract string GetAssetPath(int id);

	protected int GetVoiceID(int charaID)
	{
		return 0;
	}

	public virtual AudioClip GetAudioClip(int chara, int id)
	{
		return null;
	}

	public void LoadStart(MonoBehaviour root, List<int> charaList)
	{
	}

	public void LoadStart(MonoBehaviour root, int chara)
	{
	}

	[DebuggerHidden]
	public virtual IEnumerator Load(List<int> charaList)
	{
		return null;
	}

	protected virtual string GetVoiceFilePath(int charaID)
	{
		return null;
	}

	public bool IsLoading()
	{
		return false;
	}

	public void Release()
	{
	}

	public void Release(int chara)
	{
	}

	public bool IsLoaded(int chara)
	{
		return false;
	}

	public virtual bool IsExist(int chara, int id)
	{
		return false;
	}
}
