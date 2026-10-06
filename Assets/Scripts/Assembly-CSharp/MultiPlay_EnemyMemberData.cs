using System.Collections.Generic;

public class MultiPlay_EnemyMemberData : PhotonView_SyncData
{
	private List<ActiveSkill> m_ActiveSkillList;

	private List<ActiveSkill> m_PassiveSkillList;

	public BattleCharaData BattleCharaData;

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

	public int EnemyKind
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EnemySubId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Level
	{
		get
		{
			return 0;
		}
		set
		{
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
		set
		{
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

	public bool IsAddEnemy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string Name
	{
		get
		{
			return null;
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

	public int ActionSpeed
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int NextSkill
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

	public bool IsBoss
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAdventBattle
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float DropItem
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public string ModelPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public MultiPlay_EnemyMemberData(string json)
	{
	}

	public MultiPlay_EnemyMemberData(BattleEnemyInfo enemyInfo)
	{
	}

	public MultiPlay_EnemyMemberData(int df, int no, int lv)
	{
	}

	public void SetElement(int key, int value)
	{
	}

	public int GetElement(int key)
	{
		return 0;
	}

	public List<ActiveSkill> ActiveSkillList()
	{
		return null;
	}

	public List<ActiveSkill> PassiveSkillList()
	{
		return null;
	}

	public void SetActiveSkillID(int key, int value)
	{
	}

	public int GetActiveSkillID(int key)
	{
		return 0;
	}

	public void SetPassiveSkillID(int key, int value)
	{
	}

	public int GetPassiveSkillID(int key)
	{
		return 0;
	}

	public void UpdateBattleCharaData()
	{
	}

	public void MultiPlay_EnemyMemberDataUpadateJoin(BattleEnemyInfo enemyInfo)
	{
	}

	private void Init()
	{
	}
}
