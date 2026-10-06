using System.Collections.Generic;
using UnityEngine;

public class MultiPlay_FieldEffectData : PhotonView_SyncData
{
	public enum eLink
	{
		None = 0,
		Chara = 1
	}

	public bool IsCreated;

	public bool IsDestroyed;

	private float DestroyTime;

	private static readonly float RemoveOKSec;

	public GameObject Obj;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EffectID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LinkTarget
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int TargetID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector3 Offset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public int CreateSoundId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int RemoveSoundId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool RemoveFlag
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsExist
	{
		get
		{
			return false;
		}
	}

	public bool IsEnableData
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_FieldEffectData(Dictionary<string, object> obj)
	{
	}

	public MultiPlay_FieldEffectData(int index, int effectId)
	{
	}

	public static int GetIndex_LinkChara(int charaId, int effectId)
	{
		return 0;
	}

	public override void UpdateFromJson(string json)
	{
	}

	public void CreateCharaEffect(int charaId, Vector3 localPos)
	{
	}

	public void RemoveEffect()
	{
	}

	public void UpdateEffect()
	{
	}

	public void UpdateCharaEffect()
	{
	}

	public bool IsRemoveOK(float nowTime)
	{
		return false;
	}

	private void SetDestory(bool flag)
	{
	}

	private void Init()
	{
	}
}
