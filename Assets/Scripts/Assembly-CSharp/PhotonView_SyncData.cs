using System.Collections.Generic;
using UnityEngine;

public class PhotonView_SyncData
{
	private const float FLT_TH = float.Epsilon;

	private const float VEC3_TH = 0.002f;

	private const float QUA_TH = 0.1f;

	public Dictionary<string, object> SyncData;

	public Dictionary<string, bool> SyncFlag;

	private Dictionary<string, Vector3> VectorLog;

	protected object tmpObj;

	protected Vector3 tmpVec3;

	private int updateCount;

	public string GetString(string key)
	{
		return null;
	}

	public bool GetBool(string key)
	{
		return false;
	}

	public int GetInt(string key, int num = 0)
	{
		return 0;
	}

	public long GetLong(string key)
	{
		return 0L;
	}

	public float GetFloat(string key)
	{
		return 0f;
	}

	public Vector3 GetVector3(string key)
	{
		return default(Vector3);
	}

	public Quaternion GetQuaternion(string key)
	{
		return default(Quaternion);
	}

	public void SetData(string key, object val)
	{
	}

	public void SetData(string key, int val)
	{
	}

	public void SetData(string key, long val)
	{
	}

	public void SetData(string key, float val, float th = float.Epsilon)
	{
	}

	private bool Equals(float val1, float val2, float th)
	{
		return false;
	}

	public void SetData(string key, string val)
	{
	}

	public void SetData(string key, bool val)
	{
	}

	public void SetData(string key, Vector3 val)
	{
	}

	public void SetData(string key, Quaternion val)
	{
	}

	public virtual Dictionary<string, object> ToDictionary(bool isUpdate = false)
	{
		return null;
	}

	public virtual string ToJson(bool isUpdate = false)
	{
		return null;
	}

	public virtual void UpdateFromDictionary(Dictionary<string, object> obj)
	{
	}

	public virtual void UpdateFromJson(string json)
	{
	}

	public virtual bool IsUpdateSyncData()
	{
		return false;
	}

	public virtual int GetUpdateCount()
	{
		return 0;
	}

	public bool IsUpdateSyncData(string key)
	{
		return false;
	}

	public virtual void ClearUpdateSyncData()
	{
	}

	public void ClearUpdateSyncData(string key)
	{
	}
}
