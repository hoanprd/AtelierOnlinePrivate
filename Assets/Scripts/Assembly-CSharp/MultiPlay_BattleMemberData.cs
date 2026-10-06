using System.Collections.Generic;
using UnityEngine;

public class MultiPlay_BattleMemberData : PhotonView_SyncData
{
	public List<AbnormalState> StateList;

	private Vector3 m_HitPos;

	public bool IsInit;

	public GameObject BattleObject;

	public int Team
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public int ItemUseCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsBurst
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float ActionTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float ActionTurn
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float NonActionTurn
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool Endured
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasBlazeArts
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsUsedBattleStartPassiveSkill
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 HitPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public float EffectSize
	{
		get
		{
			return 0f;
		}
	}

	public bool IsOwner
	{
		get
		{
			return false;
		}
	}

	public bool IsLeader
	{
		get
		{
			return false;
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
	}

	public bool IsChara
	{
		get
		{
			return false;
		}
	}

	public bool IsEnemy
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_CharaData CharaData
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_EnemyData EnemyData
	{
		get
		{
			return null;
		}
	}

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public bool IsNearDeath
	{
		get
		{
			return false;
		}
	}

	public bool IsPhysicalAttack
	{
		get
		{
			return false;
		}
	}

	public bool IsCloseRangeAttack
	{
		get
		{
			return false;
		}
	}

	public int WeaponKind
	{
		get
		{
			return 0;
		}
	}

	public int UniqueID
	{
		get
		{
			return 0;
		}
	}

	public float HPRate
	{
		get
		{
			return 0f;
		}
	}

	public float HPRateBefore
	{
		get
		{
			return 0f;
		}
	}

	public bool IsItemAble
	{
		get
		{
			return false;
		}
	}

	public int HP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HPBefore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HPMax
	{
		get
		{
			return 0;
		}
	}

	public float SP0
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SP1
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SP2
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SP3
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SP4
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SP5
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int Atk
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AtkOrigin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MagicAtk
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MagicAtkOrigin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Def
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MagicDef
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Dex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Eva
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Critical
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SkillAddition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float ActionSpeed
	{
		get
		{
			return 0f;
		}
	}

	public float ActionWait
	{
		get
		{
			return 0f;
		}
	}

	public bool IsHero
	{
		get
		{
			return false;
		}
	}

	public bool IsBoss
	{
		get
		{
			return false;
		}
	}

	public List<ActiveSkill> ActiveSkillList
	{
		get
		{
			return null;
		}
	}

	public List<ActiveSkill> BlazeArtsSkillList
	{
		get
		{
			return null;
		}
	}

	public List<ActiveSkill> PassiveSkillList
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_CharaMemberData CharaMemberData
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_EnemyMemberData EnemyMemberData
	{
		get
		{
			return null;
		}
	}

	public BattleCharaData BattleCharaData
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_BattleMemberData(string json)
	{
	}

	public MultiPlay_BattleMemberData()
	{
	}

	public MultiPlay_BattleMemberData(int team, int id, int index)
	{
	}

	public MultiPlay_BattleMemberData(int uniqueID)
	{
	}

	public void SetAutoActiveSkillCount(int skillId, int count)
	{
	}

	public int GetAutoActiveSkillCount(int skillId)
	{
		return 0;
	}

	public void ClearAllAutoActiveSkillCount()
	{
	}

	public bool SetTempPassiveSkill(int skillId, int turn)
	{
		return false;
	}

	public List<int> StringTotSkillIdList(string skillIdListStr)
	{
		return null;
	}

	public string AddNewTempPassiveSkillIdList(string skillIdListStr, int skillId)
	{
		return null;
	}

	public void CheckTempPassiveSkill()
	{
	}

	public List<ActiveSkill> GetTempPassiveSkillList()
	{
		return null;
	}

	public void ClearAllTempPassiveSkill()
	{
	}

	public void SetCoolTime(int key, int value)
	{
	}

	public int GetCoolTime(int key)
	{
		return 0;
	}

	public void UpdateState(int key, int value)
	{
	}

	public bool SetState(int key, int turn = 0)
	{
		return false;
	}

	public bool StateResistance(EBattleEffectTrigger trigger)
	{
		return false;
	}

	public int GetState(int key)
	{
		return 0;
	}

	public bool IsState(int key)
	{
		return false;
	}

	public bool IsStrongState(AbnormalState state)
	{
		return false;
	}

	public bool IsWeakState(AbnormalState state)
	{
		return false;
	}

	public List<AbnormalState> GetStateList()
	{
		return null;
	}

	public Dictionary<int, int> GetStateTurnDic()
	{
		return null;
	}

	public float GetStateEffect(EAbnormalStateEffect effect)
	{
		return 0f;
	}

	public void SetSP(int index, int sp)
	{
	}

	public float GetSP(int index)
	{
		return 0f;
	}

	public int ElementValue(int elementID)
	{
		return 0;
	}

	public int ElementValue(EElement element)
	{
		return 0;
	}

	public EElement GetWeakElement()
	{
		return EElement.eNONE;
	}

	private float GetRate(EBattleEffectTarget target)
	{
		return 0f;
	}

	private int GetValue(EBattleEffectTarget target)
	{
		return 0;
	}

	public bool IsUseSkill(int skillListID)
	{
		return false;
	}

	public ActiveSkill GetBlazeArtsSkill()
	{
		return null;
	}

	public bool IsUseBlazeArts()
	{
		return false;
	}

	private void Init(int team, int id, int index)
	{
	}
}
