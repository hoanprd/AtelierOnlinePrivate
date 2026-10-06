using System.Collections.Generic;

public class MultiPlay_CharaMemberData : PhotonView_SyncData
{
	public EquipData EquipData;

	public bool UpdateAbnormalState;

	private List<ActiveSkill> m_ActiveSkillList;

	private List<ActiveSkill> m_BlazeArtsSkillList;

	private List<ActiveSkill> m_PassiveSkillList;

	public bool IsUpdateEquipment;

	public PartyCharaData PartyCharaData;

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

	public int CharaID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HairID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EyeID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HeadID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int BodyID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SkinColorID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HairColorID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EyeColorID
	{
		get
		{
			return 0;
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

	public int RaceKind
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

	public int WeaponKind
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int WeaponID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ShieldID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ShieldV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HelmID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ArmorID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AccID1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AccID2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AccID3
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ItemAuto
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsHero
	{
		get
		{
			return false;
		}
	}

	public MakeCharaData MakeCharaData
	{
		get
		{
			return null;
		}
	}

	public float HPRate
	{
		get
		{
			return 0f;
		}
	}

	public MultiPlay_CharaMemberData()
	{
	}

	public MultiPlay_CharaMemberData(string json)
	{
	}

	public MultiPlay_CharaMemberData(int index, PartyCharaData data)
	{
	}

	public List<ActiveSkill> ActiveSkillList()
	{
		return null;
	}

	public List<ActiveSkill> BlazeArtsSkillList()
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

	public void SetBlazeArtsSkillID(int key, int value)
	{
	}

	public int GetBlazeArtsSkillID(int key)
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

	public void SetElement(int key, int value)
	{
	}

	public int GetElement(int key)
	{
		return 0;
	}

	public void SetState(int key, int value)
	{
	}

	public int GetState(int key)
	{
		return 0;
	}

	public void HealState(EAbnormalState state)
	{
	}

	public bool IsState(EAbnormalState state)
	{
		return false;
	}

	public bool IsAnyState()
	{
		return false;
	}

	public void HealHP(float rate)
	{
	}

	public bool HealState(int[] stateList)
	{
		return false;
	}

	public override Dictionary<string, object> ToDictionary(bool isUpdate = false)
	{
		return null;
	}

	public override void UpdateFromDictionary(Dictionary<string, object> obj)
	{
	}

	public void UpdateBattleCharaData()
	{
	}

	public void UpdateBattleCharaData(MultiPlay_BattleMemberData member)
	{
	}

	public void UpdateState(MultiPlay_BattleMemberData member)
	{
	}

	public void SaveState()
	{
	}

	public void LoadState()
	{
	}

	public void UpdateFromMakeCharaData(MakeCharaData makeCharaData)
	{
	}

	public void UpdateBattleChara(BattlePlayerInfo member, ResponseDataCommon common, int num, CharaSpec overrideSpec = null)
	{
	}

	private void UpdateIndex(int index)
	{
	}

	private bool GetIsUpdateEquipment(Dictionary<string, object> obj)
	{
		return false;
	}
}
